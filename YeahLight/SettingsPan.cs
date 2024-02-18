using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace YeahLight
{
    public partial class SettingsPan : Form
    {
        public static List<string> GroupOne = new List<string>();
        public static List<string> GroupTwo = new List<string>();
        public static List<string> GroupThree = new List<string>();
        public static List<string> GroupFour = new List<string>();
        public static List<string> GroupFive = new List<string>();
        public static List<string> Devices = new List<string>();

        public SettingsPan()
        {
            InitializeComponent();

            if (Program.IsWindows10() != true)
            {
                Region = System.Drawing.Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            comboBoxGroupDevices.SelectedIndex = 0;
            for (int i = 0; i < GroupOne.Count; i++)
                checkedListBoxGroupDevices.Items.Add(GroupOne[i]);
        }

        #region FunctionFind

        private void OnDeviceFound(Device device)
        {
            checkedListBoxDevicesFound.Items.Add(device);
        }

        private async Task GetDevicesAsync()
        {
            var progressReporter = new Progress<Device>(OnDeviceFound);
            await DeviceLocator.DiscoverAsync(progressReporter);
            IEnumerable<Device> discoveredDevices = await DeviceLocator.DiscoverAsync(progressReporter);
        }

        #endregion FunctionFind

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
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(140, 140, 140), 2))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, panelTitleBar.ClientSize.Width - 2, panelTitleBar.ClientSize.Height - 2));
            }
        }

        #endregion Bar

        #region ListBoxes

        string checkedItemDevicesFound;
        private void checkedListBoxDevicesFound_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxDevicesFound.Items.Count; i++)
            {
                if (i != e.Index)
                    checkedListBoxDevicesFound.SetItemChecked(i, false);
            }
            checkedItemDevicesFound = Convert.ToString(checkedListBoxDevicesFound.Items[e.Index]);
        }

        string checkedItemGroupDevices;
        private void checkedListBoxGroupDevices_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxGroupDevices.Items.Count; i++)
            {
                if (i != e.Index)
                    checkedListBoxGroupDevices.SetItemChecked(i, false);
            }
            checkedItemGroupDevices = Convert.ToString(checkedListBoxGroupDevices.Items[e.Index]);
        }

        #endregion ListBoxes

        #region Buttons

        private async void buttonFind_Click(object sender, EventArgs e)
        {
            checkedListBoxDevicesFound.Items.Clear();
            await GetDevicesAsync();
        }

        static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("devices.txt");
            if (checkedListBoxDevicesFound.CheckedItems.Count != 0)
            {
                checkedListBoxGroupDevices.Items.Clear();

                string line, device = Regex.Replace(checkedItemDevicesFound, "[^0-9.:]", "").Replace(":55443", "");
                if (comboBoxGroupDevices.SelectedIndex == 0)
                {
                    GroupOne.Add(device);
                    for (int i = 0; i < GroupOne.Count; i++)
                        checkedListBoxGroupDevices.Items.Add(GroupOne[i]);
                    LineChanger(lines[0] + device + ",", "devices.txt", 0);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 1)
                {
                    GroupTwo.Add(device);
                    for (int i = 0; i < GroupTwo.Count; i++)
                        checkedListBoxGroupDevices.Items.Add(GroupTwo[i]);
                    LineChanger(lines[1] + device + ",", "devices.txt", 1);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 2)
                {
                    GroupThree.Add(device);
                    for (int i = 0; i < GroupThree.Count; i++)
                        checkedListBoxGroupDevices.Items.Add(GroupThree[i]);
                    LineChanger(lines[2] + device + ",", "devices.txt", 2);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 3)
                {
                    GroupFour.Add(device);
                    for (int i = 0; i < GroupFour.Count; i++)
                        checkedListBoxGroupDevices.Items.Add(GroupFour[i]);
                    LineChanger(lines[3] + device + ",", "devices.txt", 3);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 4)
                {
                    GroupFive.Add(device);
                    for (int i = 0; i < GroupFive.Count; i++)
                        checkedListBoxGroupDevices.Items.Add(GroupFive[i]);
                    LineChanger(lines[4] + device + ",", "devices.txt", 4);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 5)
                {
                    Devices.Add(device);
                    for (int i = 0; i < Devices.Count; i++)
                        checkedListBoxGroupDevices.Items.Add(Devices[i]);
                    LineChanger(lines[5] + device + ",", "devices.txt", 5);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (checkedListBoxGroupDevices.CheckedItems.Count != 0)
            {
                checkedListBoxGroupDevices.Items.Clear();

                string line = "";
                if (comboBoxGroupDevices.SelectedIndex == 0)
                {
                    GroupOne.Remove(checkedItemGroupDevices);
                    for (int i = 0; i < GroupOne.Count; i++)
                    {
                        line += GroupOne[i] + ",";
                        checkedListBoxGroupDevices.Items.Add(GroupOne[i]);
                    }
                    LineChanger(line, "devices.txt", 0);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 1)
                {
                    GroupTwo.Remove(checkedItemGroupDevices);
                    for (int i = 0; i < GroupTwo.Count; i++)
                    {
                        line += GroupTwo[i] + ",";
                        checkedListBoxGroupDevices.Items.Add(GroupTwo[i]);
                    }
                    LineChanger(line, "devices.txt", 1);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 2)
                {
                    GroupThree.Remove(checkedItemGroupDevices);
                    for (int i = 0; i < GroupThree.Count; i++)
                    {
                        line += GroupThree[i] + ",";
                        checkedListBoxGroupDevices.Items.Add(GroupThree[i]);
                    }
                    LineChanger(line, "devices.txt", 2);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 3)
                {
                    GroupFour.Remove(checkedItemGroupDevices);
                    for (int i = 0; i < GroupFour.Count; i++)
                    {
                        line += GroupFour[i] + ",";
                        checkedListBoxGroupDevices.Items.Add(GroupFour[i]);
                    }
                    LineChanger(line, "devices.txt", 3);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 4)
                {
                    GroupFive.Remove(checkedItemGroupDevices);
                    for (int i = 0; i < GroupFive.Count; i++)
                    {
                        line += GroupFive[i] + ",";
                        checkedListBoxGroupDevices.Items.Add(GroupFive[i]);
                    }
                    LineChanger(line, "devices.txt", 4);
                }
                else if (comboBoxGroupDevices.SelectedIndex == 5)
                {
                    Devices.Remove(checkedItemGroupDevices);
                    for (int i = 0; i < Devices.Count; i++)
                    {
                        line += Devices[i] + ",";
                        checkedListBoxGroupDevices.Items.Add(Devices[i]);
                    }
                    LineChanger(line, "devices.txt", 5);
                }
            }
        }

        #endregion Buttons
    }
}
