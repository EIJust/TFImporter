namespace TFModelImporter
{
    public class InvalidNumberFormatterClassifierModelResult: IModelResult
    {
        bool IsTruePositive { get; }

        public InvalidNumberFormatterClassifierModelResult(bool isTruePositive)
        {
            IsTruePositive = isTruePositive;
        }
    }
}
