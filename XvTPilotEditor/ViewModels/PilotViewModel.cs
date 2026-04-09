using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.ViewModels
{
    class PilotViewModel
    {
        public string Name { get; private set; }        = string.Empty;
        public string PltFileName { get; private set; } = string.Empty;
        public string Pl2FileName { get; private set; } = string.Empty;

        private PltRecord PltRecord = new PltRecord();
        private Pl2Record Pl2Record = new Pl2Record();

        public PilotViewModel(string name, string pltFileName, string pl2FileName)
        {
            UpdateName(name);
            UpdatePltFileName(pltFileName);
            UpdatePl2FileName(pl2FileName);
        }

        public void UpdateName(string newName)
        {
            // TODO: Add validation for the new name if necessary (e.g., check for null or empty string, conflict another PilotVM, etc.).
            this.Name = newName;
        }

        public void UpdatePltFileName(string newPltFileName)
        {
            // TODO: Add validation for the new filename
            this.PltFileName = newPltFileName;

            PLTFileRecord dataPlt = new PLTFileRecord();
            ReadFileBytes(newPltFileName, ref dataPlt);
            this.PltRecord.FillFromPlt(dataPlt);
        }

        public void UpdatePl2FileName(string newPl2FileName)
        {
            // TODO: Add validation for the new filename
            this.Pl2FileName = newPl2FileName;

            PL2FileRecord dataPl2 = new PL2FileRecord();
            ReadFileBytes(newPl2FileName, ref dataPl2);
            this.Pl2Record.FillFromPl2(dataPl2);
        }

        // TODO: Repalce with writing to the actual files
        public void WriteFileData()
        {
            WriteFileBytes("Test.plt", PltRecord.ToPltFileRecord());
            WriteFileBytes("Test.pl2", Pl2Record.ToPl2FileRecord());
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

        static private void WriteFileBytes<T>(string FileName, T data)
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
    }
}
