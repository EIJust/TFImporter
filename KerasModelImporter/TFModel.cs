using System;
using System.Linq;
using TensorFlow;

namespace TFModelImporter
{
    public class TFModel : IModel
    {
        private TFGraph _graph;

        public IModelResultConvertor ResultConvertor { get; }
        public TFGraph Graph
        {
            get { return _graph; }
            private set { _graph = value; }
        }

        public TFModel(TFGraph graph)
        {
            Graph = graph;
        }

        public IModelResult Eval(IFeatures feature)
        {
            var inputValuesTensors = feature.GetFeaturesTensors();

            TFOutput output = new TFOutput();
            TFOutput input = new TFOutput();

            lock (_graph)
            {
                using (var session = new TFSession(Graph))
                {
                    var result = session.Run(
                             inputs: new[] { input },
                             inputValues: inputValuesTensors.ToArray(),
                             outputs: new[] { output });

                    return ResultConvertor.Convert(result);
                }
            }
        }
    }
}
