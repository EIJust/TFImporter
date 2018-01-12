namespace TFModelImporter
{
    public interface IModel
    {
        IModelResult Eval(IFeatures feature);
    }
}
