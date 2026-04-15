using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public sealed class TeamResultRecordViewModel : PilotDataViewModelBase
    {
        public string TotalMissionScore
        {
            get => TeamResultRecord.TotalMissionScore.ToString();
            set { TeamResultRecord.TotalMissionScore = SetIntProperty(value); }
        }

        public string IsMissionComplete
        {
            get => TeamResultRecord.IsMissionComplete.ToString();
            set { TeamResultRecord.IsMissionComplete = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string Unknown0x8
        {
            get => TeamResultRecord.Unknown0x8.ToString();
            set { TeamResultRecord.Unknown0x8 = SetIntProperty(value); }
        }

        public string TimeMissionComplete
        {
            get => TeamResultRecord.TimeMissionComplete.ToString();
            set { TeamResultRecord.TimeMissionComplete = SetIntProperty(value); }
        }

        public string FullKills
        {
            get => TeamResultRecord.FullKills.ToString();
            set { TeamResultRecord.FullKills = SetIntProperty(value); }
        }

        public string SharedKills
        {
            get => TeamResultRecord.SharedKills.ToString();
            set { TeamResultRecord.SharedKills = SetIntProperty(value); }
        }

        public string Losses
        {
            get => TeamResultRecord.Losses.ToString();
            set { TeamResultRecord.Losses = SetIntProperty(value); }
        }

        private TeamResultRecord TeamResultRecord;

        public TeamResultRecordViewModel(TeamResultRecord initRecord)
        {
            this.TeamResultRecord = initRecord;
        }
    }
}
