using AForge.Video.DirectShow;
using BarcodeReaderSample.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BarcodeReaderSample.Forms
{
    public partial class SettingsForm : Form
    {
        private System.Threading.SemaphoreSlim semaphore = new System.Threading.SemaphoreSlim(1, 1);
        private Properties.Settings settings = Properties.Settings.Default;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private bool hasCameraDevice;

        public SettingsForm()
        {
            InitializeComponent();
            this.ShowIcon = false;
            VersionLabel.Text = string.Format("Version {0}", AssemblyService.AssemblyVersion);
            PopulateSource();
            StartCameraPreview();
            Disposed += SettingsForm_Disposed;
        }

        private void PopulateSource()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CameraComboBox.Items.Clear();
            if (videoDevices.Count == 0)
                throw new ApplicationException();
            else
                hasCameraDevice = true;

            int i = 0;
            foreach (FilterInfo device in videoDevices)
            {
                CameraComboBox.Items.Add(device.Name);
                if (SettingService.CameraDeviceName == device.MonikerString)
                    CameraComboBox.SelectedIndex = i;
                else if (string.IsNullOrEmpty(SettingService.CameraDeviceName))
                {
                    SettingService.CameraDeviceName = device.MonikerString;
                    CameraComboBox.SelectedIndex = i;
                }
                i++;
            }

            if (string.IsNullOrEmpty(SettingService.CSVExportPath))
                SettingService.CSVExportPath = AppDomain.CurrentDomain.BaseDirectory;

            CSVDirectoryTextBox.Text = SettingService.CSVExportPath;
        }

        private void StartCameraPreview()
        {
            if (hasCameraDevice)
            {
                videoDevice = new VideoCaptureDevice(videoDevices[CameraComboBox.SelectedIndex].MonikerString);
                CloseCurrentVideoSource();
                videoSourcePlayer1.VideoSource = videoDevice;
                videoSourcePlayer1.Start();
            }
        }

        private void CameraComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedItem = CameraComboBox.SelectedItem;
            SettingService.CameraDeviceName = selectedItem.ToString();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SettingService.CSVExportPath = folderBrowserDialog1.SelectedPath;
                CSVDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void CloseCurrentVideoSource()
        {
            try
            {
                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();
                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!videoSourcePlayer1.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }
                    if (videoSourcePlayer1.IsRunning)
                    {
                        videoSourcePlayer1.Stop();
                    }
                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("CloseCurrentVideoSource exception:{0}", ex.Message));
            };
        }

        private void SettingsForm_Disposed(object sender, EventArgs e)
        {
        }
    }
}
