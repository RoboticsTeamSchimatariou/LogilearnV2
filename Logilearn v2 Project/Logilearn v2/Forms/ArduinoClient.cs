using System.IO.Ports;
using System.Threading;

namespace Logilearn_v2.Forms
{
    internal class ArduinoClient
    {
        private string portName;
        private SerialPort port;

        public ArduinoClient(Thread runThread)
        {
            portName = FindSerialPort();
        }

        public ArduinoClient(string portName)
        {
            this.portName = portName;
        }

        public ArduinoClient()
        {
            portName = FindSerialPort();
        }


        //Function to list all ports
        private string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        //Function to find working port
        private string FindSerialPort()
        {
            foreach (string portName in GetPorts())
            {
                try
                {
                    // Open port
                    SerialPort port = new SerialPort(portName, Properties.Settings.Default.arduino_baud_rate, Parity.None, 8, StopBits.One);
                    port.DtrEnable = true;
                    port.Open();
                    port.ReadTimeout = 200;

                    Thread.Sleep(Properties.Settings.Default.arduino_response_time);

                    if (port.IsOpen)
                    {
                        // Do authentication with Arduino
                        string code = port.ReadLine();

                        if (code != null && code.Contains(Properties.Settings.Default.arduino_confirmation_code))
                        {
                            // Confirm to Arduino that the client is connected
                            port.Write(Properties.Settings.Default.arduino_confirmation_code);
                            port.Close();
                            return portName;
                        }
                    }

                    port.Close();
                }

                catch
                { }
            }

            return null;
        }

        public bool isConnected()
        {
            return portName != null;
        }

        public string GetArduinoCOM()
        {
            return portName;
        }

        public void EstablishConnection()
        {
            port = new SerialPort(portName, Properties.Settings.Default.arduino_baud_rate, Parity.None, 8, StopBits.One);
            port.Open();
            port.ReadTimeout = 200;
        }

        public void SendData(string data)
        {
            port.Write(data);
        }

        public void DeactivateConnection()
        {
            port.Close();
        }
    }
}
