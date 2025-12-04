using System;
using System.Reflection;
using System.Windows;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class PilotRecordViewModel : ViewModelBase
    {
        // PilotName
        public string PltPilotName
        {
            get => pilotRecord.Plt.PilotName;
            set{ pilotRecord.Plt.PilotName = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }
        public string Pl2PilotName
        {
            get => pilotRecord.Pl2.PilotName;
            set { pilotRecord.Pl2.PilotName = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }

        // TotalScore
        public string PltTotalScore
        {
            get => pilotRecord.Plt.TotalScore.ToString();
            set { pilotRecord.Plt.TotalScore = SetIntProperty(value); }
        }
        public string Pl2TotalScore
        {
            get => pilotRecord.Pl2.TotalScore.ToString();
            set { pilotRecord.Pl2.TotalScore = SetIntProperty(value); }
        }

        // PlayerID
        public string PltPlayerID
        {
            get => pilotRecord.Plt.PlayerID.ToString();
            set { pilotRecord.Plt.PlayerID = SetUIntProperty(value); }
        }
        public string Pl2PlayerID
        {
            get => pilotRecord.Pl2.PlayerID.ToString();
            set { pilotRecord.Pl2.PlayerID = SetUIntProperty(value); }
        }

        // ContinuedOrReflownMission
        public string PltContinuedOrReflownMission
        {
            get => pilotRecord.Plt.ContinuedOrReflownMission.ToString();
            set { pilotRecord.Plt.ContinuedOrReflownMission = SetIntProperty(value); }
        }
        public string Pl2ContinuedOrReflownMission
        {
            get => pilotRecord.Pl2.ContinuedOrReflownMission.ToString();
            set { pilotRecord.Pl2.ContinuedOrReflownMission = SetIntProperty(value); }
        }

        // IsHosting
        public string PltIsHosting
        {
            get => pilotRecord.Plt.IsHosting.ToString();
            set { pilotRecord.Plt.IsHosting = SetIntProperty(value); }
        }
        public string Pl2IsHosting
        {
            get => pilotRecord.Pl2.IsHosting.ToString();
            set { pilotRecord.Pl2.IsHosting = SetIntProperty(value); }
        }

        // NumHumanPlayersInMission
        public string PltNumHumanPlayersInMission
        {
            get => pilotRecord.Plt.NumHumanPlayersInMission.ToString();
            set { pilotRecord.Plt.NumHumanPlayersInMission = SetIntProperty(value); }
        }
        public string Pl2NumHumanPlayersInMission
        {
            get => pilotRecord.Pl2.NumHumanPlayersInMission.ToString();
            set { pilotRecord.Pl2.NumHumanPlayersInMission = SetIntProperty(value); }
        }

        // FrontFlyMode
        public string PltFrontFlyMode
        {
            get => pilotRecord.Plt.FrontFlyMode.ToString();
            set { pilotRecord.Plt.FrontFlyMode = SetIntProperty(value); }
        }
        public string Pl2FrontFlyMode
        {
            get => pilotRecord.Pl2.FrontFlyMode.ToString();
            set { pilotRecord.Pl2.FrontFlyMode = SetIntProperty(value); }
        }

        public int[] PltUnknown0x26 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x26 { get; private set; } = Array.Empty<int>();

        public int[] PltUnknown0x166 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x166 { get; private set; } = Array.Empty<int>();

        public int[] PltUnknown0x186 { get; private set; } = Array.Empty<int>();
        public int[] Pl2Unknown0x186 { get; private set; } = Array.Empty<int>();

        //...

        // PromoPoints
        public string PltPromoPoints
        {
            get => pilotRecord.Plt.PromoPoints.ToString();
            set { pilotRecord.Plt.PromoPoints = SetIntProperty(value); }
        }
        public string Pl2PromoPoints
        {
            get => pilotRecord.Pl2.PromoPoints.ToString();
            set { pilotRecord.Pl2.PromoPoints = SetIntProperty(value); }
        }

        // WorsePromoPoints
        public string PltWorsePromoPoints
        {
            get => pilotRecord.Plt.WorsePromoPoints.ToString();
            set { pilotRecord.Plt.WorsePromoPoints = SetIntProperty(value); }
        }
        public string Pl2WorsePromoPoints
        {
            get => pilotRecord.Pl2.WorsePromoPoints.ToString();
            set { pilotRecord.Pl2.WorsePromoPoints = SetIntProperty(value); }
        }

        // RankAdjustmentApplied
        public string PltRankAdjustmentApplied
        {
            get => pilotRecord.Plt.RankAdjustmentApplied.ToString();
            set { pilotRecord.Plt.RankAdjustmentApplied = SetIntProperty(value); }
        }
        public string Pl2RankAdjustmentApplied
        {
            get => pilotRecord.Pl2.RankAdjustmentApplied.ToString();
            set { pilotRecord.Pl2.RankAdjustmentApplied = SetIntProperty(value); }
        }

        // PercentToNextRank
        public string PltPercentToNextRank
        {
            get => pilotRecord.Plt.PercentToNextRank.ToString();
            set { pilotRecord.Plt.PercentToNextRank = SetIntProperty(value); }
        }
        public string Pl2PercentToNextRank
        {
            get => pilotRecord.Pl2.PercentToNextRank.ToString();
            set { pilotRecord.Pl2.PercentToNextRank = SetIntProperty(value); }
        }

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

        // CurrentRank
        // TODO: Sync with PilotRating enum?
        public string PltCurrentRank
        {
            get => pilotRecord.Plt.CurrentRank.ToString();
            set { pilotRecord.Plt.CurrentRank = SetUIntProperty(value); }
        }
        public string Pl2CurrentRank
        {
            get => pilotRecord.Pl2.CurrentRank.ToString();
            set { pilotRecord.Pl2.CurrentRank = SetUIntProperty(value); }
        }

        // TotalCountMissionsFlown
        public string PltTotalCountMissionsFlown
        {
            get => pilotRecord.Plt.TotalCountMissionsFlown.ToString();
            set { pilotRecord.Plt.TotalCountMissionsFlown = SetIntProperty(value); }
        }
        public string Pl2TotalCountMissionsFlown
        {
            get => pilotRecord.Pl2.TotalCountMissionsFlown.ToString();
            set { pilotRecord.Pl2.TotalCountMissionsFlown = SetIntProperty(value); }
        }

        public int[] PltRankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();
        public int[] Pl2RankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();

        // RankString
        public string PltRankString
        {
            get => pilotRecord.Plt.RankString;
            set { pilotRecord.Plt.RankString = SetStringProperty(value, Constants.PILOT_RATING_NAME_MAX_LENGTH); }
        }
        public string Pl2RankString
        {
            get => pilotRecord.Pl2.RankString;
            set { pilotRecord.Pl2.RankString = SetStringProperty(value, Constants.PILOT_RATING_NAME_MAX_LENGTH); }
        }

        // DebriefMissionScore
        public string PltDebriefMissionScore
        {
            get => pilotRecord.Plt.DebriefMissionScore.ToString();
            set { pilotRecord.Plt.DebriefMissionScore = SetIntProperty(value); }
        }
        public string Pl2DebriefMissionScore
        {
            get => pilotRecord.Pl2.DebriefMissionScore.ToString();
            set { pilotRecord.Pl2.DebriefMissionScore = SetIntProperty(value); }
        }

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

        // LastSelectedFaction
        //  Note the difference in types between the Plt and Pl2 versions; probably can homogenize these in the future
        public string PltLastSelectedFaction
        {
            get => pilotRecord.Plt.LastSelectedFaction.ToString();
            set { pilotRecord.Plt.LastSelectedFaction = SetIntProperty(value); }
        }
        public string Pl2LastSelectedFaction
        {
            get => pilotRecord.Pl2.LastSelectedFaction.ToString();
            set { pilotRecord.Pl2.LastSelectedFaction = SetUIntProperty(value); }
        }

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

        private string SetStringProperty(string newValue, uint maxLength)
        {
            if (newValue.Length > maxLength)
            {
                MessageBox.Show("Pilot name must be no more than " + maxLength + " characters long.", "Invalid Pilot Name");
            }

            return newValue;
        }

        private int SetIntProperty(string newValue)
        {
            int intValue;
            if (int.TryParse(newValue, out intValue))
            {
                return intValue;
            }
            else
            {
                throw new ArgumentException($"{newValue} must be an integer");
            }
        }

        private uint SetUIntProperty(string newValue)
        {
            uint uintValue;
            if (uint.TryParse(newValue, out uintValue))
            {
                return uintValue;
            }
            else
            {
                throw new ArgumentException($"{newValue} must be an unsigned integer");
            }
        }
    }
}
