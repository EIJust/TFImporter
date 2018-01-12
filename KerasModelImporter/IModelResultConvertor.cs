using TensorFlow;

namespace TFModelImporter
{
    public interface IModelResultConvertor
    {
        IModelResult Convert(TFTensor[] value);
    }
}
