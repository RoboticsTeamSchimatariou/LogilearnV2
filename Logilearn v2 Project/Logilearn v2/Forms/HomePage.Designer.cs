using System.Drawing;

namespace Logilearn_v2.Forms
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.intervalPanel = new System.Windows.Forms.Panel();
            this.lblIntervalArticle = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.picInterval = new System.Windows.Forms.PictureBox();
            this.lblDivider = new System.Windows.Forms.Label();
            this.logicPanel = new System.Windows.Forms.Panel();
            this.lblLogicArticle = new System.Windows.Forms.Label();
            this.lblLogic = new System.Windows.Forms.Label();
            this.picLogic = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.intervalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInterval)).BeginInit();
            this.logicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.lblTitle.Location = new System.Drawing.Point(36, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(419, 100);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Logilearn v2";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(27, 164);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(405, 65);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Μπείτε στον κόσμο...";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intervalPanel
            // 
            this.intervalPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.intervalPanel.BackColor = System.Drawing.Color.Transparent;
            this.intervalPanel.Controls.Add(this.lblIntervalArticle);
            this.intervalPanel.Controls.Add(this.lblInterval);
            this.intervalPanel.Controls.Add(this.picInterval);
            this.intervalPanel.Location = new System.Drawing.Point(196, 269);
            this.intervalPanel.Name = "intervalPanel";
            this.intervalPanel.Size = new System.Drawing.Size(411, 432);
            this.intervalPanel.TabIndex = 4;
            this.intervalPanel.Click += new System.EventHandler(this.IntervalPanel_Click);
            this.intervalPanel.MouseEnter += new System.EventHandler(this.IntervalPanel_MouseEnter);
            this.intervalPanel.MouseLeave += new System.EventHandler(this.IntervalPanel_MouseLeave);
            // 
            // lblIntervalArticle
            // 
            this.lblIntervalArticle.AutoSize = true;
            this.lblIntervalArticle.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalArticle.ForeColor = System.Drawing.Color.White;
            this.lblIntervalArticle.Location = new System.Drawing.Point(177, 307);
            this.lblIntervalArticle.Name = "lblIntervalArticle";
            this.lblIntervalArticle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIntervalArticle.Size = new System.Drawing.Size(58, 37);
            this.lblIntervalArticle.TabIndex = 6;
            this.lblIntervalArticle.Text = "των";
            this.lblIntervalArticle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntervalArticle.Click += new System.EventHandler(this.IntervalPanel_Click);
            this.lblIntervalArticle.MouseEnter += new System.EventHandler(this.IntervalPanel_MouseEnter);
            this.lblIntervalArticle.MouseLeave += new System.EventHandler(this.IntervalPanel_MouseLeave);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.ForeColor = System.Drawing.Color.White;
            this.lblInterval.Location = new System.Drawing.Point(61, 338);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInterval.Size = new System.Drawing.Size(289, 66);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "Διαστημάτων";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInterval.Click += new System.EventHandler(this.IntervalPanel_Click);
            this.lblInterval.MouseEnter += new System.EventHandler(this.IntervalPanel_MouseEnter);
            this.lblInterval.MouseLeave += new System.EventHandler(this.IntervalPanel_MouseLeave);
            // 
            // picInterval
            // 
            this.picInterval.BackColor = System.Drawing.Color.White;
            this.picInterval.Image = global::Logilearn_v2.Properties.Resources.interval_inverted;
            this.picInterval.Location = new System.Drawing.Point(83, 46);
            this.picInterval.Name = "picInterval";
            this.picInterval.Size = new System.Drawing.Size(244, 239);
            this.picInterval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInterval.TabIndex = 0;
            this.picInterval.TabStop = false;
            this.picInterval.Click += new System.EventHandler(this.IntervalPanel_Click);
            this.picInterval.MouseEnter += new System.EventHandler(this.IntervalPanel_MouseEnter);
            this.picInterval.MouseLeave += new System.EventHandler(this.IntervalPanel_MouseLeave);
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDivider.AutoSize = true;
            this.lblDivider.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivider.ForeColor = System.Drawing.Color.White;
            this.lblDivider.Location = new System.Drawing.Point(645, 455);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDivider.Size = new System.Drawing.Size(51, 65);
            this.lblDivider.TabIndex = 5;
            this.lblDivider.Text = "ή";
            this.lblDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logicPanel
            // 
            this.logicPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logicPanel.BackColor = System.Drawing.Color.Transparent;
            this.logicPanel.Controls.Add(this.lblLogicArticle);
            this.logicPanel.Controls.Add(this.lblLogic);
            this.logicPanel.Controls.Add(this.picLogic);
            this.logicPanel.Location = new System.Drawing.Point(731, 269);
            this.logicPanel.Name = "logicPanel";
            this.logicPanel.Size = new System.Drawing.Size(411, 432);
            this.logicPanel.TabIndex = 5;
            this.logicPanel.Click += new System.EventHandler(this.LogicPanel_Click);
            this.logicPanel.MouseEnter += new System.EventHandler(this.LogicPanel_MouseEnter);
            this.logicPanel.MouseLeave += new System.EventHandler(this.LogicPanel_MouseLeave);
            // 
            // lblLogicArticle
            // 
            this.lblLogicArticle.AutoSize = true;
            this.lblLogicArticle.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogicArticle.ForeColor = System.Drawing.Color.White;
            this.lblLogicArticle.Location = new System.Drawing.Point(176, 307);
            this.lblLogicArticle.Name = "lblLogicArticle";
            this.lblLogicArticle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogicArticle.Size = new System.Drawing.Size(57, 37);
            this.lblLogicArticle.TabIndex = 9;
            this.lblLogicArticle.Text = "της";
            this.lblLogicArticle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogicArticle.Click += new System.EventHandler(this.LogicPanel_Click);
            this.lblLogicArticle.MouseEnter += new System.EventHandler(this.LogicPanel_MouseEnter);
            this.lblLogicArticle.MouseLeave += new System.EventHandler(this.LogicPanel_MouseLeave);
            // 
            // lblLogic
            // 
            this.lblLogic.AutoSize = true;
            this.lblLogic.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogic.ForeColor = System.Drawing.Color.White;
            this.lblLogic.Location = new System.Drawing.Point(113, 338);
            this.lblLogic.Name = "lblLogic";
            this.lblLogic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogic.Size = new System.Drawing.Size(185, 66);
            this.lblLogic.TabIndex = 8;
            this.lblLogic.Text = "Λογικής";
            this.lblLogic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogic.Click += new System.EventHandler(this.LogicPanel_Click);
            this.lblLogic.MouseEnter += new System.EventHandler(this.LogicPanel_MouseEnter);
            this.lblLogic.MouseLeave += new System.EventHandler(this.LogicPanel_MouseLeave);
            // 
            // picLogic
            // 
            this.picLogic.BackColor = System.Drawing.Color.White;
            this.picLogic.Image = global::Logilearn_v2.Properties.Resources.logic_inverted;
            this.picLogic.Location = new System.Drawing.Point(83, 46);
            this.picLogic.Name = "picLogic";
            this.picLogic.Size = new System.Drawing.Size(244, 239);
            this.picLogic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogic.TabIndex = 7;
            this.picLogic.TabStop = false;
            this.picLogic.Click += new System.EventHandler(this.LogicPanel_Click);
            this.picLogic.MouseEnter += new System.EventHandler(this.LogicPanel_MouseEnter);
            this.picLogic.MouseLeave += new System.EventHandler(this.LogicPanel_MouseLeave);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Image = global::Logilearn_v2.Properties.Resources.close;
            this.picExit.Location = new System.Drawing.Point(1197, 25);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(113, 100);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.PicExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.PicExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.PicExit_MouseLeave);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.ClientSize = new System.Drawing.Size(1341, 819);
            this.Controls.Add(this.logicPanel);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.intervalPanel);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logilearn v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.intervalPanel.ResumeLayout(false);
            this.intervalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInterval)).EndInit();
            this.logicPanel.ResumeLayout(false);
            this.logicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel intervalPanel;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Panel logicPanel;
        private System.Windows.Forms.PictureBox picInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblIntervalArticle;
        private System.Windows.Forms.Label lblLogic;
        private System.Windows.Forms.PictureBox picLogic;
        private System.Windows.Forms.Label lblLogicArticle;
    }
}