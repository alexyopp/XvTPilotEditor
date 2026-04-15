using System.Collections.ObjectModel;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public sealed class PltRecordViewModel : PilotRecordBaseViewModel
    {
        public string LastTeamNumber
        {
            get => PltRecord.lastTeamNumber.ToString();
            set { PltRecord.lastTeamNumber = SetIntProperty(value); }
        }

        private PltRecord PltRecord;

        public PltRecordViewModel(PltRecord initPltRecord) : base(initPltRecord)
        {
            this.PltRecord = initPltRecord;
        }
    }
}
