using Pet_Care.View;
using Microsoft.Extensions.Configuration;
using DotNetEnv;

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

            Env.Load();
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Splash_Screen());
        }
    }
}