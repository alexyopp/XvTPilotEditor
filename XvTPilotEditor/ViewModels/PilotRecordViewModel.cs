using System;
using System.Reflection;
using System.Windows;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class PilotRecordViewModel : ViewModelBase
    {
        public string PltPilotName
        {
            get => pilotRecord.Plt.PilotName;
            set
            {
                if (value.Length > Constants.PILOT_NAME_MAX_LENGTH)
                {
                    MessageBox.Show("Pilot name must be no more than " + Constants.PILOT_NAME_MAX_LENGTH + " characters long.", "Invalid Pilot Name");
                    return;
                }

                pilotRecord.Plt.PilotName = value;
                OnPropertyChanged(nameof(PltPilotName));
            }
        }
        public string Pl2PilotName
        {
            get => pilotRecord.Pl2.PilotName;
            set
            {
                if (value.Length > Constants.PILOT_NAME_MAX_LENGTH)
                {
                    MessageBox.Show("Pilot name must be no more than " + Constants.PILOT_NAME_MAX_LENGTH + " characters long.", "Invalid Pilot Name");
                    return;
                }

                pilotRecord.Pl2.PilotName = value;
                OnPropertyChanged(nameof(Pl2PilotName));
            }
        }

        public string PltTotalScore
        {
            get => pilotRecord.Plt.TotalScore.ToString();
            set
            {
                int totalScore;
                if (int.TryParse(value, out totalScore))
                {
                    pilotRecord.Plt.TotalScore = totalScore;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Pl2TotalScore
        {
            get => pilotRecord.Pl2.TotalScore.ToString();
            set
            {
                int totalScore;
                if (int.TryParse(value, out totalScore))
                {
                    pilotRecord.Pl2.TotalScore = totalScore;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public uint PltPlayerID { get; private set; }
        public uint Pl2PlayerID { get; private set; }

        public int PltContinuedOrReflownMission { get; private set; }
        public int Pl2ContinuedOrReflownMission { get; private set; }

        public int PltIsHosting { get; private set; }
        public int Pl2IsHosting { get; private set; }

        public int PltNumHumanPlayersInMission { get; private set; }
        public int Pl2NumHumanPlayersInMission { get; private set; }

        public int PltFrontFlyMode { get; private set; }
        public int Pl2FrontFlyMode { get; private set; }

        public int[] PltUnknown0x26 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x26 { get; private set; } = Array.Empty<int>();

        public int[] PltUnknown0x166 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x166 { get; private set; } = Array.Empty<int>();

        public int[] PltUnknown0x186 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x186 { get; private set; } = Array.Empty<int>();

        //...

        public int PltPromoPoints { get; private set; }
        public int Pl2PromoPoints { get; private set; }

        public int PltWorsePromoPoints { get; private set; }
        public int Pl2WorsePromoPoints { get; private set; }

        public int PltRankAdjustmentApplied { get; private set; }
        public int Pl2RankAdjustmentApplied { get; private set; }

        public int PltPercentToNextRank { get; private set; }
        public int Pl2PercentToNextRank { get; private set; }

        public MissionCategoryRecord PltTotalCategoryScore { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalCategoryScore { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltNumFlownNonSeries { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2NumFlownNonSeries { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltNumFlownSeries { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2NumFlownSeries { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalKills { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalKills { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltFriendlyKills { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2FriendlyKills { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecordByPlayerRating PltTotalFullKillsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();
        public MissionCategoryRecordByPlayerRating Pl2TotalFullKillsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByPlayerRating PltTotalSharedKillsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();
        public MissionCategoryRecordByPlayerRating Pl2TotalSharedKillsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByPlayerRating PltTotalAssistsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();
        public MissionCategoryRecordByPlayerRating Pl2TotalAssistsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByAIRating PltTotalFullKillsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();
        public MissionCategoryRecordByAIRating Pl2TotalFullKillsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        public MissionCategoryRecordByAIRating PltTotalSharedKillsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();
        public MissionCategoryRecordByAIRating Pl2TotalSharedKillsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        public MissionCategoryRecordByAIRating PltTotalAssistsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();
        public MissionCategoryRecordByAIRating Pl2TotalAssistsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        public MissionCategoryRecord PltTotalHiddenCargoFound { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalHiddenCargoFound { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLaserHit { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLaserHit { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLaserFired { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLaserFired { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalWarheadHit { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalWarheadHit { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalWarheadFired { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalWarheadFired { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalCraftLosses { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalCraftLosses { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLossesFromCollisions { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLossesFromCollisions { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLossesFromStarships { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLossesFromStarships { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord PltTotalLossesFromMines { get; private set; } = new MissionCategoryRecord();
        public MissionCategoryRecord Pl2TotalLossesFromMines { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecordByPlayerRating PltTotalLossesFromPlayerRank { get; private set; } = new MissionCategoryRecordByPlayerRating();
        public MissionCategoryRecordByPlayerRating Pl2TotalLossesFromPlayerRank { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByAIRating PltTotalLossesFromAIRank { get; private set; } = new MissionCategoryRecordByAIRating();
        public MissionCategoryRecordByAIRating Pl2TotalLossesFromAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        //...

        public uint PltCurrentRank { get; private set; }
        public uint Pl2CurrentRank { get; private set; }

        public int PltTotalCountMissionsFlown { get; private set; }
        public int Pl2TotalCountMissionsFlown { get; private set; }

        public int[] PltRankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();
        public int[] Pl2RankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();

        public string PltRankString { get; private set; } = string.Empty;
        public string Pl2RankString { get; private set; } = string.Empty;

        public int PltDebriefMissionScore { get; private set; }
        public int Pl2DebriefMissionScore { get; private set; }

        public int[] PltDebriefFullKillsOnPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsOnPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsOnPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsOnPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefFullKillsOnFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsOnFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsOnFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsOnFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefFullKillsByPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsByPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsByPlayer { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsByPlayer { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefFullKillsByFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefFullKillsByFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefSharedKillsByFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefSharedKillsByFG { get; private set; } = Array.Empty<int>();

        public int[] PltDebriefMeleeAIRankFG { get; private set; } = Array.Empty<int>();
        public int[] Pl2DebriefMeleeAIRankFG { get; private set; } = Array.Empty<int>();

        //...

        public ConnectedPlayerRecord[] PltConnectedPlayer { get; private set; } = new ConnectedPlayerRecord[8];
        public ConnectedPlayerRecord[] Pl2ConnectedPlayer { get; private set; } = new ConnectedPlayerRecord[8];

        public TeamResultRecord[] PltDebriefTeamResult { get; private set; } = new TeamResultRecord[10];
        public TeamResultRecord[] Pl2DebriefTeamResult { get; private set; } = new TeamResultRecord[10];

        //  Note the difference in types between the Plt and Pl2 versions; probably can homogenize these in the future
        public int PltLastSelectedFaction { get; private set; }
        public uint Pl2LastSelectedFaction { get; private set; }

        protected CompletePilotRecord pilotRecord;

        public PilotRecordViewModel(CompletePilotRecord pilotRecord)
        {
            this.pilotRecord = pilotRecord;
        }

        public void UpdatePilotRecord(CompletePilotRecord pilotRecord)
        {
            // Notify all public properties
            NotifyAllPublicPropertiesChanged();
        }

        private void NotifyAllPublicPropertiesChanged()
        {
            var props = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var p in props)
            {
                OnPropertyChanged(p.Name);
            }
        }
    }
}
