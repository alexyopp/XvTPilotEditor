using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using XvTPilotEditor.Commands;
using XvTPilotEditor.Models;
using static XvTPilotEditor.PilotFileSchema;

namespace XvTPilotEditor.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //public Page ActivePage { get; set; }
        //public Faction ActiveFaction { get; set; }
        //public ViewModelBase ActivePageViewModel { get; set; }

        public CombinedPilotRecordPageViewModel ViewModel { get; private set; }

        //public ICommand ChangeActivePageCommand { get; private set; }

        public ICommand OpenCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }
        public ICommand AboutCommand { get; private set; }

        //private Dictionary<Page, ViewModelBase> pageViewModels;
        //private PilotModel pilotModel;
        private PilotRecord pilotRecord = new PilotRecord();

        public MainViewModel()
        {
            //pilotModel = new PilotModel();
            //pageViewModels = BuildViewModels();

            //ChangeActivePageCommand = new DelegateCommand(o => this.UpdateActivePageViewModel());
            OpenCommand = new DelegateCommand(o => LoadFileData());
            ExitCommand = new DelegateCommand(o => ExitApplication());
            AboutCommand = new DelegateCommand(o => ShowAboutMessage());

            // Initial UI state
            //ActiveFaction = Faction.Rebel;
            //ActivePage = Page.CombinedRecord;
            //ActivePageViewModel = pageViewModels[ActivePage];
            ViewModel = new CombinedPilotRecordPageViewModel(pilotRecord);
        }

        //private Dictionary<Page, ViewModelBase> BuildViewModels()
        //{
        //    Dictionary<Page, ViewModelBase> viewModels = new Dictionary<Page, ViewModelBase>();

        //    foreach (var page in Enum.GetValues<Page>())
        //    {
        //        switch (page)
        //        {
        //            case Page.Statistics:
        //                viewModels.Add(Page.Statistics, new StatisticsPageViewModel(pilotModel));
        //                break;
        //            case Page.RatingHistory:
        //                viewModels.Add(Page.RatingHistory, new RatingHistoryViewModel(pilotModel));
        //                break;
        //            case Page.MissionAchievements:
        //                viewModels.Add(Page.MissionAchievements, new MissionAchievementsViewModel(pilotModel));
        //                break;
        //            case Page.CombinedRecord:
        //                viewModels.Add(Page.CombinedRecord, new CombinedPilotRecordPageViewModel(pilotRecord));
        //                break;
        //        }
        //    }

        //    return viewModels;
        //}

        private void UpdateViewModel()
        {
            ViewModel.UpdatePilotRecord(pilotRecord);
        }

        //private void UpdateActivePageViewModel()
        //{
        //    ActivePageViewModel = pageViewModels[ActivePage];
        //    OnPropertyChanged(nameof(ActivePageViewModel));
        //}

        private void LoadFileData()
        {
            PilotFileSchema.PLTFileRecord dataPlt = new PilotFileSchema.PLTFileRecord();
            PilotFileSchema.PL2FileRecord dataPl2 = new PilotFileSchema.PL2FileRecord();

            string PltFileName = string.Empty;
            if (FilePicker("XvT pilot files (*.plt)|*.plt", ref PltFileName) == true)
            {
                ReadFileBytes<PilotFileSchema.PLTFileRecord>(PltFileName, ref dataPlt);
            }

            string Pl2FileName = string.Empty;
            if (FilePicker("BoP pilot files (*.pl2)|*.pl2", ref Pl2FileName) == true)
            {
                ReadFileBytes<PilotFileSchema.PL2FileRecord>(Pl2FileName, ref dataPl2);
            }

            pilotRecord = new PilotRecord(dataPlt, dataPl2);
            UpdateViewModel();
        }

        static private bool? FilePicker(string Filter, ref string FileName)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = Filter;
            openFileDlg.FilterIndex = 1;

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                FileName = openFileDlg.FileName;
            }

            return result;
        }

        static private void ReadFileBytes<T>(string FileName, ref T? data)
        {
            try
            {
                byte[] filebytes = File.ReadAllBytes(FileName);

                GCHandle handle = GCHandle.Alloc(filebytes, GCHandleType.Pinned);
                try
                {
                    data = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
                }
                finally
                {
                    handle.Free();
                }

                if (filebytes.Length < Marshal.SizeOf<T>())
                {
                    Console.WriteLine("File is too small for the expected structure.");
                    return;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
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
