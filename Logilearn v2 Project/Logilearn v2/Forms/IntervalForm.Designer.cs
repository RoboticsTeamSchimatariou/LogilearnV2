namespace Logilearn_v2.Forms
{
    partial class IntervalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntervalForm));
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.intervalConfigPanel = new System.Windows.Forms.Panel();
            this.P3_P4 = new System.Windows.Forms.PictureBox();
            this.P5_P6 = new System.Windows.Forms.PictureBox();
            this.P3_P5 = new System.Windows.Forms.PictureBox();
            this.P2_P5 = new System.Windows.Forms.PictureBox();
            this.P1_P3 = new System.Windows.Forms.PictureBox();
            this.btnGenerateInterval = new System.Windows.Forms.Button();
            this.rightBoundConfigPanel = new System.Windows.Forms.Panel();
            this.rbRightBoundInfinite = new System.Windows.Forms.RadioButton();
            this.rbRightBoundClosed = new System.Windows.Forms.RadioButton();
            this.rbRightBoundOpen = new System.Windows.Forms.RadioButton();
            this.lblRightBoundTypeHeader = new System.Windows.Forms.Label();
            this.lblRightBoundInfo = new System.Windows.Forms.Label();
            this.txtRightBound = new System.Windows.Forms.TextBox();
            this.lblRightBoundHeader = new System.Windows.Forms.Label();
            this.leftBoundConfigPanel = new System.Windows.Forms.Panel();
            this.rbLeftBoundInfinite = new System.Windows.Forms.RadioButton();
            this.rbLeftBoundClosed = new System.Windows.Forms.RadioButton();
            this.rbLeftBoundOpen = new System.Windows.Forms.RadioButton();
            this.lblLeftBoundTypeHeader = new System.Windows.Forms.Label();
            this.lblLeftBoundInfo = new System.Windows.Forms.Label();
            this.txtLeftBound = new System.Windows.Forms.TextBox();
            this.lblLeftBoundHeader = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.lblIntervalTypeHeader = new System.Windows.Forms.Label();
            this.lblIntervalType = new System.Windows.Forms.Label();
            this.lblNegativeInfinity = new System.Windows.Forms.Label();
            this.lblPositiveInfinity = new System.Windows.Forms.Label();
            this.picIntervalIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.intervalConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P3_P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5_P6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3_P5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2_P5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1_P3)).BeginInit();
            this.rightBoundConfigPanel.SuspendLayout();
            this.leftBoundConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntervalIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picReturn
            // 
            this.picReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReturn.Image = global::Logilearn_v2.Properties.Resources._return;
            this.picReturn.Location = new System.Drawing.Point(1197, 25);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(113, 100);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReturn.TabIndex = 4;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.PicReturn_Click);
            this.picReturn.MouseEnter += new System.EventHandler(this.PicReturn_MouseEnter);
            this.picReturn.MouseLeave += new System.EventHandler(this.PicReturn_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.lblTitle.Location = new System.Drawing.Point(137, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(463, 100);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Διαστήματα";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intervalConfigPanel
            // 
            this.intervalConfigPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.intervalConfigPanel.Controls.Add(this.lblPositiveInfinity);
            this.intervalConfigPanel.Controls.Add(this.lblNegativeInfinity);
            this.intervalConfigPanel.Controls.Add(this.lblIntervalType);
            this.intervalConfigPanel.Controls.Add(this.btnGenerateInterval);
            this.intervalConfigPanel.Controls.Add(this.lblIntervalTypeHeader);
            this.intervalConfigPanel.Controls.Add(this.P3_P4);
            this.intervalConfigPanel.Controls.Add(this.P5_P6);
            this.intervalConfigPanel.Controls.Add(this.P3_P5);
            this.intervalConfigPanel.Controls.Add(this.P2_P5);
            this.intervalConfigPanel.Controls.Add(this.P1_P3);
            this.intervalConfigPanel.Controls.Add(this.rightBoundConfigPanel);
            this.intervalConfigPanel.Controls.Add(this.leftBoundConfigPanel);
            this.intervalConfigPanel.Controls.Add(this.P2);
            this.intervalConfigPanel.Controls.Add(this.P1);
            this.intervalConfigPanel.Location = new System.Drawing.Point(298, 148);
            this.intervalConfigPanel.Name = "intervalConfigPanel";
            this.intervalConfigPanel.Size = new System.Drawing.Size(851, 679);
            this.intervalConfigPanel.TabIndex = 5;
            // 
            // P3_P4
            // 
            this.P3_P4.BackColor = System.Drawing.Color.White;
            this.P3_P4.Location = new System.Drawing.Point(73, 573);
            this.P3_P4.Name = "P3_P4";
            this.P3_P4.Size = new System.Drawing.Size(300, 21);
            this.P3_P4.TabIndex = 20;
            this.P3_P4.TabStop = false;
            this.P3_P4.Visible = false;
            // 
            // P5_P6
            // 
            this.P5_P6.BackColor = System.Drawing.Color.White;
            this.P5_P6.Location = new System.Drawing.Point(463, 573);
            this.P5_P6.Name = "P5_P6";
            this.P5_P6.Size = new System.Drawing.Size(307, 21);
            this.P5_P6.TabIndex = 19;
            this.P5_P6.TabStop = false;
            this.P5_P6.Visible = false;
            // 
            // P3_P5
            // 
            this.P3_P5.BackColor = System.Drawing.Color.White;
            this.P3_P5.Location = new System.Drawing.Point(348, 573);
            this.P3_P5.Name = "P3_P5";
            this.P3_P5.Size = new System.Drawing.Size(151, 21);
            this.P3_P5.TabIndex = 18;
            this.P3_P5.TabStop = false;
            this.P3_P5.Visible = false;
            // 
            // P2_P5
            // 
            this.P2_P5.BackColor = System.Drawing.Color.White;
            this.P2_P5.Location = new System.Drawing.Point(481, 447);
            this.P2_P5.Name = "P2_P5";
            this.P2_P5.Size = new System.Drawing.Size(21, 147);
            this.P2_P5.TabIndex = 17;
            this.P2_P5.TabStop = false;
            this.P2_P5.Visible = false;
            // 
            // P1_P3
            // 
            this.P1_P3.BackColor = System.Drawing.Color.White;
            this.P1_P3.Location = new System.Drawing.Point(336, 447);
            this.P1_P3.Name = "P1_P3";
            this.P1_P3.Size = new System.Drawing.Size(21, 147);
            this.P1_P3.TabIndex = 6;
            this.P1_P3.TabStop = false;
            this.P1_P3.Visible = false;
            // 
            // btnGenerateInterval
            // 
            this.btnGenerateInterval.FlatAppearance.BorderSize = 2;
            this.btnGenerateInterval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(34)))));
            this.btnGenerateInterval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(34)))));
            this.btnGenerateInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateInterval.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInterval.Location = new System.Drawing.Point(662, 317);
            this.btnGenerateInterval.Name = "btnGenerateInterval";
            this.btnGenerateInterval.Size = new System.Drawing.Size(166, 46);
            this.btnGenerateInterval.TabIndex = 16;
            this.btnGenerateInterval.Text = "Αναπαράσταση";
            this.btnGenerateInterval.UseVisualStyleBackColor = true;
            this.btnGenerateInterval.Click += new System.EventHandler(this.btnGenerateInterval_Click);
            // 
            // rightBoundConfigPanel
            // 
            this.rightBoundConfigPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightBoundConfigPanel.Controls.Add(this.rbRightBoundInfinite);
            this.rightBoundConfigPanel.Controls.Add(this.rbRightBoundClosed);
            this.rightBoundConfigPanel.Controls.Add(this.rbRightBoundOpen);
            this.rightBoundConfigPanel.Controls.Add(this.lblRightBoundTypeHeader);
            this.rightBoundConfigPanel.Controls.Add(this.lblRightBoundInfo);
            this.rightBoundConfigPanel.Controls.Add(this.txtRightBound);
            this.rightBoundConfigPanel.Controls.Add(this.lblRightBoundHeader);
            this.rightBoundConfigPanel.Location = new System.Drawing.Point(434, 24);
            this.rightBoundConfigPanel.Name = "rightBoundConfigPanel";
            this.rightBoundConfigPanel.Size = new System.Drawing.Size(394, 274);
            this.rightBoundConfigPanel.TabIndex = 15;
            // 
            // rbRightBoundInfinite
            // 
            this.rbRightBoundInfinite.AutoSize = true;
            this.rbRightBoundInfinite.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRightBoundInfinite.Location = new System.Drawing.Point(23, 223);
            this.rbRightBoundInfinite.Name = "rbRightBoundInfinite";
            this.rbRightBoundInfinite.Size = new System.Drawing.Size(238, 33);
            this.rbRightBoundInfinite.TabIndex = 14;
            this.rbRightBoundInfinite.Text = "Αρνητικό Άπειρο (ανοιχτό)";
            this.rbRightBoundInfinite.UseVisualStyleBackColor = true;
            // 
            // rbRightBoundClosed
            // 
            this.rbRightBoundClosed.AutoSize = true;
            this.rbRightBoundClosed.Checked = true;
            this.rbRightBoundClosed.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRightBoundClosed.Location = new System.Drawing.Point(23, 184);
            this.rbRightBoundClosed.Name = "rbRightBoundClosed";
            this.rbRightBoundClosed.Size = new System.Drawing.Size(94, 33);
            this.rbRightBoundClosed.TabIndex = 13;
            this.rbRightBoundClosed.TabStop = true;
            this.rbRightBoundClosed.Text = "Κλειστό";
            this.rbRightBoundClosed.UseVisualStyleBackColor = true;
            // 
            // rbRightBoundOpen
            // 
            this.rbRightBoundOpen.AutoSize = true;
            this.rbRightBoundOpen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRightBoundOpen.Location = new System.Drawing.Point(23, 145);
            this.rbRightBoundOpen.Name = "rbRightBoundOpen";
            this.rbRightBoundOpen.Size = new System.Drawing.Size(94, 33);
            this.rbRightBoundOpen.TabIndex = 12;
            this.rbRightBoundOpen.Text = "Ανοιχτό";
            this.rbRightBoundOpen.UseVisualStyleBackColor = true;
            // 
            // lblRightBoundTypeHeader
            // 
            this.lblRightBoundTypeHeader.AutoSize = true;
            this.lblRightBoundTypeHeader.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightBoundTypeHeader.ForeColor = System.Drawing.Color.White;
            this.lblRightBoundTypeHeader.Location = new System.Drawing.Point(18, 113);
            this.lblRightBoundTypeHeader.Name = "lblRightBoundTypeHeader";
            this.lblRightBoundTypeHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRightBoundTypeHeader.Size = new System.Drawing.Size(145, 29);
            this.lblRightBoundTypeHeader.TabIndex = 11;
            this.lblRightBoundTypeHeader.Text = "Το άκρο θα είναι:";
            this.lblRightBoundTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightBoundInfo
            // 
            this.lblRightBoundInfo.AutoSize = true;
            this.lblRightBoundInfo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightBoundInfo.ForeColor = System.Drawing.Color.White;
            this.lblRightBoundInfo.Location = new System.Drawing.Point(210, 55);
            this.lblRightBoundInfo.Name = "lblRightBoundInfo";
            this.lblRightBoundInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRightBoundInfo.Size = new System.Drawing.Size(179, 29);
            this.lblRightBoundInfo.TabIndex = 10;
            this.lblRightBoundInfo.Text = "∈ ℤ (ακέραιοι αριθμοί)";
            this.lblRightBoundInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRightBound
            // 
            this.txtRightBound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRightBound.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightBound.Location = new System.Drawing.Point(23, 54);
            this.txtRightBound.Name = "txtRightBound";
            this.txtRightBound.Size = new System.Drawing.Size(181, 30);
            this.txtRightBound.TabIndex = 9;
            this.txtRightBound.Text = "5";
            this.txtRightBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRightBoundHeader
            // 
            this.lblRightBoundHeader.AutoSize = true;
            this.lblRightBoundHeader.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightBoundHeader.ForeColor = System.Drawing.Color.White;
            this.lblRightBoundHeader.Location = new System.Drawing.Point(16, 14);
            this.lblRightBoundHeader.Name = "lblRightBoundHeader";
            this.lblRightBoundHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRightBoundHeader.Size = new System.Drawing.Size(155, 37);
            this.lblRightBoundHeader.TabIndex = 8;
            this.lblRightBoundHeader.Text = "Δεξιό άκρο:";
            this.lblRightBoundHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftBoundConfigPanel
            // 
            this.leftBoundConfigPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftBoundConfigPanel.Controls.Add(this.rbLeftBoundInfinite);
            this.leftBoundConfigPanel.Controls.Add(this.rbLeftBoundClosed);
            this.leftBoundConfigPanel.Controls.Add(this.rbLeftBoundOpen);
            this.leftBoundConfigPanel.Controls.Add(this.lblLeftBoundTypeHeader);
            this.leftBoundConfigPanel.Controls.Add(this.lblLeftBoundInfo);
            this.leftBoundConfigPanel.Controls.Add(this.txtLeftBound);
            this.leftBoundConfigPanel.Controls.Add(this.lblLeftBoundHeader);
            this.leftBoundConfigPanel.Location = new System.Drawing.Point(26, 24);
            this.leftBoundConfigPanel.Name = "leftBoundConfigPanel";
            this.leftBoundConfigPanel.Size = new System.Drawing.Size(394, 274);
            this.leftBoundConfigPanel.TabIndex = 6;
            // 
            // rbLeftBoundInfinite
            // 
            this.rbLeftBoundInfinite.AutoSize = true;
            this.rbLeftBoundInfinite.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeftBoundInfinite.Location = new System.Drawing.Point(23, 223);
            this.rbLeftBoundInfinite.Name = "rbLeftBoundInfinite";
            this.rbLeftBoundInfinite.Size = new System.Drawing.Size(238, 33);
            this.rbLeftBoundInfinite.TabIndex = 14;
            this.rbLeftBoundInfinite.Text = "Αρνητικό Άπειρο (ανοιχτό)";
            this.rbLeftBoundInfinite.UseVisualStyleBackColor = true;
            // 
            // rbLeftBoundClosed
            // 
            this.rbLeftBoundClosed.AutoSize = true;
            this.rbLeftBoundClosed.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeftBoundClosed.Location = new System.Drawing.Point(23, 184);
            this.rbLeftBoundClosed.Name = "rbLeftBoundClosed";
            this.rbLeftBoundClosed.Size = new System.Drawing.Size(94, 33);
            this.rbLeftBoundClosed.TabIndex = 13;
            this.rbLeftBoundClosed.Text = "Κλειστό";
            this.rbLeftBoundClosed.UseVisualStyleBackColor = true;
            // 
            // rbLeftBoundOpen
            // 
            this.rbLeftBoundOpen.AutoSize = true;
            this.rbLeftBoundOpen.Checked = true;
            this.rbLeftBoundOpen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeftBoundOpen.Location = new System.Drawing.Point(23, 145);
            this.rbLeftBoundOpen.Name = "rbLeftBoundOpen";
            this.rbLeftBoundOpen.Size = new System.Drawing.Size(94, 33);
            this.rbLeftBoundOpen.TabIndex = 12;
            this.rbLeftBoundOpen.TabStop = true;
            this.rbLeftBoundOpen.Text = "Ανοιχτό";
            this.rbLeftBoundOpen.UseVisualStyleBackColor = true;
            // 
            // lblLeftBoundTypeHeader
            // 
            this.lblLeftBoundTypeHeader.AutoSize = true;
            this.lblLeftBoundTypeHeader.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftBoundTypeHeader.ForeColor = System.Drawing.Color.White;
            this.lblLeftBoundTypeHeader.Location = new System.Drawing.Point(18, 113);
            this.lblLeftBoundTypeHeader.Name = "lblLeftBoundTypeHeader";
            this.lblLeftBoundTypeHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLeftBoundTypeHeader.Size = new System.Drawing.Size(145, 29);
            this.lblLeftBoundTypeHeader.TabIndex = 11;
            this.lblLeftBoundTypeHeader.Text = "Το άκρο θα είναι:";
            this.lblLeftBoundTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftBoundInfo
            // 
            this.lblLeftBoundInfo.AutoSize = true;
            this.lblLeftBoundInfo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftBoundInfo.ForeColor = System.Drawing.Color.White;
            this.lblLeftBoundInfo.Location = new System.Drawing.Point(210, 55);
            this.lblLeftBoundInfo.Name = "lblLeftBoundInfo";
            this.lblLeftBoundInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLeftBoundInfo.Size = new System.Drawing.Size(179, 29);
            this.lblLeftBoundInfo.TabIndex = 10;
            this.lblLeftBoundInfo.Text = "∈ ℤ (ακέραιοι αριθμοί)";
            this.lblLeftBoundInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLeftBound
            // 
            this.txtLeftBound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeftBound.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftBound.Location = new System.Drawing.Point(23, 54);
            this.txtLeftBound.Name = "txtLeftBound";
            this.txtLeftBound.Size = new System.Drawing.Size(181, 30);
            this.txtLeftBound.TabIndex = 9;
            this.txtLeftBound.Text = "2";
            this.txtLeftBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLeftBoundHeader
            // 
            this.lblLeftBoundHeader.AutoSize = true;
            this.lblLeftBoundHeader.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftBoundHeader.ForeColor = System.Drawing.Color.White;
            this.lblLeftBoundHeader.Location = new System.Drawing.Point(16, 14);
            this.lblLeftBoundHeader.Name = "lblLeftBoundHeader";
            this.lblLeftBoundHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLeftBoundHeader.Size = new System.Drawing.Size(200, 37);
            this.lblLeftBoundHeader.TabIndex = 8;
            this.lblLeftBoundHeader.Text = "Αριστερό άκρο:";
            this.lblLeftBoundHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.Crimson;
            this.P2.Location = new System.Drawing.Point(471, 437);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(42, 40);
            this.P2.TabIndex = 22;
            this.P2.TabStop = false;
            this.P2.Visible = false;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.Crimson;
            this.P1.Location = new System.Drawing.Point(326, 437);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(42, 40);
            this.P1.TabIndex = 21;
            this.P1.TabStop = false;
            this.P1.Visible = false;
            // 
            // lblIntervalTypeHeader
            // 
            this.lblIntervalTypeHeader.AutoSize = true;
            this.lblIntervalTypeHeader.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalTypeHeader.ForeColor = System.Drawing.Color.White;
            this.lblIntervalTypeHeader.Location = new System.Drawing.Point(21, 317);
            this.lblIntervalTypeHeader.Name = "lblIntervalTypeHeader";
            this.lblIntervalTypeHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIntervalTypeHeader.Size = new System.Drawing.Size(85, 29);
            this.lblIntervalTypeHeader.TabIndex = 15;
            this.lblIntervalTypeHeader.Text = "Έχουμε:";
            this.lblIntervalTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntervalTypeHeader.Visible = false;
            // 
            // lblIntervalType
            // 
            this.lblIntervalType.AutoSize = true;
            this.lblIntervalType.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalType.ForeColor = System.Drawing.Color.White;
            this.lblIntervalType.Location = new System.Drawing.Point(18, 355);
            this.lblIntervalType.Name = "lblIntervalType";
            this.lblIntervalType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIntervalType.Size = new System.Drawing.Size(79, 43);
            this.lblIntervalType.TabIndex = 23;
            this.lblIntervalType.Text = "(a, b)";
            this.lblIntervalType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntervalType.Visible = false;
            // 
            // lblNegativeInfinity
            // 
            this.lblNegativeInfinity.AutoSize = true;
            this.lblNegativeInfinity.BackColor = System.Drawing.Color.Transparent;
            this.lblNegativeInfinity.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegativeInfinity.ForeColor = System.Drawing.Color.White;
            this.lblNegativeInfinity.Location = new System.Drawing.Point(69, 522);
            this.lblNegativeInfinity.Name = "lblNegativeInfinity";
            this.lblNegativeInfinity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNegativeInfinity.Size = new System.Drawing.Size(57, 48);
            this.lblNegativeInfinity.TabIndex = 24;
            this.lblNegativeInfinity.Text = "-∞";
            this.lblNegativeInfinity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNegativeInfinity.Visible = false;
            // 
            // lblPositiveInfinity
            // 
            this.lblPositiveInfinity.AutoSize = true;
            this.lblPositiveInfinity.BackColor = System.Drawing.Color.Transparent;
            this.lblPositiveInfinity.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositiveInfinity.ForeColor = System.Drawing.Color.White;
            this.lblPositiveInfinity.Location = new System.Drawing.Point(716, 522);
            this.lblPositiveInfinity.Name = "lblPositiveInfinity";
            this.lblPositiveInfinity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPositiveInfinity.Size = new System.Drawing.Size(65, 48);
            this.lblPositiveInfinity.TabIndex = 25;
            this.lblPositiveInfinity.Text = "+∞";
            this.lblPositiveInfinity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPositiveInfinity.Visible = false;
            // 
            // picIntervalIcon
            // 
            this.picIntervalIcon.BackColor = System.Drawing.Color.White;
            this.picIntervalIcon.Image = global::Logilearn_v2.Properties.Resources.interval_inverted;
            this.picIntervalIcon.Location = new System.Drawing.Point(12, 25);
            this.picIntervalIcon.Name = "picIntervalIcon";
            this.picIntervalIcon.Size = new System.Drawing.Size(119, 100);
            this.picIntervalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIntervalIcon.TabIndex = 6;
            this.picIntervalIcon.TabStop = false;
            // 
            // IntervalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Logilearn_v2.Properties.Settings.Default.main_color;
            this.ClientSize = new System.Drawing.Size(1341, 839);
            this.Controls.Add(this.picIntervalIcon);
            this.Controls.Add(this.intervalConfigPanel);
            this.Controls.Add(this.picReturn);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntervalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logilearn v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.intervalConfigPanel.ResumeLayout(false);
            this.intervalConfigPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P3_P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5_P6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3_P5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2_P5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1_P3)).EndInit();
            this.rightBoundConfigPanel.ResumeLayout(false);
            this.rightBoundConfigPanel.PerformLayout();
            this.leftBoundConfigPanel.ResumeLayout(false);
            this.leftBoundConfigPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntervalIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel intervalConfigPanel;
        private System.Windows.Forms.Panel leftBoundConfigPanel;
        private System.Windows.Forms.Label lblLeftBoundTypeHeader;
        private System.Windows.Forms.Label lblLeftBoundInfo;
        private System.Windows.Forms.TextBox txtLeftBound;
        private System.Windows.Forms.Label lblLeftBoundHeader;
        private System.Windows.Forms.RadioButton rbLeftBoundClosed;
        private System.Windows.Forms.RadioButton rbLeftBoundOpen;
        private System.Windows.Forms.RadioButton rbLeftBoundInfinite;
        private System.Windows.Forms.Panel rightBoundConfigPanel;
        private System.Windows.Forms.RadioButton rbRightBoundInfinite;
        private System.Windows.Forms.RadioButton rbRightBoundClosed;
        private System.Windows.Forms.RadioButton rbRightBoundOpen;
        private System.Windows.Forms.Label lblRightBoundTypeHeader;
        private System.Windows.Forms.Label lblRightBoundInfo;
        private System.Windows.Forms.TextBox txtRightBound;
        private System.Windows.Forms.Label lblRightBoundHeader;
        private System.Windows.Forms.Button btnGenerateInterval;
        private System.Windows.Forms.PictureBox P3_P4;
        private System.Windows.Forms.PictureBox P5_P6;
        private System.Windows.Forms.PictureBox P3_P5;
        private System.Windows.Forms.PictureBox P2_P5;
        private System.Windows.Forms.PictureBox P1_P3;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.Label lblIntervalTypeHeader;
        private System.Windows.Forms.Label lblIntervalType;
        private System.Windows.Forms.Label lblNegativeInfinity;
        private System.Windows.Forms.Label lblPositiveInfinity;
        private System.Windows.Forms.PictureBox picIntervalIcon;
    }
}