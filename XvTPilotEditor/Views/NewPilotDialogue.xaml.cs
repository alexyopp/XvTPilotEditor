using System.IO;
using System.Windows;
using System.Windows.Input;
using XvTPilotEditor.Commands;

namespace XvTPilotEditor.Views
{
    /// <summary>
    /// Interaction logic for NewPilotDialogue.xaml
    /// </summary>
    public partial class NewPilotDialogue : Window
    {
        // Exposed to caller after ShowDialog()
        public string PltFilePath { get; private set; } = string.Empty;
        public string Pl2FilePath { get; private set; } = string.Empty;
        public string PilotName { get; private set; } = string.Empty;

        // Commands bound to buttons in the dialogue
        public ICommand OpenPltCommand { get; private set; }
        public ICommand OpenPl2Command { get; private set; }
        public ICommand CreatePilotCommand { get; private set; }

        public NewPilotDialogue()
        {
            InitializeComponent();

            OpenPltCommand = new DelegateCommand(o => SelectPltFile());
            OpenPl2Command = new DelegateCommand(o => SelectPl2File());
            CreatePilotCommand = new DelegateCommand(o => CreatePilot());

            DataContext = this;
        }

        private void SelectPltFile()
        {
            string PltFileName = string.Empty;
            if (SelectFile("XvT pilot files (*.plt)|*.plt", ref PltFileName) == true)
            {
                PltFilePathTextBox.Text = PltFileName;
                PilotNameTextBox.Text = Path.GetFileNameWithoutExtension(PltFileName);
            }
        }

        private void SelectPl2File()
        {
            string Pl2FileName = string.Empty;
            if (SelectFile("BoP pilot files (*.pl2)|*.pl2", ref Pl2FileName) == true)
            {
                Pl2FilePathTextBox.Text = Pl2FileName;
                PilotNameTextBox.Text = Path.GetFileNameWithoutExtension(Pl2FileName);
            }
        }

        static private bool? SelectFile(string Filter, ref string FileName)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = Filter;
            openFileDlg.FilterIndex = 1;

            bool? result = openFileDlg.ShowDialog();

            if (result == true)
            {
                FileName = openFileDlg.FileName;
            }

            return result;
        }

        private void CreatePilot()
        {
            // Update public properties with current dialogue values
            PltFilePath = PltFilePathTextBox.Text ?? string.Empty;
            Pl2FilePath = Pl2FilePathTextBox.Text ?? string.Empty;
            PilotName = PilotNameTextBox.Text ?? string.Empty;

            // Validate that at least one file is selected and that a pilot name is provided before closing dialogue with "OK" result
            bool AtLeastOneFilename = !string.IsNullOrWhiteSpace(PltFilePath) || !string.IsNullOrWhiteSpace(Pl2FilePath);
            bool NonEmptyPilotName = !string.IsNullOrWhiteSpace(PilotName);

            if (!AtLeastOneFilename)
            {
                MessageBox.Show("Please select at least one pilot file.", "Missing file");
            }

            if (!NonEmptyPilotName)
            {
                MessageBox.Show("Please provide an identifier for your Pilot.", "Missing Pilot Name");
            }

            // If both conditions are satisfied, close dialogue with "OK" result; otherwise, remain open for user to correct issues
            if (AtLeastOneFilename && NonEmptyPilotName)
            {
                DialogResult = true;
                Close();
            }
        }
    }
}
