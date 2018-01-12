using System.IO;
using TensorFlow;

namespace TFModelImporter
{
    public class TFModelLoader : IModelLoader
    {
        public IModel Load(string path)
        {
            TFGraph graph = new TFGraph();
            graph.Import(File.ReadAllBytes(path));
            return new TFModel(graph);
        }
    }
}
