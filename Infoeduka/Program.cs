using Infoeduka.UserControls;

namespace Infoeduka
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Stvori novu instancu MainForm - a
            MainForm mainForm = new MainForm();
            

            // Postavi LoginPanel kao vidljivog
            Application.Run(mainForm);



        }
    }
}