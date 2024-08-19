namespace Logilearn_v2.Forms
{
    partial class LogicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogicForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatementOne = new System.Windows.Forms.Label();
            this.lblStatementTwo = new System.Windows.Forms.Label();
            this.txtStatementP = new System.Windows.Forms.TextBox();
            this.txtStatementQ = new System.Windows.Forms.TextBox();
            this.btnShowLogic = new System.Windows.Forms.Button();
            this.picLogicIcon = new System.Windows.Forms.PictureBox();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.lblLogicSentenceHeader = new System.Windows.Forms.Label();
            this.panelLogicalSelectors = new System.Windows.Forms.Panel();
            this.panelQ = new System.Windows.Forms.Panel();
            this.lblQ = new System.Windows.Forms.Label();
            this.panelNOTQ = new System.Windows.Forms.Panel();
            this.lblNOTQ = new System.Windows.Forms.Label();
            this.panelOR = new System.Windows.Forms.Panel();
            this.lblOR = new System.Windows.Forms.Label();
            this.panelAND = new System.Windows.Forms.Panel();
            this.lblAND = new System.Windows.Forms.Label();
            this.panelP = new System.Windows.Forms.Panel();
            this.lblP = new System.Windows.Forms.Label();
            this.panelNOTP = new System.Windows.Forms.Panel();
            this.lblNOTP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogicIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.panelLogicalSelectors.SuspendLayout();
            this.panelQ.SuspendLayout();
            this.panelNOTQ.SuspendLayout();
            this.panelOR.SuspendLayout();
            this.panelAND.SuspendLayout();
            this.panelP.SuspendLayout();
            this.panelNOTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.lblTitle.Location = new System.Drawing.Point(137, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(305, 100);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Λογική";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatementOne
            // 
            this.lblStatementOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatementOne.AutoSize = true;
            this.lblStatementOne.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatementOne.ForeColor = System.Drawing.Color.White;
            this.lblStatementOne.Location = new System.Drawing.Point(231, 165);
            this.lblStatementOne.Name = "lblStatementOne";
            this.lblStatementOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatementOne.Size = new System.Drawing.Size(206, 37);
            this.lblStatementOne.TabIndex = 10;
            this.lblStatementOne.Text = "Ισχυρισμός 1 (P):";
            this.lblStatementOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatementTwo
            // 
            this.lblStatementTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatementTwo.AutoSize = true;
            this.lblStatementTwo.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatementTwo.ForeColor = System.Drawing.Color.White;
            this.lblStatementTwo.Location = new System.Drawing.Point(231, 300);
            this.lblStatementTwo.Name = "lblStatementTwo";
            this.lblStatementTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatementTwo.Size = new System.Drawing.Size(209, 37);
            this.lblStatementTwo.TabIndex = 11;
            this.lblStatementTwo.Text = "Ισχυρισμός 2 (Q):";
            this.lblStatementTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatementP
            // 
            this.txtStatementP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatementP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatementP.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatementP.Location = new System.Drawing.Point(238, 205);
            this.txtStatementP.Multiline = true;
            this.txtStatementP.Name = "txtStatementP";
            this.txtStatementP.Size = new System.Drawing.Size(871, 76);
            this.txtStatementP.TabIndex = 12;
            this.txtStatementP.Text = "Ο ήλιος είναι το κέντρο του σύμπαντος.";
            // 
            // txtStatementQ
            // 
            this.txtStatementQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatementQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatementQ.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatementQ.Location = new System.Drawing.Point(238, 340);
            this.txtStatementQ.Multiline = true;
            this.txtStatementQ.Name = "txtStatementQ";
            this.txtStatementQ.Size = new System.Drawing.Size(871, 76);
            this.txtStatementQ.TabIndex = 13;
            this.txtStatementQ.Text = "Το σύμπαν είναι χαζό.";
            // 
            // btnShowLogic
            // 
            this.btnShowLogic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowLogic.FlatAppearance.BorderSize = 2;
            this.btnShowLogic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(34)))));
            this.btnShowLogic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(34)))));
            this.btnShowLogic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowLogic.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLogic.ForeColor = System.Drawing.Color.White;
            this.btnShowLogic.Location = new System.Drawing.Point(947, 584);
            this.btnShowLogic.Name = "btnShowLogic";
            this.btnShowLogic.Size = new System.Drawing.Size(162, 46);
            this.btnShowLogic.TabIndex = 17;
            this.btnShowLogic.Text = "Αναπαράσταση";
            this.btnShowLogic.UseVisualStyleBackColor = true;
            this.btnShowLogic.Click += new System.EventHandler(this.btnCheckLogic_ClickAsync);
            // 
            // picLogicIcon
            // 
            this.picLogicIcon.BackColor = System.Drawing.Color.White;
            this.picLogicIcon.Image = global::Logilearn_v2.Properties.Resources.logic_inverted;
            this.picLogicIcon.Location = new System.Drawing.Point(12, 25);
            this.picLogicIcon.Name = "picLogicIcon";
            this.picLogicIcon.Size = new System.Drawing.Size(119, 100);
            this.picLogicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogicIcon.TabIndex = 9;
            this.picLogicIcon.TabStop = false;
            // 
            // picReturn
            // 
            this.picReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReturn.Image = global::Logilearn_v2.Properties.Resources._return;
            this.picReturn.Location = new System.Drawing.Point(1197, 25);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(113, 100);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReturn.TabIndex = 8;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.PicReturn_Click);
            this.picReturn.MouseEnter += new System.EventHandler(this.PicReturn_MouseEnter);
            this.picReturn.MouseLeave += new System.EventHandler(this.PicReturn_MouseLeave);
            // 
            // lblLogicSentenceHeader
            // 
            this.lblLogicSentenceHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogicSentenceHeader.AutoSize = true;
            this.lblLogicSentenceHeader.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogicSentenceHeader.ForeColor = System.Drawing.Color.White;
            this.lblLogicSentenceHeader.Location = new System.Drawing.Point(487, 444);
            this.lblLogicSentenceHeader.Name = "lblLogicSentenceHeader";
            this.lblLogicSentenceHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogicSentenceHeader.Size = new System.Drawing.Size(367, 29);
            this.lblLogicSentenceHeader.TabIndex = 18;
            this.lblLogicSentenceHeader.Text = "Για να περάσει το τρένο πρέπει να ισχύει:";
            this.lblLogicSentenceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogicalSelectors
            // 
            this.panelLogicalSelectors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLogicalSelectors.Controls.Add(this.panelQ);
            this.panelLogicalSelectors.Controls.Add(this.panelNOTQ);
            this.panelLogicalSelectors.Controls.Add(this.panelOR);
            this.panelLogicalSelectors.Controls.Add(this.panelAND);
            this.panelLogicalSelectors.Controls.Add(this.panelP);
            this.panelLogicalSelectors.Controls.Add(this.panelNOTP);
            this.panelLogicalSelectors.Location = new System.Drawing.Point(460, 492);
            this.panelLogicalSelectors.Name = "panelLogicalSelectors";
            this.panelLogicalSelectors.Size = new System.Drawing.Size(420, 58);
            this.panelLogicalSelectors.TabIndex = 22;
            // 
            // panelQ
            // 
            this.panelQ.BackColor = System.Drawing.Color.DarkCyan;
            this.panelQ.Controls.Add(this.lblQ);
            this.panelQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelQ.Location = new System.Drawing.Point(420, 0);
            this.panelQ.Name = "panelQ";
            this.panelQ.Size = new System.Drawing.Size(84, 58);
            this.panelQ.TabIndex = 5;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(26, 14);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(33, 37);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Q";
            // 
            // panelNOTQ
            // 
            this.panelNOTQ.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelNOTQ.Controls.Add(this.lblNOTQ);
            this.panelNOTQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNOTQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNOTQ.Location = new System.Drawing.Point(336, 0);
            this.panelNOTQ.Name = "panelNOTQ";
            this.panelNOTQ.Size = new System.Drawing.Size(84, 58);
            this.panelNOTQ.TabIndex = 1;
            this.panelNOTQ.Click += new System.EventHandler(this.panelNOTQ_Click);
            // 
            // lblNOTQ
            // 
            this.lblNOTQ.AutoSize = true;
            this.lblNOTQ.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOTQ.Location = new System.Drawing.Point(11, 14);
            this.lblNOTQ.Name = "lblNOTQ";
            this.lblNOTQ.Size = new System.Drawing.Size(62, 37);
            this.lblNOTQ.TabIndex = 0;
            this.lblNOTQ.Text = "NOT";
            this.lblNOTQ.Click += new System.EventHandler(this.lblNOTQ_Click);
            // 
            // panelOR
            // 
            this.panelOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelOR.Controls.Add(this.lblOR);
            this.panelOR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOR.Location = new System.Drawing.Point(252, 0);
            this.panelOR.Name = "panelOR";
            this.panelOR.Size = new System.Drawing.Size(84, 58);
            this.panelOR.TabIndex = 4;
            this.panelOR.Visible = false;
            this.panelOR.Click += new System.EventHandler(this.panelOR_Click);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.Location = new System.Drawing.Point(19, 14);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(47, 37);
            this.lblOR.TabIndex = 0;
            this.lblOR.Text = "OR";
            this.lblOR.Click += new System.EventHandler(this.lblOR_Click);
            // 
            // panelAND
            // 
            this.panelAND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelAND.Controls.Add(this.lblAND);
            this.panelAND.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAND.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAND.Location = new System.Drawing.Point(168, 0);
            this.panelAND.Name = "panelAND";
            this.panelAND.Size = new System.Drawing.Size(84, 58);
            this.panelAND.TabIndex = 3;
            this.panelAND.Click += new System.EventHandler(this.panelAND_Click);
            // 
            // lblAND
            // 
            this.lblAND.AutoSize = true;
            this.lblAND.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAND.Location = new System.Drawing.Point(11, 14);
            this.lblAND.Name = "lblAND";
            this.lblAND.Size = new System.Drawing.Size(64, 37);
            this.lblAND.TabIndex = 0;
            this.lblAND.Text = "AND";
            this.lblAND.Click += new System.EventHandler(this.lblAND_Click);
            // 
            // panelP
            // 
            this.panelP.BackColor = System.Drawing.Color.SeaGreen;
            this.panelP.Controls.Add(this.lblP);
            this.panelP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelP.Location = new System.Drawing.Point(84, 0);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(84, 58);
            this.panelP.TabIndex = 2;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(27, 14);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(30, 37);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "P";
            // 
            // panelNOTP
            // 
            this.panelNOTP.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelNOTP.Controls.Add(this.lblNOTP);
            this.panelNOTP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNOTP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelNOTP.Location = new System.Drawing.Point(0, 0);
            this.panelNOTP.Name = "panelNOTP";
            this.panelNOTP.Size = new System.Drawing.Size(84, 58);
            this.panelNOTP.TabIndex = 0;
            this.panelNOTP.Click += new System.EventHandler(this.panelNOTP_Click);
            // 
            // lblNOTP
            // 
            this.lblNOTP.AutoSize = true;
            this.lblNOTP.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOTP.Location = new System.Drawing.Point(11, 14);
            this.lblNOTP.Name = "lblNOTP";
            this.lblNOTP.Size = new System.Drawing.Size(62, 37);
            this.lblNOTP.TabIndex = 0;
            this.lblNOTP.Text = "NOT";
            this.lblNOTP.Click += new System.EventHandler(this.lblNOTP_Click);
            // 
            // LogicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.ClientSize = new System.Drawing.Size(1341, 839);
            this.Controls.Add(this.panelLogicalSelectors);
            this.Controls.Add(this.lblLogicSentenceHeader);
            this.Controls.Add(this.btnShowLogic);
            this.Controls.Add(this.txtStatementQ);
            this.Controls.Add(this.txtStatementP);
            this.Controls.Add(this.lblStatementTwo);
            this.Controls.Add(this.lblStatementOne);
            this.Controls.Add(this.picLogicIcon);
            this.Controls.Add(this.picReturn);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logilearn v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogicIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.panelLogicalSelectors.ResumeLayout(false);
            this.panelQ.ResumeLayout(false);
            this.panelQ.PerformLayout();
            this.panelNOTQ.ResumeLayout(false);
            this.panelNOTQ.PerformLayout();
            this.panelOR.ResumeLayout(false);
            this.panelOR.PerformLayout();
            this.panelAND.ResumeLayout(false);
            this.panelAND.PerformLayout();
            this.panelP.ResumeLayout(false);
            this.panelP.PerformLayout();
            this.panelNOTP.ResumeLayout(false);
            this.panelNOTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogicIcon;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatementOne;
        private System.Windows.Forms.Label lblStatementTwo;
        private System.Windows.Forms.TextBox txtStatementP;
        private System.Windows.Forms.TextBox txtStatementQ;
        private System.Windows.Forms.Button btnShowLogic;
        private System.Windows.Forms.Label lblLogicSentenceHeader;
        private System.Windows.Forms.Panel panelLogicalSelectors;
        private System.Windows.Forms.Panel panelNOTP;
        private System.Windows.Forms.Label lblNOTP;
        private System.Windows.Forms.Panel panelNOTQ;
        private System.Windows.Forms.Label lblNOTQ;
        private System.Windows.Forms.Panel panelAND;
        private System.Windows.Forms.Label lblAND;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Panel panelQ;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Panel panelOR;
        private System.Windows.Forms.Label lblOR;
    }
}