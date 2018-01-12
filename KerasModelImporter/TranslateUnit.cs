using System.Collections.Generic;
using System.Text;
using TensorFlow;

namespace TFModelImporter
{
    //TODO: add other types
    public enum TranslateErrorType { None, InvalidNumberFormatter }

    public class TranslateUnit: IFeatures
    {
        public string Source { get; }
        public string Target { get; }

        public TranslateErrorType TranslateError { get; }

        public TranslateUnit(string source, string target, TranslateErrorType errorType = TranslateErrorType.None)
        {
            Source = source;
            Target = target;
            TranslateError = errorType;
        }

        public IEnumerable<TFTensor> GetFeaturesTensors()
        {
            byte[] sourceAsciiBytes = Encoding.ASCII.GetBytes(Source);
            byte[] targetAsciiBytes = Encoding.ASCII.GetBytes(Target);

            TFTensor sourceTensor = new TFTensor(sourceAsciiBytes);
            TFTensor targetTensor = new TFTensor(sourceAsciiBytes);

            return new[] { sourceTensor, targetTensor };
        }
    }
}
