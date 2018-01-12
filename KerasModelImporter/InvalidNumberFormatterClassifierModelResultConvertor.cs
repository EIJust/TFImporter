using System;
using TensorFlow;

namespace TFModelImporter
{
    public class InvalidNumberFormatterClassifierModelResultConvertor : IModelResultConvertor
    {
        public IModelResult Convert(TFTensor[] value)
        {
            var result = (int[])(value[0].GetValue());

            return new InvalidNumberFormatterClassifierModelResult(result[0] < result[1]);
        }
    }
}
