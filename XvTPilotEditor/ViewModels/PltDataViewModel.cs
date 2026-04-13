using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public class PltDataViewModel : PilotDataViewModelBase
    {
        protected PltRecord PltRecord;

        public PltDataViewModel(PltRecord initPltRecord)
        {
            this.PltRecord = initPltRecord;

            Unknown0x26 = new IntArrayViewModel(PltRecord.Unknown0x26);
            Unknown0x166 = new IntArrayViewModel(PltRecord.Unknown0x166);
            Unknown0x186 = new IntArrayViewModel(PltRecord.Unknown0x186);

            TotalFullKillsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalFullKillsOnPlayerRating?.Exercise,
                                                                                    PltRecord.TotalFullKillsOnPlayerRating?.Melee,
                                                                                    PltRecord.TotalFullKillsOnPlayerRating?.CombatEngagement);

            TotalSharedKillsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalSharedKillsOnPlayerRating?.Exercise,
                                                                                      PltRecord.TotalSharedKillsOnPlayerRating?.Melee,
                                                                                      PltRecord.TotalSharedKillsOnPlayerRating?.CombatEngagement);

            TotalAssistsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalAssistsOnPlayerRating?.Exercise,
                                                                                  PltRecord.TotalAssistsOnPlayerRating?.Melee,
                                                                                  PltRecord.TotalAssistsOnPlayerRating?.CombatEngagement);
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

        public IntArrayViewModel Unknown0x26 { get; private set; }
        public IntArrayViewModel Unknown0x166 { get; private set; }
        public IntArrayViewModel Unknown0x186 { get; private set; }

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

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

        // TotalCategoryScore
        public string TotalCategoryScoreExercise
        {
            get => PltRecord.TotalCategoryScore.Exercise.ToString();
            set { PltRecord.TotalCategoryScore.Exercise = SetIntProperty(value); }
        }
        public string TotalCategoryScoreMelee
        {
            get => PltRecord.TotalCategoryScore.Melee.ToString();
            set { PltRecord.TotalCategoryScore.Melee = SetIntProperty(value); }
        }
        public string TotalCategoryScoreCombatEngagement
        {
            get => PltRecord.TotalCategoryScore.CombatEngagement.ToString();
            set { PltRecord.TotalCategoryScore.CombatEngagement = SetIntProperty(value); }
        }

        // NumFlownNonSeries
        public string NumFlownNonSeriesExercise
        {
            get => PltRecord.NumFlownNonSeries.Exercise.ToString();
            set { PltRecord.NumFlownNonSeries.Exercise = SetIntProperty(value); }
        }
        public string NumFlownNonSeriesMelee
        {
            get => PltRecord.NumFlownNonSeries.Melee.ToString();
            set { PltRecord.NumFlownNonSeries.Melee = SetIntProperty(value); }
        }
        public string NumFlownNonSeriesCombatEngagement
        {
            get => PltRecord.NumFlownNonSeries.CombatEngagement.ToString();
            set { PltRecord.NumFlownNonSeries.CombatEngagement = SetIntProperty(value); }
        }

        // NumFlownSeries
        public string NumFlownSeriesExercise
        {
            get => PltRecord.NumFlownSeries.Exercise.ToString();
            set { PltRecord.NumFlownSeries.Exercise = SetIntProperty(value); }
        }
        public string NumFlownSeriesMelee
        {
            get => PltRecord.NumFlownSeries.Melee.ToString();
            set { PltRecord.NumFlownSeries.Melee = SetIntProperty(value); }
        }
        public string NumFlownSeriesCombatEngagement
        {
            get => PltRecord.NumFlownSeries.CombatEngagement.ToString();
            set { PltRecord.NumFlownSeries.CombatEngagement = SetIntProperty(value); }
        }

        // TotalKills
        public string TotalKillsExercise
        {
            get => PltRecord.TotalKills.Exercise.ToString();
            set { PltRecord.TotalKills.Exercise = SetIntProperty(value); }
        }
        public string TotalKillsMelee
        {
            get => PltRecord.TotalKills.Melee.ToString();
            set { PltRecord.TotalKills.Melee = SetIntProperty(value); }
        }
        public string TotalKillsCombatEngagement
        {
            get => PltRecord.TotalKills.CombatEngagement.ToString();
            set { PltRecord.TotalKills.CombatEngagement = SetIntProperty(value); }
        }

        // FriendlyKills
        public string FriendlyKillsExercise
        {
            get => PltRecord.FriendlyKills.Exercise.ToString();
            set { PltRecord.FriendlyKills.Exercise = SetIntProperty(value); }
        }
        public string FriendlyKillsMelee
        {
            get => PltRecord.FriendlyKills.Melee.ToString();
            set { PltRecord.FriendlyKills.Melee = SetIntProperty(value); }
        }
        public string FriendlyKillsCombatEngagement
        {
            get => PltRecord.FriendlyKills.CombatEngagement.ToString();
            set { PltRecord.FriendlyKills.CombatEngagement = SetIntProperty(value); }
        }

        public MissionCategoryRecordMatrixViewModel TotalFullKillsOnPlayerRating { get; private set; }
        public MissionCategoryRecordMatrixViewModel TotalSharedKillsOnPlayerRating { get; private set; }
        public MissionCategoryRecordMatrixViewModel TotalAssistsOnPlayerRating { get; private set; }

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

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

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

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

        public ConnectedPlayerRecord[] ConnectedPlayer { get; private set; } = new ConnectedPlayerRecord[8];

        public TeamResultRecord[] DebriefTeamResult { get; private set; } = new TeamResultRecord[10];

        //  Note the difference in types between the Plt (int) and Pl2 (uint) versions; probably can homogenize these in the future
        public string LastSelectedFaction
        {
            get => PltRecord.LastSelectedFaction.ToString();
            set { PltRecord.LastSelectedFaction = SetIntProperty(value); }
        }

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.
    }
}
