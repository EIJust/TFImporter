using System.Collections.Generic;
using TensorFlow;

namespace TFModelImporter
{
    public interface IFeatures
    {
        IEnumerable<TFTensor> GetFeaturesTensors();
    }
}
