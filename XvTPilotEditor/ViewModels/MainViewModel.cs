using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using XvTPilotEditor.Commands;
using XvTPilotEditor.Models;
using XvTPilotEditor.Views;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //public ICommand ChangeActivePageCommand { get; private set; }
        public ICommand OpenCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }
        public ICommand AboutCommand { get; private set; }

        public PilotViewModel? ActivePilotVM { get; private set; }

        public MainViewModel()
        {
            AutoLoadFileData();     // TODO: Remove this line for production release; only for testing.

            OpenCommand = new DelegateCommand(o => CreateNewPilot());       // From the user's perspective, we're opening pilot files, but from our perpsective, we're creating a Pilot Entity that contains the data of a plt and/or pl2 file
            SaveCommand = new DelegateCommand(o => SavePilot());
            ExitCommand = new DelegateCommand(o => ExitApplication());
            AboutCommand = new DelegateCommand(o => ShowAboutMessage());
        }

        private void UpdateActivePilot(PilotViewModel newPilotVM)
        {
            // TODO: Validate the new pilot VM before setting it as active. If invalid, show an error message and do not update the active pilot.
            ActivePilotVM = newPilotVM;
            OnPropertyChanged(nameof(ActivePilotVM));
        }

        // TODO: Remove after testing is complete
        private void AutoLoadFileData()
        {
            PilotViewModel pilotVM = new PilotViewModel(
                                            "AutoLoadPilot",
                                            "C:\\Dev\\XvTPilotEditor\\XvTPilotEditor\\Assets\\LandoRasputi0.plt",
                                            "C:\\Dev\\XvTPilotEditor\\XvTPilotEditor\\Assets\\LandoRasputi0.pl2");
            UpdateActivePilot(pilotVM);
        }

        private void CreateNewPilot()
        {
            NewPilotDialogue dialogue = new NewPilotDialogue();
            bool? result = dialogue.ShowDialog();

            if (result == true)
            {
                PilotViewModel pilotVM = new PilotViewModel(dialogue.PilotName, dialogue.PltFilePath, dialogue.Pl2FilePath);
                UpdateActivePilot(pilotVM);
            }
        }

        private void SavePilot()
        {
            ActivePilotVM?.WriteFileData();
        }

        private void ExitApplication()
        {
            Application.Current.Shutdown();
        }

        private void ShowAboutMessage()
        {
            MessageBox.Show("Thanks to TRA for always providing me with a reason to play XvT after all these years.\n\nSpecial Thanks to TRA_Scorer for his support\n\nVery Special Thanks to RandomStarfighter for providing the plt/pl2 file schemas.\n\nReleased under the GNU General Public License\n© 2025", "About");
        }
    }
}
