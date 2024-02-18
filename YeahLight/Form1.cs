using YeelightAPI;

namespace YeahLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDevicesAsync();
        }

        // Define the callback for the progress reporter
        private void OnDeviceFound(Device device)
        {
            MessageBox.Show(Convert.ToString(device));
            device.SetRGBColor(0, 0, 0);
        }

        private async Task GetDevicesAsync()
        {
            var progressReporter = new Progress<Device>(OnDeviceFound);
            await DeviceLocator.DiscoverAsync(progressReporter);
            IEnumerable<Device> discoveredDevices = await DeviceLocator.DiscoverAsync(progressReporter);
        }
    }
}