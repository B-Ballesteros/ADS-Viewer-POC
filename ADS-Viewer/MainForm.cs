using System.Diagnostics;

namespace ADS_Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string SelectFilePath()
        {
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
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = string.Empty;
            }
            return result;
        }

        private void SelectButton_Clic(object sender, EventArgs e)
        {
            string fileName = SelectFilePath();
            if (fileName == string.Empty) { return; }
            fileSelectTextBox.Text = fileName;
        }
    }
}
