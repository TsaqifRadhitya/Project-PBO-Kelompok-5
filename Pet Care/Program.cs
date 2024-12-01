using Pet_Care.View.Splash_Screen;
using Microsoft.Extensions.Configuration;

namespace Pet_Care
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

            EnvLoader.LoadEnvironmentVariables();
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Splash_Screen());
        }
    }
}