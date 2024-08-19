using Logilearn_v2.Forms;
using System;
using System.Windows.Forms;

namespace Logilearn_v2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load the loading screen
            LoadingScreen loadingScreen = new LoadingScreen();
            Application.Run(loadingScreen);

            // If loading screen has configured the settings, load the home page and close loading page

            if (loadingScreen.connected)
            {
                Application.Run(new HomePage(loadingScreen.arduinoCOMPort));
            }
        }
    }
}
