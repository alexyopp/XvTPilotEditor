using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class Pl2DataViewModel : PilotDataViewModelBase
    {
        protected Pl2Record Pl2Record;

        public Pl2DataViewModel(Pl2Record initPl2Record)
        {
            this.Pl2Record = initPl2Record;
        }

        public string PilotName
        {
            get => Pl2Record.PilotName;
            set { Pl2Record.PilotName = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }

        public string TotalScore
        {
            get => Pl2Record.TotalScore.ToString();
            set { Pl2Record.TotalScore = SetIntProperty(value); }
        }

        public string PlayerID
        {
            get => Pl2Record.PlayerID.ToString();
            set { Pl2Record.PlayerID = SetUIntProperty(value); }
        }

        public string ContinuedOrReflownMission
        {
            get => Pl2Record.ContinuedOrReflownMission.ToString();
            set { Pl2Record.ContinuedOrReflownMission = SetIntProperty(value); }
        }

        public string IsHosting
        {
            get => Pl2Record.IsHosting.ToString();
            set { Pl2Record.IsHosting = SetIntProperty(value); }
        }

        public string NumHumanPlayersInMission
        {
            get => Pl2Record.NumHumanPlayersInMission.ToString();
            set { Pl2Record.NumHumanPlayersInMission = SetIntProperty(value); }
        }

        public string FrontFlyMode
        {
            get => Pl2Record.FrontFlyMode.ToString();
            set { Pl2Record.FrontFlyMode = SetIntProperty(value); }
        }

        public int[] Unknown0x26 { get; private set; } = Array.Empty<int>();

        public int[] Unknown0x166 { get; private set; } = Array.Empty<int>();

        public int[] Unknown0x186 { get; private set; } = Array.Empty<int>();

        //...

        public string PromoPoints
        {
            get => Pl2Record.PromoPoints.ToString();
            set { Pl2Record.PromoPoints = SetIntProperty(value); }
        }

        public string WorsePromoPoints
        {
            get => Pl2Record.WorsePromoPoints.ToString();
            set { Pl2Record.WorsePromoPoints = SetIntProperty(value); }
        }

        public string RankAdjustmentApplied
        {
            get => Pl2Record.RankAdjustmentApplied.ToString();
            set { Pl2Record.RankAdjustmentApplied = SetIntProperty(value); }
        }

        public string PercentToNextRank
        {
            get => Pl2Record.PercentToNextRank.ToString();
            set { Pl2Record.PercentToNextRank = SetIntProperty(value); }
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
            get => Pl2Record.CurrentRank.ToString();
            set { Pl2Record.CurrentRank = SetUIntProperty(value); }
        }

        public string TotalCountMissionsFlown
        {
            get => Pl2Record.TotalCountMissionsFlown.ToString();
            set { Pl2Record.TotalCountMissionsFlown = SetIntProperty(value); }
        }

        public int[] RankAchievedOnMissionCount { get; private set; } = Array.Empty<int>();

        public string RankString
        {
            get => Pl2Record.RankString;
            set { Pl2Record.RankString = SetStringProperty(value, Constants.PILOT_RATING_NAME_MAX_LENGTH); }
        }

        public string DebriefMissionScore
        {
            get => Pl2Record.DebriefMissionScore.ToString();
            set { Pl2Record.DebriefMissionScore = SetIntProperty(value); }
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
            get => Pl2Record.LastSelectedFaction.ToString();
            set { Pl2Record.LastSelectedFaction = SetUIntProperty(value); }
        }
    }
}
