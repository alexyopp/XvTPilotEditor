using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class PltDataViewModel : PilotDataViewModelBase
    {
        protected PltRecord PltRecord;

        public PltDataViewModel(PltRecord initPltRecord)
        {
            this.PltRecord = initPltRecord;
        }

        public string PilotName
        {
            get => PltRecord.PilotName;
            set { PltRecord.PilotName = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }

        public string TotalScore
        {
            get => PltRecord.TotalScore.ToString();
            set { PltRecord.TotalScore = SetIntProperty(value); }
        }

        public string PlayerID
        {
            get => PltRecord.PlayerID.ToString();
            set { PltRecord.PlayerID = SetUIntProperty(value); }
        }

        public string ContinuedOrReflownMission
        {
            get => PltRecord.ContinuedOrReflownMission.ToString();
            set { PltRecord.ContinuedOrReflownMission = SetIntProperty(value); }
        }

        public string IsHosting
        {
            get => PltRecord.IsHosting.ToString();
            set { PltRecord.IsHosting = SetIntProperty(value); }
        }

        public string NumHumanPlayersInMission
        {
            get => PltRecord.NumHumanPlayersInMission.ToString();
            set { PltRecord.NumHumanPlayersInMission = SetIntProperty(value); }
        }

        public string FrontFlyMode
        {
            get => PltRecord.FrontFlyMode.ToString();
            set { PltRecord.FrontFlyMode = SetIntProperty(value); }
        }

        public int[] Unknown0x26 { get; private set; } = Array.Empty<int>();

        public int[] Unknown0x166 { get; private set; } = Array.Empty<int>();

        public int[] Unknown0x186 { get; private set; } = Array.Empty<int>();

        //...

        public string PromoPoints
        {
            get => PltRecord.PromoPoints.ToString();
            set { PltRecord.PromoPoints = SetIntProperty(value); }
        }

        public string WorsePromoPoints
        {
            get => PltRecord.WorsePromoPoints.ToString();
            set { PltRecord.WorsePromoPoints = SetIntProperty(value); }
        }

        public string RankAdjustmentApplied
        {
            get => PltRecord.RankAdjustmentApplied.ToString();
            set { PltRecord.RankAdjustmentApplied = SetIntProperty(value); }
        }

        public string PercentToNextRank
        {
            get => PltRecord.PercentToNextRank.ToString();
            set { PltRecord.PercentToNextRank = SetIntProperty(value); }
        }

        public MissionCategoryRecord TotalCategoryScore { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord NumFlownNonSeries { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord NumFlownSeries { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalKills { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord FriendlyKills { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecordByPlayerRating TotalFullKillsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByPlayerRating TotalSharedKillsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByPlayerRating TotalAssistsOnPlayerRating { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByAIRating TotalFullKillsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        public MissionCategoryRecordByAIRating TotalSharedKillsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        public MissionCategoryRecordByAIRating TotalAssistsOnAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        public MissionCategoryRecord TotalHiddenCargoFound { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalLaserHit { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalLaserFired { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalWarheadHit { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalWarheadFired { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalCraftLosses { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalLossesFromCollisions { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalLossesFromStarships { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecord TotalLossesFromMines { get; private set; } = new MissionCategoryRecord();

        public MissionCategoryRecordByPlayerRating TotalLossesFromPlayerRank { get; private set; } = new MissionCategoryRecordByPlayerRating();

        public MissionCategoryRecordByAIRating TotalLossesFromAIRank { get; private set; } = new MissionCategoryRecordByAIRating();

        //...

        // TODO: Sync with PilotRating enum?
        public string CurrentRank
        {
            get => PltRecord.CurrentRank.ToString();
            set { PltRecord.CurrentRank = SetUIntProperty(value); }
        }

        public string TotalCountMissionsFlown
        {
            get => PltRecord.TotalCountMissionsFlown.ToString();
            set { PltRecord.TotalCountMissionsFlown = SetIntProperty(value); }
        }

        public int[] RankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();

        public string RankString
        {
            get => PltRecord.RankString;
            set { PltRecord.RankString = SetStringProperty(value, Constants.PILOT_RATING_NAME_MAX_LENGTH); }
        }

        public string DebriefMissionScore
        {
            get => PltRecord.DebriefMissionScore.ToString();
            set { PltRecord.DebriefMissionScore = SetIntProperty(value); }
        }

        public int[] DebriefFullKillsOnPlayer { get; private set; } = Array.Empty<int>();

        public int[] DebriefSharedKillsOnPlayer { get; private set; } = Array.Empty<int>();

        public int[] DebriefFullKillsOnFG { get; private set; } = Array.Empty<int>();

        public int[] DebriefSharedKillsOnFG { get; private set; } = Array.Empty<int>();

        public int[] DebriefFullKillsByPlayer { get; private set; } = Array.Empty<int>();

        public int[] DebriefSharedKillsByPlayer { get; private set; } = Array.Empty<int>();

        public int[] DebriefFullKillsByFG { get; private set; } = Array.Empty<int>();

        public int[] DebriefSharedKillsByFG { get; private set; } = Array.Empty<int>();

        public int[] DebriefMeleeAIRankFG { get; private set; } = Array.Empty<int>();

        //...

        public ConnectedPlayerRecord[] ConnectedPlayer { get; private set; } = new ConnectedPlayerRecord[8];

        public TeamResultRecord[] DebriefTeamResult { get; private set; } = new TeamResultRecord[10];

        //  Note the difference in types between the Plt (int) and Pl2 (uint) versions; probably can homogenize these in the future
        public string LastSelectedFaction
        {
            get => PltRecord.LastSelectedFaction.ToString();
            set { PltRecord.LastSelectedFaction = SetIntProperty(value); }
        }
    }
}
