using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Logilearn_v2.Forms
{
    public partial class IntervalForm : Form
    {
        //Interval Form: The form where you learn about intervals and send the interval information to Arduino

        //Bit Array: the array that's going to be sent to Arduino (refer to Logilearn v2 Paper)
        //0 for OFF, 1 for ON
        //Index 0: Status LED P1
        //Index 1: Status LED P2
        //Index 2: Status LED Strip P1_P3
        //Index 3: Status LED Strip P3_P5
        //Index 4: Status LED Strip P2_P5
        //Index 5: Status LED Strip P3_P4
        //Index 6: Status LED Strip P5_P6

        private byte[] intervalInfo = { 0, 0, 0, 0, 0, 0, 0 };

        //Dictionary: the interval bit array values to the interval description they correspond to
        private Dictionary<string, string> intervalTypes = new Dictionary<string, string>()
        {
            {"1111100", "[a, b]"},
            {"0011100", "(a, b)"},
            {"1011100", "[a, b)"},
            {"0111100", "(a, b]"},
            {"1011001", "[a, +∞)"},
            {"0011001", "(a, +∞)"},
            {"0101110", "(-∞, b]"},
            {"0001110", "(-∞, b)"},
            {"0001011", "(-∞, +∞)"}
        };

        private ArduinoClient arduinoClient;


        public IntervalForm(string arduinoCOMPort)
        {
            InitializeComponent();

            //Create a arduino client class
            arduinoClient = new ArduinoClient(arduinoCOMPort);
            arduinoClient.EstablishConnection();
        }

        //picReturn (button for exitting the application): status changes
        #region picReturn
        //picReturn: mouse is hovering over
        private void PicReturn_MouseEnter(object sender, EventArgs e)
        {
            //Invert colors and images

            picReturn.Image = Properties.Resources.return_inverted;
            picReturn.BackColor = Color.White;
        }

        //picReturn: mouse is leaving
        private void PicReturn_MouseLeave(object sender, EventArgs e)
        {
            //Invert colors and images

            picReturn.Image = Properties.Resources._return;
            picReturn.BackColor = Properties.Settings.Default.main_color;
        }

        //picReturn is clicked
        private void PicReturn_Click(object sender, EventArgs e)
        {
            //Return to Home Page
            arduinoClient.DeactivateConnection();
            Close();
        }
        #endregion

        //Function to check whether a string is a integer or not
        private bool IsValidInteger(string input, out BigInteger result)
        {
            // Regular expression to match a valid integer (including negative numbers)
            if (Regex.IsMatch(input, @"^-?\d+$"))
            {
                return BigInteger.TryParse(input, out result);
            }
            result = 0;
            return false;
        }

        //Button for when the user clicks to generate interval
        private void btnGenerateInterval_Click(object sender, EventArgs e)
        {
            //Checking if the input is a valid integer
            if (IsValidInteger(txtLeftBound.Text, out BigInteger leftBound) && IsValidInteger(txtRightBound.Text, out BigInteger rightBound))
            {
                //Checking if a < b
                if (leftBound < rightBound)
                {
                    //Preparing data packet and drawing interval
                    string intervalDataPacket = ConfigureInterval();
                    DrawInterval(leftBound, rightBound, intervalDataPacket);

                    //Sending data packet to Arduino
                    arduinoClient.SendData(intervalDataPacket);
                }

                else
                {
                    MessageBox.Show("Πρέπει η τιμή του αριστερού άκρου να είναι μικρότερη απ' τη τιμή του δεξιού άκρου.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Παρακαλώ να εισάγετε μόνο αριθμούς στο πεδίο των ακρών.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //The function that draws the interval by changing the visibility value of white panels based on array intervalInfo[]
        private void DrawInterval(BigInteger leftBound, BigInteger rightBound, string dataPacket)
        {
            //Drawing the interval according to the byte array
            P1.Visible = Convert.ToBoolean(intervalInfo[0]);
            P2.Visible = Convert.ToBoolean(intervalInfo[1]);
            P1_P3.Visible = Convert.ToBoolean(intervalInfo[2]);
            P3_P5.Visible = Convert.ToBoolean(intervalInfo[3]);
            P2_P5.Visible = Convert.ToBoolean(intervalInfo[4]);
            P3_P4.Visible = Convert.ToBoolean(intervalInfo[5]);
            P5_P6.Visible = Convert.ToBoolean(intervalInfo[6]);

            //Showing the infinity signs
            lblPositiveInfinity.Visible = Convert.ToBoolean(intervalInfo[6]);
            lblNegativeInfinity.Visible = Convert.ToBoolean(intervalInfo[5]);

            //Finding the interval type
            string intervalType = intervalTypes[dataPacket];
            intervalType = intervalType.Replace("a", leftBound.ToString()).Replace("b", rightBound.ToString());

            lblIntervalType.Text = intervalType;

            lblIntervalTypeHeader.Show();
            lblIntervalType.Show();
        }

        //The function that sets the values to the byte array for the interval info (refer to Logilearn v2 Paper)
        private string ConfigureInterval()
        {
            //Setting up the byte array according to the interval configuration from the user
            Array.Clear(intervalInfo, 0, intervalInfo.Length);

            intervalInfo[0] = Convert.ToByte(rbLeftBoundClosed.Checked);
            intervalInfo[1] = Convert.ToByte(rbRightBoundClosed.Checked);

            if (!rbLeftBoundInfinite.Checked && !rbRightBoundInfinite.Checked)
            {
                intervalInfo[2] = 1;
                intervalInfo[3] = 1;
                intervalInfo[4] = 1;
            }

            else if (rbLeftBoundInfinite.Checked && rbRightBoundInfinite.Checked)
            {
                intervalInfo[3] = 1;
                intervalInfo[5] = 1;
                intervalInfo[6] = 1;
            }

            else if (rbLeftBoundInfinite.Checked && !rbRightBoundInfinite.Checked)
            {
                intervalInfo[3] = 1;
                intervalInfo[4] = 1;
                intervalInfo[5] = 1;
            }

            else if (!rbLeftBoundInfinite.Checked && rbRightBoundInfinite.Checked)
            {
                intervalInfo[2] = 1;
                intervalInfo[3] = 1;
                intervalInfo[6] = 1;
            }

            return string.Join("", intervalInfo);
        }
    }
}
