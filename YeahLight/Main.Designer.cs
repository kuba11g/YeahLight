namespace YeahLight
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelTitleBar = new Panel();
            buttonMinimize = new Button();
            buttonClose = new Button();
            buttonSettings = new Button();
            pictureBoxColorWheel = new PictureBox();
            labelWheel = new Label();
            panelChosenColor = new Panel();
            label1 = new Label();
            pictureBoxColorSpectrum = new PictureBox();
            label2 = new Label();
            trackBarBrightness = new TrackBar();
            textBoxBrightness = new TextBox();
            buttonApply = new Button();
            label3 = new Label();
            panelCurrentColor = new Panel();
            comboBoxGroupDevices = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            buttonOn = new Button();
            buttonOff = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorWheel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorSpectrum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(230, 230, 230);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(608, 35);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            buttonMinimize.FlatAppearance.BorderSize = 2;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.FromArgb(140, 140, 140);
            buttonMinimize.Location = new Point(681, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(35, 35);
            buttonMinimize.TabIndex = 3;
            buttonMinimize.Text = "-";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.FromArgb(140, 140, 140);
            buttonClose.Location = new Point(715, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(35, 35);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            buttonSettings.FlatAppearance.BorderSize = 2;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.FromArgb(140, 140, 140);
            buttonSettings.Location = new Point(607, 0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 35);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "SETTINGS";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // pictureBoxColorWheel
            // 
            pictureBoxColorWheel.Cursor = Cursors.Hand;
            pictureBoxColorWheel.Image = (Image)resources.GetObject("pictureBoxColorWheel.Image");
            pictureBoxColorWheel.Location = new Point(429, 70);
            pictureBoxColorWheel.Name = "pictureBoxColorWheel";
            pictureBoxColorWheel.Size = new Size(300, 300);
            pictureBoxColorWheel.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxColorWheel.TabIndex = 4;
            pictureBoxColorWheel.TabStop = false;
            pictureBoxColorWheel.MouseDown += pictureBoxColorWheel_MouseDown;
            pictureBoxColorWheel.MouseMove += pictureBoxColorWheel_MouseMove;
            // 
            // labelWheel
            // 
            labelWheel.AutoSize = true;
            labelWheel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWheel.ForeColor = Color.FromArgb(140, 140, 140);
            labelWheel.Location = new Point(522, 43);
            labelWheel.Name = "labelWheel";
            labelWheel.Size = new Size(122, 22);
            labelWheel.TabIndex = 5;
            labelWheel.Text = "Color Wheel";
            // 
            // panelChosenColor
            // 
            panelChosenColor.Location = new Point(246, 196);
            panelChosenColor.Name = "panelChosenColor";
            panelChosenColor.Size = new Size(150, 60);
            panelChosenColor.TabIndex = 6;
            panelChosenColor.Paint += panelChosenColor_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(140, 140, 140);
            label1.Location = new Point(249, 169);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 7;
            label1.Text = "Chosen Color:";
            // 
            // pictureBoxColorSpectrum
            // 
            pictureBoxColorSpectrum.Cursor = Cursors.Hand;
            pictureBoxColorSpectrum.Image = (Image)resources.GetObject("pictureBoxColorSpectrum.Image");
            pictureBoxColorSpectrum.Location = new Point(429, 408);
            pictureBoxColorSpectrum.Name = "pictureBoxColorSpectrum";
            pictureBoxColorSpectrum.Size = new Size(300, 28);
            pictureBoxColorSpectrum.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxColorSpectrum.TabIndex = 8;
            pictureBoxColorSpectrum.TabStop = false;
            pictureBoxColorSpectrum.MouseDown += pictureBoxColorSpectrum_MouseDown;
            pictureBoxColorSpectrum.MouseMove += pictureBoxColorSpectrum_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(140, 140, 140);
            label2.Location = new Point(506, 381);
            label2.Name = "label2";
            label2.Size = new Size(156, 22);
            label2.TabIndex = 9;
            label2.Text = "Color Spectrum";
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.Location = new Point(144, 118);
            trackBarBrightness.Maximum = 100;
            trackBarBrightness.Minimum = 1;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(174, 45);
            trackBarBrightness.TabIndex = 10;
            trackBarBrightness.TickFrequency = 0;
            trackBarBrightness.TickStyle = TickStyle.None;
            trackBarBrightness.Value = 1;
            trackBarBrightness.Scroll += trackBarBrightness_Scroll;
            // 
            // textBoxBrightness
            // 
            textBoxBrightness.BackColor = Color.FromArgb(230, 230, 230);
            textBoxBrightness.BorderStyle = BorderStyle.None;
            textBoxBrightness.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxBrightness.ForeColor = Color.Black;
            textBoxBrightness.Location = new Point(327, 113);
            textBoxBrightness.Name = "textBoxBrightness";
            textBoxBrightness.ReadOnly = true;
            textBoxBrightness.ScrollBars = ScrollBars.Vertical;
            textBoxBrightness.Size = new Size(67, 28);
            textBoxBrightness.TabIndex = 11;
            textBoxBrightness.Text = "1";
            // 
            // buttonApply
            // 
            buttonApply.FlatStyle = FlatStyle.Flat;
            buttonApply.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonApply.ForeColor = Color.FromArgb(140, 140, 140);
            buttonApply.Location = new Point(23, 279);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(373, 66);
            buttonApply.TabIndex = 12;
            buttonApply.Text = "APPLY";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(140, 140, 140);
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Size = new Size(144, 22);
            label3.TabIndex = 14;
            label3.Text = "Current Color:";
            // 
            // panelCurrentColor
            // 
            panelCurrentColor.Location = new Point(23, 196);
            panelCurrentColor.Name = "panelCurrentColor";
            panelCurrentColor.Size = new Size(150, 60);
            panelCurrentColor.TabIndex = 13;
            panelCurrentColor.Paint += panelCurrentColor_Paint;
            // 
            // comboBoxGroupDevices
            // 
            comboBoxGroupDevices.BackColor = Color.FromArgb(230, 230, 230);
            comboBoxGroupDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroupDevices.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxGroupDevices.ForeColor = Color.FromArgb(140, 140, 140);
            comboBoxGroupDevices.FormattingEnabled = true;
            comboBoxGroupDevices.Items.AddRange(new object[] { "Group 1", "Group 2", "Group 3", "Group 4", "Group 5" });
            comboBoxGroupDevices.Location = new Point(197, 64);
            comboBoxGroupDevices.Name = "comboBoxGroupDevices";
            comboBoxGroupDevices.Size = new Size(199, 27);
            comboBoxGroupDevices.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(140, 140, 140);
            label4.Location = new Point(23, 117);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 16;
            label4.Text = "Brightness:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(140, 140, 140);
            label5.Location = new Point(23, 65);
            label5.Name = "label5";
            label5.Size = new Size(166, 22);
            label5.TabIndex = 17;
            label5.Text = "Groups/Devices:";
            // 
            // buttonOn
            // 
            buttonOn.FlatStyle = FlatStyle.Flat;
            buttonOn.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOn.ForeColor = Color.FromArgb(140, 140, 140);
            buttonOn.Location = new Point(23, 369);
            buttonOn.Name = "buttonOn";
            buttonOn.Size = new Size(172, 58);
            buttonOn.TabIndex = 18;
            buttonOn.Text = "ON";
            buttonOn.UseVisualStyleBackColor = true;
            buttonOn.Click += buttonOn_Click;
            // 
            // buttonOff
            // 
            buttonOff.FlatStyle = FlatStyle.Flat;
            buttonOff.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOff.ForeColor = Color.FromArgb(140, 140, 140);
            buttonOff.Location = new Point(224, 369);
            buttonOff.Name = "buttonOff";
            buttonOff.Size = new Size(172, 58);
            buttonOff.TabIndex = 19;
            buttonOff.Text = "OFF";
            buttonOff.UseVisualStyleBackColor = true;
            buttonOff.Click += buttonOff_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(750, 450);
            Controls.Add(buttonOff);
            Controls.Add(buttonOn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxGroupDevices);
            Controls.Add(label3);
            Controls.Add(panelCurrentColor);
            Controls.Add(buttonApply);
            Controls.Add(textBoxBrightness);
            Controls.Add(trackBarBrightness);
            Controls.Add(label2);
            Controls.Add(pictureBoxColorSpectrum);
            Controls.Add(label1);
            Controls.Add(panelChosenColor);
            Controls.Add(labelWheel);
            Controls.Add(pictureBoxColorWheel);
            Controls.Add(buttonSettings);
            Controls.Add(buttonClose);
            Controls.Add(buttonMinimize);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "YeahLight";
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorWheel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColorSpectrum).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitleBar;
        private Button buttonMinimize;
        private Button buttonClose;
        private Button buttonSettings;
        private PictureBox pictureBoxColorWheel;
        private Label labelWheel;
        private Panel panelChosenColor;
        private Label label1;
        private PictureBox pictureBoxColorSpectrum;
        private Label label2;
        private TrackBar trackBarBrightness;
        private TextBox textBoxBrightness;
        private Button buttonApply;
        private Label label3;
        private Panel panelCurrentColor;
        private ComboBox comboBoxGroupDevices;
        private Label label4;
        private Label label5;
        private Button buttonOn;
        private Button buttonOff;
    }
}