using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Input;
using XvTPilotEditor.Commands;
using XvTPilotEditor.Models;
using static XvTPilotEditor.PilotFileSchema;

namespace XvTPilotEditor.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Page ActivePage { get; set; }
        public Faction ActiveFaction { get; set; }
        public PageViewModel ActivePageViewModel { get; set; }

        public ICommand ChangeActivePageCommand { get; private set; }
        public ICommand LoadPilotFileDataCommand { get; private set; }

        private Dictionary<Page, PageViewModel> pageViewModels;
        private PilotModel pilotModel;

        public MainViewModel()
        {
            pilotModel = new PilotModel();
            pageViewModels = BuildViewModels();

            ChangeActivePageCommand = new DelegateCommand(o => this.UpdateActivePageViewModel());
            LoadPilotFileDataCommand = new DelegateCommand(o => this.LoadFileData());

            // Initial UI state
            ActiveFaction = Faction.Rebel;
            ActivePage = Page.Statistics;
            ActivePageViewModel = pageViewModels[ActivePage];
        }

        private Dictionary<Page, PageViewModel> BuildViewModels()
        {
            Dictionary<Page, PageViewModel> viewModels = new Dictionary<Page, PageViewModel>();

            foreach (var page in Enum.GetValues<Page>())
            {
                switch (page)
                {
                    case Page.Statistics:
                        viewModels.Add(Page.Statistics, new StatisticsPageViewModel(pilotModel));
                        break;
                    case Page.RatingHistory:
                        viewModels.Add(Page.RatingHistory, new RatingHistoryViewModel(pilotModel));
                        break;
                    case Page.MissionAchievements:
                        viewModels.Add(Page.MissionAchievements, new MissionAchievementsViewModel(pilotModel));
                        break;
                }
            }

            return viewModels;
        }

        private void UpdateActivePageViewModel()
        {
            ActivePageViewModel = pageViewModels[ActivePage];
            OnPropertyChanged(nameof(ActivePageViewModel));
        }

        // Convert a byte array to a struct
        private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            finally
            {
                handle.Free();
            }
        }

        private void LoadFileData()
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "XvT pilot files (*.plt)|*.plt|BoP pilot files (*.pl2)|*.pl2";
            openFileDlg.FilterIndex = 2;

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                string Filename = Path.GetFileName(openFileDlg.FileName);
                string Directory = Path.GetFullPath(openFileDlg.FileName);

                try
                {
                    byte[] filebytes = File.ReadAllBytes(openFileDlg.FileName);

                    //if (filebytes.Length < Marshal.SizeOf<PilotFileSchema.PLTFileRecord>())
                    //{
                    //    Console.WriteLine("File is too small for the expected structure.");
                    //    return;
                    //}

                    //PilotFileSchema.PLTFileRecord data = ByteArrayToStructure<PilotFileSchema.PLTFileRecord>(filebytes);

                    if (filebytes.Length < Marshal.SizeOf<PilotFileSchema.PL2FileRecord>())
                    {
                        Console.WriteLine("File is too small for the expected structure.");
                        return;
                    }

                    PilotFileSchema.PL2FileRecord data = ByteArrayToStructure<PilotFileSchema.PL2FileRecord>(filebytes);
                    

                    //char[] name = new char[5];
                    //for (byte i = 0; i < 5; ++i)
                    //{
                    //    name[i] = (char)filebytes[i];
                    //}

                    //string stringName = new string(name);
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
        }
    }
}
