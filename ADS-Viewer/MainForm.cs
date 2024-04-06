using ADS_Viewer.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

namespace ADS_Viewer
{
    public partial class MainForm : Form
    {
        private Utilities.Logger? logger;
        private  System.Windows.Forms.Timer? timer;

        public MainForm()
        {
            InitializeComponent();
            InitializeVariables();
        }

        public void InitializeVariables()
        {
            logger = new Utilities.Logger(500);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            logTextBox.VisibleChanged += VisibleTextChanged;
            processButton.Click += ProcesssButton_Clic;
            timer.Start();
        }

        private string SelectFilePath()
        {
            logger?.AddToLog("Selecting file.");
            string result = string.Empty;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Select file to view ADS";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    result =  openFileDialog.FileName;
                    logger?.AddToLog($"Selected file: {result}");
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = string.Empty;
                logger?.AddToLog(ex.Message);
            }
            return result;
        }

        private void SelectButton_Clic(object sender, EventArgs e)
        {
            string fileName = SelectFilePath();
            if (fileName == string.Empty) { return; }
            fileSelectTextBox.Text = fileName;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            logTextBox.Text = logger?.GetLogAsText(false);
        }

        private void VisibleTextChanged(object? sender, EventArgs e)
        {
            if (logTextBox.Visible)
            {
                logTextBox.SelectionStart = logTextBox.Text.Length;
                logTextBox.ScrollToCaret();
            }
        }

        private void ProcesssButton_Clic(object? sender, EventArgs e)
        {
            ADSUtility.GetADSFrom(fileSelectTextBox.Text, logger);
        }
    }
}
