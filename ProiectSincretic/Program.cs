
namespace ProiectSincretic
{
    internal static class @interface
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Meniu_principal M0 = new Meniu_principal();

            Application.Run(M0);
            
        }
    }
}