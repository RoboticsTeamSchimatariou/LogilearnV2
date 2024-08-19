using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logilearn_v2.Forms
{
    public partial class HomePage : Form
    {
        //Home Page Form: The form where you pick which learning tool to pick
        private string arduinoCOMPort;

        public HomePage(string arduinoCOMPort)
        {
            InitializeComponent();
            this.arduinoCOMPort = arduinoCOMPort;
        }

        //picExit (button for exitting the application): status changes
        #region picExit
        //picExit: mouse is hovering over
        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            //Invert colors and images

            picExit.Image = Properties.Resources.close_inverted;
            picExit.BackColor = Color.White;
        }

        //picExit: mouse is leaving
        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            //Invert colors and images

            picExit.Image = Properties.Resources.close;
            picExit.BackColor = Properties.Settings.Default.main_color;
        }

        //picExit is clicked
        private void PicExit_Click(object sender, EventArgs e)
        {
            //Exit Application

            Application.Exit();
        }
        #endregion

        //Interval Panel (panel that functions as button to open the interval form): status changes
        #region Interval Panel
        //Interval Panel: mouse is hovering over
        private void IntervalPanel_MouseEnter(object sender, EventArgs e)
        {
            //Invert colors and images

            intervalPanel.BackColor = Color.White;

            picInterval.BackColor = Properties.Settings.Default.main_color;
            picInterval.Image = Properties.Resources.interval;

            lblIntervalArticle.ForeColor = Properties.Settings.Default.main_color;
            lblInterval.ForeColor = Properties.Settings.Default.main_color;
        }

        //Interval Panel: mouse is leaving
        private void IntervalPanel_MouseLeave(object sender, EventArgs e)
        {
            //Invert colors and images
            intervalPanel.BackColor = Properties.Settings.Default.main_color;

            picInterval.BackColor = Color.White;
            picInterval.Image = Properties.Resources.interval_inverted;

            lblIntervalArticle.ForeColor = Color.White;
            lblInterval.ForeColor = Color.White;
        }

        //Interval Panel is clicked
        private void IntervalPanel_Click(object sender, EventArgs e)
        {
            IntervalForm intervalForm = new IntervalForm(arduinoCOMPort);
            intervalForm.Shown += IntervalForm_Shown;
            intervalForm.FormClosing += IntervalForm_Closing;
            intervalForm.ShowDialog();
        }

        private void IntervalForm_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the home page again
            Show();
        }

        private void IntervalForm_Shown(object sender, EventArgs e)
        {
            //Hide the Home Page
            Hide();
        }


        #endregion

        //Logic Panel (panel that functions as button to open the logic form): status changes
        #region Logic Panel
        //Logic Panel: mouse is hovering over
        private void LogicPanel_MouseEnter(object sender, EventArgs e)
        {
            //Invert colors and images

            logicPanel.BackColor = Color.White;

            picLogic.BackColor = Properties.Settings.Default.main_color;
            picLogic.Image = Properties.Resources.logic;

            lblLogicArticle.ForeColor = Properties.Settings.Default.main_color;
            lblLogic.ForeColor = Properties.Settings.Default.main_color;
        }

        //Logic Panel: mouse is leaving
        private void LogicPanel_MouseLeave(object sender, EventArgs e)
        {
            //Invert colors and images

            logicPanel.BackColor = Properties.Settings.Default.main_color;

            picLogic.BackColor = Color.White;
            picLogic.Image = Properties.Resources.logic_inverted;

            lblLogicArticle.ForeColor = Color.White;
            lblLogic.ForeColor = Color.White;
        }

        //Logic Panel is clicked
        private void LogicPanel_Click(object sender, EventArgs e)
        {
            LogicForm logicForm = new LogicForm(arduinoCOMPort);
            logicForm.Shown += LogicForm_Shown;
            logicForm.FormClosing += LogicForm_Closing;
            logicForm.ShowDialog();
        }

        private void LogicForm_Closing(object sender, FormClosingEventArgs e)
        {
            //Show the home page again
            Show();
        }

        private void LogicForm_Shown(object sender, EventArgs e)
        {
            //Hide the Home Page
            Hide();
        }
        #endregion
    }
}
