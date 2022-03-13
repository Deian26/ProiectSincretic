
namespace ProiectSincretic
{
    internal static class @interface
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            Application.Run(new Meniu_principal());
        }
    }
}