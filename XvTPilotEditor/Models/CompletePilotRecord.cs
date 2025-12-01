using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.Models
{
    public class CompletePilotRecord
    {
        public PltRecord Plt { get; private set; } = new PltRecord();
        public Pl2Record Pl2 { get; private set; } = new Pl2Record();

        public CompletePilotRecord() { }

        public CompletePilotRecord(PltRecord pltRecord, Pl2Record pl2Record)
        {
            Plt = pltRecord;
            Pl2 = pl2Record;
        }

        public CompletePilotRecord(PLTFileRecord pltFile, PL2FileRecord pl2File)
        {
            Plt.FillFromPlt(pltFile);
            Pl2.FillFromPl2(pl2File);
        }
    }
}
