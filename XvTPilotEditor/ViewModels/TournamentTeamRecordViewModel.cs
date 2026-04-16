using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public sealed class TournamentTeamRecordViewModel : PilotDataViewModelBase
    {
        private TournamentTeamRecord TournamentTeamRecord;

        // TODO: What does this mean?
        public string TeamParticipationState
        {
            get => TournamentTeamRecord.TeamParticipationState.ToString();
            set { TournamentTeamRecord.TeamParticipationState = SetIntProperty(value); }
        }

        public string TotalTeamScore
        {
            get => TournamentTeamRecord.TotalTeamScore.ToString();
            set { TournamentTeamRecord.TotalTeamScore = SetIntProperty(value); }
        }

        public string NumberOfMeleeRankingsFirst
        {
            get => TournamentTeamRecord.NumberOfMeleeRankingsFirst.ToString();
            set { TournamentTeamRecord.NumberOfMeleeRankingsFirst = SetIntProperty(value); }
        }

        public string NumberOfMeleeRankingsSecond
        {
            get => TournamentTeamRecord.NumberOfMeleeRankingsSecond.ToString();
            set { TournamentTeamRecord.NumberOfMeleeRankingsSecond = SetIntProperty(value); }
        }

        public string NumberOfMeleeRankingsThird
        {
            get => TournamentTeamRecord.NumberOfMeleeRankingsThird.ToString();
            set { TournamentTeamRecord.NumberOfMeleeRankingsThird = SetIntProperty(value); }
        }

        public TournamentTeamRecordViewModel(TournamentTeamRecord initRecord)
        {
            this.TournamentTeamRecord = initRecord;
        }
    }
}
