using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace YeahLight
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (Program.IsWindows10() != true)
            {
                Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            comboBoxGroupDevices.SelectedIndex = 0;
            panelChosenColor.BackColor = Color.White;
            textBoxBrightness.Text = "1";
            trackBarBrightness.Value = 1;

            string[] lines = File.ReadAllLines("devices.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string addToList = "";
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] != ',')
                        addToList += line[j];
                    else
                    {
                        if (i == 0)
                            SettingsPan.GroupOne.Add(addToList);
                        else if (i == 1)
                            SettingsPan.GroupTwo.Add(addToList);
                        else if (i == 2)
                            SettingsPan.GroupThree.Add(addToList);
                        else if (i == 3)
                            SettingsPan.GroupFour.Add(addToList);
                        else if (i == 4)
                            SettingsPan.GroupFive.Add(addToList);
                        else if (i == 5)
                            SettingsPan.Devices.Add(addToList);
                        addToList = "";
                    }
                }
            }

            if (SettingsPan.Devices.Count != 0)
            {
                for (int i = 0; i < SettingsPan.Devices.Count; i++)
                {
                    comboBoxGroupDevices.Items.Add(SettingsPan.Devices[i]);
                }
            }
        }

        #region ColorPanels

        private void panelChosenColor_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(140, 140, 140), 2))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, panelChosenColor.ClientSize.Width - 2, panelChosenColor.ClientSize.Height - 2));
            }
        }


        private void panelCurrentColor_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(140, 140, 140), 2))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, panelCurrentColor.ClientSize.Width - 2, panelCurrentColor.ClientSize.Height - 2));
            }
        }

        #endregion ColorPanels

        #region Bar

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsPan settingsPanel = new SettingsPan();
            settingsPanel.Show();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(140, 140, 140), 2))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, panelTitleBar.ClientSize.Width - 2, panelTitleBar.ClientSize.Height - 2));
            }
        }

        #endregion Bar

        #region Colors

        private void pictureBoxColorWheel_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBoxColorWheel.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);
            panelChosenColor.BackColor = color;
        }

        private void pictureBoxColorWheel_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBoxColorWheel.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);
            panelCurrentColor.BackColor = color;
        }

        private void pictureBoxColorSpectrum_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBoxColorSpectrum.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);
            panelChosenColor.BackColor = color;
        }

        private void pictureBoxColorSpectrum_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBoxColorSpectrum.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);
            panelCurrentColor.BackColor = color;
        }

        #endregion Colors

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            textBoxBrightness.Text = Convert.ToString(trackBarBrightness.Value);
        }

        private async void buttonApply_Click(object sender, EventArgs e)
        {
            DeviceGroup group = new DeviceGroup();
            if (comboBoxGroupDevices.SelectedIndex == 0)
            {
                for (int i = 0; i < SettingsPan.GroupOne.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupOne[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 1)
            {
                for (int i = 0; i < SettingsPan.GroupTwo.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupTwo[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 2)
            {
                for (int i = 0; i < SettingsPan.GroupThree.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupThree[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 3)
            {
                for (int i = 0; i < SettingsPan.GroupFour.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupFour[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 4)
            {
                for (int i = 0; i < SettingsPan.GroupFive.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupFive[i]);
                    group.Add(device);
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Device device = new Device(comboBoxGroupDevices.SelectedItem.ToString());
                    group.Add(device);
                }
            }
            await group.Connect();
            await group.SetBrightness(trackBarBrightness.Value);
            await group.SetRGBColor(panelChosenColor.BackColor.R, panelChosenColor.BackColor.G, panelChosenColor.BackColor.B);
            group.Disconnect();
        }

        private async void buttonOn_Click(object sender, EventArgs e)
        {
            DeviceGroup group = new DeviceGroup();
            if (comboBoxGroupDevices.SelectedIndex == 0)
            {
                for (int i = 0; i < SettingsPan.GroupOne.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupOne[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 1)
            {
                for (int i = 0; i < SettingsPan.GroupTwo.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupTwo[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 2)
            {
                for (int i = 0; i < SettingsPan.GroupThree.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupThree[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 3)
            {
                for (int i = 0; i < SettingsPan.GroupFour.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupFour[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 4)
            {
                for (int i = 0; i < SettingsPan.GroupFive.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupFive[i]);
                    group.Add(device);
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Device device = new Device(comboBoxGroupDevices.SelectedItem.ToString());
                    group.Add(device);
                }
            }
            await group.Connect();
            await group.TurnOn();
            group.Disconnect();
        }

        private async void buttonOff_Click(object sender, EventArgs e)
        {
            DeviceGroup group = new DeviceGroup();
            if (comboBoxGroupDevices.SelectedIndex == 0)
            {
                for (int i = 0; i < SettingsPan.GroupOne.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupOne[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 1)
            {
                for (int i = 0; i < SettingsPan.GroupTwo.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupTwo[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 2)
            {
                for (int i = 0; i < SettingsPan.GroupThree.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupThree[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 3)
            {
                for (int i = 0; i < SettingsPan.GroupFour.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupFour[i]);
                    group.Add(device);
                }
            }
            else if (comboBoxGroupDevices.SelectedIndex == 4)
            {
                for (int i = 0; i < SettingsPan.GroupFive.Count; i++)
                {
                    Device device = new Device(SettingsPan.GroupFive[i]);
                    group.Add(device);
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    Device device = new Device(comboBoxGroupDevices.SelectedItem.ToString());
                    group.Add(device);
                }
            }
            await group.Connect();
            await group.TurnOff();
            group.Disconnect();
        }
    }
}
