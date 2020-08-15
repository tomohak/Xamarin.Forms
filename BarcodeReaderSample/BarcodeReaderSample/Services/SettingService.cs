namespace BarcodeReaderSample.Services
{
    public class SettingService
    {
        public static string CameraDeviceName
        {
            get
            {
                return Properties.Settings.Default.CameraDeviceName;
            }
            set
            {
                if (Properties.Settings.Default.CameraDeviceName != value)
                    Properties.Settings.Default.CameraDeviceName = value;
            }
        }

        public static string CSVExportPath
        {
            get
            {
                return Properties.Settings.Default.CSVExportPath;
            }
            set
            {
                if (Properties.Settings.Default.CSVExportPath != value)
                    Properties.Settings.Default.CSVExportPath = value;
            }
        }
    }
}
