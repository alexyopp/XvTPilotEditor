using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using XvTPilotEditor.Commands;
using XvTPilotEditor.Models;
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

        private CompletePilotRecord pilotRecord = new CompletePilotRecord();

        public MainViewModel()
        {
            AutoLoadFileData();     // TODO: Remove this line for production release; only for testing.

            //ChangeActivePageCommand = new DelegateCommand(o => this.UpdateActivePageViewModel());
            OpenCommand = new DelegateCommand(o => LoadFileData());
            SaveCommand = new DelegateCommand(o => WriteFileData());
            ExitCommand = new DelegateCommand(o => ExitApplication());
            AboutCommand = new DelegateCommand(o => ShowAboutMessage());
        }

        private void AutoLoadFileData()
        {
            PLTFileRecord dataPlt = new PLTFileRecord();
            string PltFileName = "C:\\Dev\\XvTPilotEditor\\XvTPilotEditor\\Assets\\LandoRasputi0.plt";
            ReadFileBytes(PltFileName, ref dataPlt);

            PL2FileRecord dataPl2 = new PL2FileRecord();
            string Pl2FileName = "C:\\Dev\\XvTPilotEditor\\XvTPilotEditor\\Assets\\LandoRasputi0.pl2";
            ReadFileBytes(Pl2FileName, ref dataPl2);

            pilotRecord.Plt.FillFromPlt(dataPlt);
            pilotRecord.Pl2.FillFromPl2(dataPl2);
        }

        private void LoadFileData()
        {
            PLTFileRecord dataPlt = new PLTFileRecord();
            PL2FileRecord dataPl2 = new PL2FileRecord();

            string PltFileName = string.Empty;
            if (FilePicker("XvT pilot files (*.plt)|*.plt", ref PltFileName) == true)
            {
                ReadFileBytes(PltFileName, ref dataPlt);
            }

            string Pl2FileName = string.Empty;
            if (FilePicker("BoP pilot files (*.pl2)|*.pl2", ref Pl2FileName) == true)
            {
                ReadFileBytes(Pl2FileName, ref dataPl2);
            }

            pilotRecord.Plt.FillFromPlt(dataPlt);
            pilotRecord.Pl2.FillFromPl2(dataPl2);
        }

        static private bool? FilePicker(string Filter, ref string FileName)
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

        private void WriteFileData()
        {
            WriteFileBytes("Test.plt", pilotRecord.Plt.ToPltFileRecord());
            WriteFileBytes("Test.pl2", pilotRecord.Pl2.ToPl2FileRecord());
        }

        private void WriteFileBytes<T>(string FileName, T data)
        {
            if (data == null)
            {
                Console.WriteLine("Error: Data to write is null.");
                return;
            }

            try
            {
                int size = Marshal.SizeOf<T>();
                byte[] filebytes = new byte[size];
                GCHandle handle = GCHandle.Alloc(filebytes, GCHandleType.Pinned);
                try
                {
                    Marshal.StructureToPtr(data, handle.AddrOfPinnedObject(), false);
                }
                finally
                {
                    handle.Free();
                }
                File.WriteAllBytes(FileName, filebytes);
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
