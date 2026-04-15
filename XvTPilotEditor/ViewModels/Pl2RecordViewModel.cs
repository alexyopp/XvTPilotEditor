using System.Collections.ObjectModel;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public sealed class Pl2RecordViewModel : PilotRecordBaseViewModel
    {
        public string ActiveMissionTeam
        {
            get => Pl2Record.activeMissionTeam.ToString();
            set { Pl2Record.activeMissionTeam = SetIntProperty(value); }
        }

        private Pl2Record Pl2Record;

        public Pl2RecordViewModel(Pl2Record initPl2Record) : base(initPl2Record)
        {
            this.Pl2Record = initPl2Record;
        }
    }
}
