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

        private void ReadFileBytes<T>(string FileName, ref T? data)
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
    }
}
