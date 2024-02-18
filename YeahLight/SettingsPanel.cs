using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace YeahLight
{
    public partial class SettingsPanel : Form
    {
        DeviceGroup GroupOne = new DeviceGroup();
        DeviceGroup GroupTwo = new DeviceGroup();
        DeviceGroup GroupThree = new DeviceGroup();
        DeviceGroup GroupFour = new DeviceGroup();
        DeviceGroup GroupFive = new DeviceGroup();

        public SettingsPanel()
        {
            InitializeComponent();
        }
    }
}
