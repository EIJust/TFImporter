using KerasModelImporter;

namespace KerasModelImporter_TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TFModelLoader loader = new TFModelLoader();
            IModel model = loader.Load(@"C:\Users\Egor\source\repos\KerasModelImporter\KerasModelImporter_TestApp\fp_model.h5");
        }
    }
}
