using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logilearn_v2.Forms
{
    public partial class LogicForm : Form
    {
        //Logic Form: The form where you learn about the basics of logic and control the train from the Arduino

        //Bit Array: the array that's going to be sent to Arduino (refer to Logilearn v2 Paper)
        //0 for NO, 1 for YES
        //Index 0: Bar 1 OPEN
        //Index 1: Bar 2 OPEN
        //Index 2: Bar 1 ROTATED
        //Index 3: Bar 2 ROTATED
        //Index 4: Train PASS

        private ArduinoClient arduinoClient;

        private bool validityP;
        private bool validityQ;

        public LogicForm(string arduinoCOMPort)
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

        private async void btnCheckLogic_ClickAsync(object sender, EventArgs e)
        {
            //Check inputs first for character limit
            string statementP = txtStatementP.Text;
            string statementQ = txtStatementQ.Text;

            int characterLimit = 200;

            if (statementP.Length > characterLimit || statementQ.Length > characterLimit)
            {
                MessageBox.Show($"Επιτρέπονται μέχρι {characterLimit} χαρακτήρες στους ισχυρισμούς.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string logicData = await ConstructLogic(txtStatementP.Text, txtStatementQ.Text);
                arduinoClient.SendData(logicData);
            }
        }

        private async Task<bool> CheckValidity(string statementP, string statementQ)
        {
            //API KEY IS FREE, SO SECURITY IS OVERLOOKED
            string API_URL = "https://api.arliai.com/v1/completions";
            string API_KEY = "ef4c64ef-563f-4631-ad4f-d91139cf009f";

            string instructions = "You are a logic checker machine. You'll be provided with two statements P and Q. You need to tell me whether each one is factually true or not. Your response should be this exact form every single time: \"[validity of P], [validity of Q]\". Your prompt will always be of the form \"P=[], Q=[]\".";

            var payloadData = new
            {
                model = "Mistral-Nemo-12B-Instruct-2407",
                prompt = $"<|begin_of_text|><|start_header_id|>system<|end_header_id|>\n\n{instructions}<|eot_id|><|start_header_id|>user<|end_header_id|>\n\nP=[{statementP}], Q=[{statementQ}]<|eot_id|><|start_header_id|>machine<|end_header_id|>\n\n",
                repetition_penalty = 1.1,
                temperature = 0.7,
                top_p = 0.9,
                top_k = 40,
                max_tokens = 1024,
                stream = true
            };

            string jsonMessage = JsonConvert.SerializeObject(payloadData);
            string output;

            // Make POST call
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, API_URL);
                requestMessage.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
                requestMessage.Headers.Add("Authorization", $"Bearer {API_KEY}");

                HttpResponseMessage response = await client.SendAsync(requestMessage);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    output = await response.Content.ReadAsStringAsync();
                }

                else
                {
                    MessageBox.Show("Δυστυχώς απέτυχε η σύνδεση με το ArliAI. Δοκιμάστε ξανά. (1)", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Split the raw data into individual JSON objects
            var parts = output.Split(new[] { "data: " }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 4)
            {
                Console.WriteLine("Not enough data parts.");
                return false;
            }

            // Parse the first two JSON responses
            var responseP = JObject.Parse(parts[0].Trim());
            var responseQ = JObject.Parse(parts[2].Trim());

            // Extract the text from the 'choices' field
            var responsePText = (string)responseP["choices"][0]["text"];
            var responseQText = (string)responseQ["choices"][0]["text"];

            MessageBox.Show(responsePText);
            MessageBox.Show(responseQText);

            // Determine whether the text is "True" or "False"
            validityP = string.Equals(responsePText.Trim(), "True", StringComparison.OrdinalIgnoreCase);
            validityQ = string.Equals(responseQText.Trim(), "True", StringComparison.OrdinalIgnoreCase);

            return true;
        }

        private async Task<string> ConstructLogic(string statementP, string statementQ)
        {
            byte[] logicInfo = { 0, 0, 0, 0, 0 };

            //Checking validity of statements
            bool success = await CheckValidity(statementP, statementQ);
            if (!success)
            {
                return "";
            }

            //0 for ADD
            //1 for OR
            int logicalConnector = 0;

            if (panelOR.Visible)
            {
                logicalConnector = 1;
            }

            if (lblNOTP.Visible)
            {
                validityP = !validityP;
            }

            if (lblNOTQ.Visible)
            {
                validityQ = !validityQ;
            }

            //Constructing the logic
            logicInfo[0] = Convert.ToByte(validityP);
            logicInfo[1] = Convert.ToByte(validityQ);

            if (logicalConnector == 0)
            {
                if (validityP && validityQ)
                {
                    logicInfo[4] = 1;
                }

                else
                {
                    logicInfo[4] = 0;
                }
            }

            else
            {
                if (validityP || validityQ)
                {
                    if (!validityP)
                    {
                        logicInfo[2] = 1;
                    }

                    if (!validityQ)
                    {
                        logicInfo[3] = 1;
                    }

                    logicInfo[4] = 1;
                }

                else
                {
                    logicInfo[4] = 0;
                }
            }

            return string.Join("", logicInfo);
        }

        // Code for the logical selectors panel

        #region LogicalSelectors
        private void panelAND_Click(object sender, EventArgs e)
        {
            AND_Click();
        }

        private void lblAND_Click(object sender, EventArgs e)
        {
            AND_Click();
        }

        // When 'ADD' selector is clicked, hide it and show 'OR' selector
        private void AND_Click()
        {
            panelAND.Hide();
            panelOR.Show();
        }

        private void lblOR_Click(object sender, EventArgs e)
        {
            OR_Click();
        }

        private void panelOR_Click(object sender, EventArgs e)
        {
            OR_Click();
        }

        // When 'OR' selector is clicked, hide it and show 'ADD' selector
        private void OR_Click()
        {
            panelOR.Hide();
            panelAND.Show();
        }

        private void panelNOTP_Click(object sender, EventArgs e)
        {
            NOTP_Click();
        }

        private void lblNOTP_Click(object sender, EventArgs e)
        {
            NOTP_Click();
        }

        // When 'NOT' selector for statement P is clicked, show the selector, or if already visible hide it.
        // The change is apparent due to the color change
        private void NOTP_Click()
        {
            lblNOTP.Visible = !lblNOTP.Visible;

            if (panelNOTP.BackColor == Color.LawnGreen)
            {
                panelNOTP.BackColor = SystemColors.ControlText;
            }

            else
            {
                panelNOTP.BackColor = Color.LawnGreen;
            }
        }

        private void panelNOTQ_Click(object sender, EventArgs e)
        {
            NOTQ_Click();
        }

        private void lblNOTQ_Click(object sender, EventArgs e)
        {
            NOTQ_Click();
        }

        // When 'NOT' selector for statement Q is clicked, show the selector, or if already visible hide it.
        // The change is apparent due to the color change
        private void NOTQ_Click()
        {
            lblNOTQ.Visible = !lblNOTQ.Visible;

            if (panelNOTQ.BackColor == Color.LawnGreen)
            {
                panelNOTQ.BackColor = SystemColors.ControlText;
            }

            else
            {
                panelNOTQ.BackColor = Color.LawnGreen;
            }
        }
        #endregion
    }
}
