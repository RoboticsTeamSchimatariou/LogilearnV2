namespace Logilearn_v2.Forms
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLoadingIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 170);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Logilearn v2";
            // 
            // picLoadingIcon
            // 
            this.picLoadingIcon.Image = global::Logilearn_v2.Properties.Resources.white_spinner_transparent;
            this.picLoadingIcon.Location = new System.Drawing.Point(306, 244);
            this.picLoadingIcon.Name = "picLoadingIcon";
            this.picLoadingIcon.Size = new System.Drawing.Size(51, 51);
            this.picLoadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadingIcon.TabIndex = 1;
            this.picLoadingIcon.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.ClientSize = new System.Drawing.Size(662, 380);
            this.Controls.Add(this.picLoadingIcon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logilearn v2";
            this.Shown += new System.EventHandler(this.LoadingScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLoadingIcon;
    }
}