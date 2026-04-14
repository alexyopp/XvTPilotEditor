using System;
using System.Collections.ObjectModel;
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
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedTotalKillsOnPlayerRatingExercise = CollectionHelpers.Combine(TotalFullKillsOnPlayerRating.Exercise, TotalSharedKillsOnPlayerRating.Exercise);
            CombinedTotalKillsOnPlayerRatingMelee = CollectionHelpers.Combine(TotalFullKillsOnPlayerRating.Melee, TotalSharedKillsOnPlayerRating.Melee);
            CombinedTotalKillsOnPlayerRatingCombat = CollectionHelpers.Combine(TotalFullKillsOnPlayerRating.Combat, TotalSharedKillsOnPlayerRating.Combat);

            TotalAssistsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalAssistsOnPlayerRating?.Exercise,
                                                                      PltRecord.TotalAssistsOnPlayerRating?.Melee,
                                                                      PltRecord.TotalAssistsOnPlayerRating?.CombatEngagement);

            TotalFullKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalFullKillsOnAIRank?.Exercise,
                                                                              PltRecord.TotalFullKillsOnAIRank?.Melee,
                                                                              PltRecord.TotalFullKillsOnAIRank?.CombatEngagement);
            TotalSharedKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalSharedKillsOnAIRank?.Exercise,
                                                                                PltRecord.TotalSharedKillsOnAIRank?.Melee,
                                                                                PltRecord.TotalSharedKillsOnAIRank?.CombatEngagement);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedTotalKillsOnAIRankExercise = CollectionHelpers.Combine(TotalFullKillsOnAIRank.Exercise, TotalSharedKillsOnAIRank.Exercise);
            CombinedTotalKillsOnAIRankMelee = CollectionHelpers.Combine(TotalFullKillsOnAIRank.Melee, TotalSharedKillsOnAIRank.Melee);
            CombinedTotalKillsOnAIRankCombat = CollectionHelpers.Combine(TotalFullKillsOnAIRank.Combat, TotalSharedKillsOnAIRank.Combat);

            TotalAssistsOnAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalAssistsOnAIRank?.Exercise,
                                                                PltRecord.TotalAssistsOnAIRank?.Melee,
                                                                PltRecord.TotalAssistsOnAIRank?.CombatEngagement);

            TotalLossesFromPlayerRank = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalLossesFromPlayerRank?.Exercise,
                                                                                 PltRecord.TotalLossesFromPlayerRank?.Melee,
                                                                                 PltRecord.TotalLossesFromPlayerRank?.CombatEngagement);

            TotalLossesFromAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalLossesFromAIRank?.Exercise,
                                                                             PltRecord.TotalLossesFromAIRank?.Melee,
                                                                             PltRecord.TotalLossesFromAIRank?.CombatEngagement);

            RankAchievedOnMissionCount = new IntArrayViewModel(PltRecord.RankAchievedOnMissionCount);

            DebriefFullKillsOnPlayer = new IntArrayViewModel(PltRecord.DebriefFullKillsOnPlayer);
            DebriefSharedKillsOnPlayer = new IntArrayViewModel(PltRecord.DebriefSharedKillsOnPlayer);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsOnPlayer = CollectionHelpers.Combine(DebriefFullKillsOnPlayer.Values, DebriefSharedKillsOnPlayer.Values);

            DebriefFullKillsOnFG = new IntArrayViewModel(PltRecord.DebriefFullKillsOnFG);
            DebriefSharedKillsOnFG = new IntArrayViewModel(PltRecord.DebriefSharedKillsOnFG);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsOnFG = CollectionHelpers.Combine(DebriefFullKillsOnFG.Values, DebriefSharedKillsOnFG.Values);

            DebriefFullKillsByPlayer = new IntArrayViewModel(PltRecord.DebriefFullKillsByPlayer);
            DebriefSharedKillsByPlayer = new IntArrayViewModel(PltRecord.DebriefSharedKillsByPlayer);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByPlayer = CollectionHelpers.Combine(DebriefFullKillsByPlayer.Values, DebriefSharedKillsByPlayer.Values);

            DebriefFullKillsByFG = new IntArrayViewModel(PltRecord.DebriefFullKillsByFG);
            DebriefSharedKillsByFG = new IntArrayViewModel(PltRecord.DebriefSharedKillsByFG);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByFG = CollectionHelpers.Combine(DebriefFullKillsByFG.Values, DebriefSharedKillsByFG.Values);

            DebriefMeleeAIRankFG = new IntArrayViewModel(PltRecord.DebriefMeleeAIRankFG);

            foreach (var connectedPlayerRecord in PltRecord.ConnectedPlayer)
            {
                ConnectedPlayer.Add(new ConnectedPlayerRecordViewModel(connectedPlayerRecord));
            }
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

        private MissionCategoryRecordMatrixViewModel TotalFullKillsOnPlayerRating;
        private MissionCategoryRecordMatrixViewModel TotalSharedKillsOnPlayerRating;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedTotalKillsOnPlayerRatingExercise { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedTotalKillsOnPlayerRatingMelee { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedTotalKillsOnPlayerRatingCombat { get; private set; } = new();

        public MissionCategoryRecordMatrixViewModel TotalAssistsOnPlayerRating { get; private set; }

        private MissionCategoryRecordMatrixViewModel TotalFullKillsOnAIRank;
        private MissionCategoryRecordMatrixViewModel TotalSharedKillsOnAIRank;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedTotalKillsOnAIRankExercise { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedTotalKillsOnAIRankMelee { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedTotalKillsOnAIRankCombat { get; private set; } = new();

        public MissionCategoryRecordMatrixViewModel TotalAssistsOnAIRank { get; private set; }

        // TotalHiddenCargoFound
        public string TotalHiddenCargoFoundExercise
        {
            get => PltRecord.TotalHiddenCargoFound.Exercise.ToString();
            set { PltRecord.TotalHiddenCargoFound.Exercise = SetIntProperty(value); }
        }
        public string TotalHiddenCargoFoundMelee
        {
            get => PltRecord.TotalHiddenCargoFound.Melee.ToString();
            set { PltRecord.TotalHiddenCargoFound.Melee = SetIntProperty(value); }
        }
        public string TotalHiddenCargoFoundCombatEngagement
        {
            get => PltRecord.TotalHiddenCargoFound.CombatEngagement.ToString();
            set { PltRecord.TotalHiddenCargoFound.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLaserHit
        public string TotalLaserHitExercise
        {
            get => PltRecord.TotalLaserHit.Exercise.ToString();
            set { PltRecord.TotalLaserHit.Exercise = SetIntProperty(value); }
        }
        public string TotalLaserHitMelee
        {
            get => PltRecord.TotalLaserHit.Melee.ToString();
            set { PltRecord.TotalLaserHit.Melee = SetIntProperty(value); }
        }
        public string TotalLaserHitCombatEngagement
        {
            get => PltRecord.TotalLaserHit.CombatEngagement.ToString();
            set { PltRecord.TotalLaserHit.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLaserFired
        public string TotalLaserFiredExercise
        {
            get => PltRecord.TotalLaserFired.Exercise.ToString();
            set { PltRecord.TotalLaserFired.Exercise = SetIntProperty(value); }
        }
        public string TotalLaserFiredMelee
        {
            get => PltRecord.TotalLaserFired.Melee.ToString();
            set { PltRecord.TotalLaserFired.Melee = SetIntProperty(value); }
        }
        public string TotalLaserFiredCombatEngagement
        {
            get => PltRecord.TotalLaserFired.CombatEngagement.ToString();
            set { PltRecord.TotalLaserFired.CombatEngagement = SetIntProperty(value); }
        }

        // TotalWarheadHit
        public string TotalWarheadHitExercise
        {
            get => PltRecord.TotalWarheadHit.Exercise.ToString();
            set { PltRecord.TotalWarheadHit.Exercise = SetIntProperty(value); }
        }
        public string TotalWarheadHitMelee
        {
            get => PltRecord.TotalWarheadHit.Melee.ToString();
            set { PltRecord.TotalWarheadHit.Melee = SetIntProperty(value); }
        }
        public string TotalWarheadHitCombatEngagement
        {
            get => PltRecord.TotalWarheadHit.CombatEngagement.ToString();
            set { PltRecord.TotalWarheadHit.CombatEngagement = SetIntProperty(value); }
        }

        // TotalWarheadFired
        public string TotalWarheadFiredExercise
        {
            get => PltRecord.TotalWarheadFired.Exercise.ToString();
            set { PltRecord.TotalWarheadFired.Exercise = SetIntProperty(value); }
        }
        public string TotalWarheadFiredMelee
        {
            get => PltRecord.TotalWarheadFired.Melee.ToString();
            set { PltRecord.TotalWarheadFired.Melee = SetIntProperty(value); }
        }
        public string TotalWarheadFiredCombatEngagement
        {
            get => PltRecord.TotalWarheadFired.CombatEngagement.ToString();
            set { PltRecord.TotalWarheadFired.CombatEngagement = SetIntProperty(value); }
        }

        // TotalCraftLosses
        public string TotalCraftLossesExercise
        {
            get => PltRecord.TotalCraftLosses.Exercise.ToString();
            set { PltRecord.TotalCraftLosses.Exercise = SetIntProperty(value); }
        }
        public string TotalCraftLossesMelee
        {
            get => PltRecord.TotalCraftLosses.Melee.ToString();
            set { PltRecord.TotalCraftLosses.Melee = SetIntProperty(value); }
        }
        public string TotalCraftLossesCombatEngagement
        {
            get => PltRecord.TotalCraftLosses.CombatEngagement.ToString();
            set { PltRecord.TotalCraftLosses.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLossesFromCollisions
        public string TotalLossesFromCollisionsExercise
        {
            get => PltRecord.TotalLossesFromCollisions.Exercise.ToString();
            set { PltRecord.TotalLossesFromCollisions.Exercise = SetIntProperty(value); }
        }
        public string TotalLossesFromCollisionsMelee
        {
            get => PltRecord.TotalLossesFromCollisions.Melee.ToString();
            set { PltRecord.TotalLossesFromCollisions.Melee = SetIntProperty(value); }
        }
        public string TotalLossesFromCollisionsCombatEngagement
        {
            get => PltRecord.TotalLossesFromCollisions.CombatEngagement.ToString();
            set { PltRecord.TotalLossesFromCollisions.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLossesFromStarships
        public string TotalLossesFromStarshipsExercise
        {
            get => PltRecord.TotalLossesFromStarships.Exercise.ToString();
            set { PltRecord.TotalLossesFromStarships.Exercise = SetIntProperty(value); }
        }
        public string TotalLossesFromStarshipsMelee
        {
            get => PltRecord.TotalLossesFromStarships.Melee.ToString();
            set { PltRecord.TotalLossesFromStarships.Melee = SetIntProperty(value); }
        }
        public string TotalLossesFromStarshipsCombatEngagement
        {
            get => PltRecord.TotalLossesFromStarships.CombatEngagement.ToString();
            set { PltRecord.TotalLossesFromStarships.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLossesFromMines
        public string TotalLossesFromMinesExercise
        {
            get => PltRecord.TotalLossesFromMines.Exercise.ToString();
            set { PltRecord.TotalLossesFromMines.Exercise = SetIntProperty(value); }
        }
        public string TotalLossesFromMinesMelee
        {
            get => PltRecord.TotalLossesFromMines.Melee.ToString();
            set { PltRecord.TotalLossesFromMines.Melee = SetIntProperty(value); }
        }
        public string TotalLossesFromMinesCombatEngagement
        {
            get => PltRecord.TotalLossesFromMines.CombatEngagement.ToString();
            set { PltRecord.TotalLossesFromMines.CombatEngagement = SetIntProperty(value); }
        }

        public MissionCategoryRecordMatrixViewModel TotalLossesFromPlayerRank { get; private set; }

        public MissionCategoryRecordMatrixViewModel TotalLossesFromAIRank { get; private set; }

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

        // Leave this number value as-is; do not convert to a Pilot Rating description.  That is handled by the RankString property.
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

        public IntArrayViewModel RankAchievedOnMissionCount { get; private set; }

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

        private IntArrayViewModel DebriefFullKillsOnPlayer;
        private IntArrayViewModel DebriefSharedKillsOnPlayer;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnPlayer { get; private set; } = new();

        private IntArrayViewModel DebriefFullKillsOnFG;
        private IntArrayViewModel DebriefSharedKillsOnFG;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnFG { get; private set; } = new();

        private IntArrayViewModel DebriefFullKillsByPlayer;
        private IntArrayViewModel DebriefSharedKillsByPlayer;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsByPlayer { get; private set; } = new();

        private IntArrayViewModel DebriefFullKillsByFG;
        private IntArrayViewModel DebriefSharedKillsByFG;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsByFG { get; private set; } = new();

        public IntArrayViewModel DebriefMeleeAIRankFG { get; private set; }

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

        public ObservableCollection<ConnectedPlayerRecordViewModel> ConnectedPlayer { get; private set; } = new();

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
