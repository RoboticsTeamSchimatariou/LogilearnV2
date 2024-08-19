using System;
using System.Threading;
using System.Windows.Forms;

namespace Logilearn_v2.Forms
{
    public partial class LoadingScreen : Form
    {
        // The Loading Screen: Just a simple form with a progress bar to add a nice touch to the application

        public bool connected = false;
        public string arduinoCOMPort;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Shown(object sender, EventArgs e)
        {
            // Making secondary thread so UI keeps running smoothly

            Thread secondaryThread = new Thread(() =>
            {
                // Checking which port is the Arduino Port
                ArduinoClient arduinoClient = new ArduinoClient();

                if (!arduinoClient.isConnected())
                {
                    if (MessageBox.Show("Δεν συνδέθηκε η εφαρμογή με την κατασκευή Logilearn. Θέλετε να δοκιμάσετε να ανοίξετε ξανά την εφαρμογή;", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }

                else
                {
                    connected = true;
                    arduinoCOMPort = arduinoClient.GetArduinoCOM();
                    BeginInvoke(new MethodInvoker(() => Close()));
                }
            });

            secondaryThread.Start();
        }
    }
}
