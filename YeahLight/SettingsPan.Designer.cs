namespace YeahLight
{
    partial class SettingsPan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPan));
            buttonClose = new Button();
            buttonMinimize = new Button();
            panelTitleBar = new Panel();
            comboBoxGroupDevices = new ComboBox();
            checkedListBoxDevicesFound = new CheckedListBox();
            label4 = new Label();
            buttonFind = new Button();
            label1 = new Label();
            checkedListBoxGroupDevices = new CheckedListBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.FromArgb(140, 140, 140);
            buttonClose.Location = new Point(497, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(35, 35);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            buttonMinimize.FlatAppearance.BorderSize = 2;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.FromArgb(140, 140, 140);
            buttonMinimize.Location = new Point(463, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(35, 35);
            buttonMinimize.TabIndex = 5;
            buttonMinimize.Text = "-";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(230, 230, 230);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(464, 35);
            panelTitleBar.TabIndex = 7;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // comboBoxGroupDevices
            // 
            comboBoxGroupDevices.BackColor = Color.FromArgb(230, 230, 230);
            comboBoxGroupDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroupDevices.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxGroupDevices.ForeColor = Color.FromArgb(140, 140, 140);
            comboBoxGroupDevices.FormattingEnabled = true;
            comboBoxGroupDevices.Items.AddRange(new object[] { "Group 1", "Group 2", "Group 3", "Group 4", "Group 5", "Devices" });
            comboBoxGroupDevices.Location = new Point(282, 71);
            comboBoxGroupDevices.Name = "comboBoxGroupDevices";
            comboBoxGroupDevices.Size = new Size(236, 27);
            comboBoxGroupDevices.TabIndex = 16;
            // 
            // checkedListBoxDevicesFound
            // 
            checkedListBoxDevicesFound.BackColor = Color.FromArgb(230, 230, 230);
            checkedListBoxDevicesFound.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxDevicesFound.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxDevicesFound.ForeColor = Color.FromArgb(140, 140, 140);
            checkedListBoxDevicesFound.FormattingEnabled = true;
            checkedListBoxDevicesFound.Location = new Point(12, 71);
            checkedListBoxDevicesFound.Name = "checkedListBoxDevicesFound";
            checkedListBoxDevicesFound.Size = new Size(236, 317);
            checkedListBoxDevicesFound.TabIndex = 17;
            checkedListBoxDevicesFound.ItemCheck += checkedListBoxDevicesFound_ItemCheck;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(140, 140, 140);
            label4.Location = new Point(88, 43);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 18;
            label4.Text = "Found:";
            // 
            // buttonFind
            // 
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFind.ForeColor = Color.FromArgb(140, 140, 140);
            buttonFind.Location = new Point(12, 394);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(236, 46);
            buttonFind.TabIndex = 19;
            buttonFind.Text = "FIND";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(140, 140, 140);
            label1.Location = new Point(318, 43);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 20;
            label1.Text = "Groups/Devices:";
            // 
            // checkedListBoxGroupDevices
            // 
            checkedListBoxGroupDevices.BackColor = Color.FromArgb(230, 230, 230);
            checkedListBoxGroupDevices.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxGroupDevices.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxGroupDevices.ForeColor = Color.FromArgb(140, 140, 140);
            checkedListBoxGroupDevices.FormattingEnabled = true;
            checkedListBoxGroupDevices.Location = new Point(282, 109);
            checkedListBoxGroupDevices.Name = "checkedListBoxGroupDevices";
            checkedListBoxGroupDevices.Size = new Size(236, 275);
            checkedListBoxGroupDevices.TabIndex = 21;
            checkedListBoxGroupDevices.ItemCheck += checkedListBoxGroupDevices_ItemCheck;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.FromArgb(140, 140, 140);
            buttonAdd.Location = new Point(282, 394);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(107, 46);
            buttonAdd.TabIndex = 22;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.FromArgb(140, 140, 140);
            buttonRemove.Location = new Point(411, 394);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(107, 46);
            buttonRemove.TabIndex = 23;
            buttonRemove.Text = "-";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // SettingsPan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(532, 450);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(checkedListBoxGroupDevices);
            Controls.Add(label1);
            Controls.Add(buttonFind);
            Controls.Add(label4);
            Controls.Add(checkedListBoxDevicesFound);
            Controls.Add(comboBoxGroupDevices);
            Controls.Add(panelTitleBar);
            Controls.Add(buttonClose);
            Controls.Add(buttonMinimize);
            ForeColor = Color.FromArgb(140, 140, 140);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsPan";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Button buttonMinimize;
        private Panel panelTitleBar;
        private ComboBox comboBoxGroupDevices;
        private CheckedListBox checkedListBoxDevicesFound;
        private Label label4;
        private Button buttonFind;
        private Label label1;
        private CheckedListBox checkedListBoxGroupDevices;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}