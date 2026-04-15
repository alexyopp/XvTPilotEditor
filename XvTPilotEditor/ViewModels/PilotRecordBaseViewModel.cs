using System;
using System.Collections.ObjectModel;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public class PilotRecordBaseViewModel : PilotDataViewModelBase
    {
        protected PilotRecordBase PilotRecordBase;

        public PilotRecordBaseViewModel(PilotRecordBase initPilotRecordBase)
        {
            this.PilotRecordBase = initPilotRecordBase;

            Unknown0x26 = new IntArrayViewModel(PilotRecordBase.Unknown0x26);
            Unknown0x166 = new IntArrayViewModel(PilotRecordBase.Unknown0x166);
            Unknown0x186 = new IntArrayViewModel(PilotRecordBase.Unknown0x186);

            TotalFullKillsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalFullKillsOnPlayerRating?.Exercise,
                                                                                    PilotRecordBase.TotalFullKillsOnPlayerRating?.Melee,
                                                                                    PilotRecordBase.TotalFullKillsOnPlayerRating?.CombatEngagement);
            TotalSharedKillsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalSharedKillsOnPlayerRating?.Exercise,
                                                                                      PilotRecordBase.TotalSharedKillsOnPlayerRating?.Melee,
                                                                                      PilotRecordBase.TotalSharedKillsOnPlayerRating?.CombatEngagement);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedTotalKillsOnPlayerRatingExercise = CollectionHelpers.Combine(TotalFullKillsOnPlayerRating.Exercise, TotalSharedKillsOnPlayerRating.Exercise);
            CombinedTotalKillsOnPlayerRatingMelee = CollectionHelpers.Combine(TotalFullKillsOnPlayerRating.Melee, TotalSharedKillsOnPlayerRating.Melee);
            CombinedTotalKillsOnPlayerRatingCombat = CollectionHelpers.Combine(TotalFullKillsOnPlayerRating.Combat, TotalSharedKillsOnPlayerRating.Combat);

            TotalAssistsOnPlayerRating = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalAssistsOnPlayerRating?.Exercise,
                                                                      PilotRecordBase.TotalAssistsOnPlayerRating?.Melee,
                                                                      PilotRecordBase.TotalAssistsOnPlayerRating?.CombatEngagement);

            TotalFullKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalFullKillsOnAIRank?.Exercise,
                                                                              PilotRecordBase.TotalFullKillsOnAIRank?.Melee,
                                                                              PilotRecordBase.TotalFullKillsOnAIRank?.CombatEngagement);
            TotalSharedKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalSharedKillsOnAIRank?.Exercise,
                                                                                PilotRecordBase.TotalSharedKillsOnAIRank?.Melee,
                                                                                PilotRecordBase.TotalSharedKillsOnAIRank?.CombatEngagement);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedTotalKillsOnAIRankExercise = CollectionHelpers.Combine(TotalFullKillsOnAIRank.Exercise, TotalSharedKillsOnAIRank.Exercise);
            CombinedTotalKillsOnAIRankMelee = CollectionHelpers.Combine(TotalFullKillsOnAIRank.Melee, TotalSharedKillsOnAIRank.Melee);
            CombinedTotalKillsOnAIRankCombat = CollectionHelpers.Combine(TotalFullKillsOnAIRank.Combat, TotalSharedKillsOnAIRank.Combat);

            TotalAssistsOnAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalAssistsOnAIRank?.Exercise,
                                                                PilotRecordBase.TotalAssistsOnAIRank?.Melee,
                                                                PilotRecordBase.TotalAssistsOnAIRank?.CombatEngagement);

            TotalLossesFromPlayerRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalLossesFromPlayerRank?.Exercise,
                                                                                 PilotRecordBase.TotalLossesFromPlayerRank?.Melee,
                                                                                 PilotRecordBase.TotalLossesFromPlayerRank?.CombatEngagement);

            TotalLossesFromAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalLossesFromAIRank?.Exercise,
                                                                             PilotRecordBase.TotalLossesFromAIRank?.Melee,
                                                                             PilotRecordBase.TotalLossesFromAIRank?.CombatEngagement);

            RankAchievedOnMissionCount = new IntArrayViewModel(PilotRecordBase.RankAchievedOnMissionCount);

            DebriefFullKillsOnPlayer = new IntArrayViewModel(PilotRecordBase.DebriefFullKillsOnPlayer);
            DebriefSharedKillsOnPlayer = new IntArrayViewModel(PilotRecordBase.DebriefSharedKillsOnPlayer);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsOnPlayer = CollectionHelpers.Combine(DebriefFullKillsOnPlayer.Values, DebriefSharedKillsOnPlayer.Values);

            DebriefFullKillsOnFG = new IntArrayViewModel(PilotRecordBase.DebriefFullKillsOnFG);
            DebriefSharedKillsOnFG = new IntArrayViewModel(PilotRecordBase.DebriefSharedKillsOnFG);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsOnFG = CollectionHelpers.Combine(DebriefFullKillsOnFG.Values, DebriefSharedKillsOnFG.Values);

            DebriefFullKillsByPlayer = new IntArrayViewModel(PilotRecordBase.DebriefFullKillsByPlayer);
            DebriefSharedKillsByPlayer = new IntArrayViewModel(PilotRecordBase.DebriefSharedKillsByPlayer);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByPlayer = CollectionHelpers.Combine(DebriefFullKillsByPlayer.Values, DebriefSharedKillsByPlayer.Values);

            DebriefFullKillsByFG = new IntArrayViewModel(PilotRecordBase.DebriefFullKillsByFG);
            DebriefSharedKillsByFG = new IntArrayViewModel(PilotRecordBase.DebriefSharedKillsByFG);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByFG = CollectionHelpers.Combine(DebriefFullKillsByFG.Values, DebriefSharedKillsByFG.Values);

            DebriefMeleeAIRankFG = new IntArrayViewModel(PilotRecordBase.DebriefMeleeAIRankFG);

            foreach (var connectedPlayerRecord in PilotRecordBase.ConnectedPlayer)
            {
                ConnectedPlayer.Add(new ConnectedPlayerRecordViewModel(connectedPlayerRecord));
            }

            foreach (var teamResultRecord in PilotRecordBase.DebriefTeamResult)
            {
                DebriefTeamResult.Add(new TeamResultRecordViewModel(teamResultRecord));
            }
        }

        public string PilotName
        {
            get => PilotRecordBase.PilotName;
            set { PilotRecordBase.PilotName = SetStringProperty(value, Constants.PILOT_NAME_MAX_LENGTH); }
        }

        public string TotalScore
        {
            get => PilotRecordBase.TotalScore.ToString();
            set { PilotRecordBase.TotalScore = SetIntProperty(value); }
        }

        public string PlayerID
        {
            get => PilotRecordBase.PlayerID.ToString();
            set { PilotRecordBase.PlayerID = SetUIntProperty(value); }
        }

        public string ContinuedOrReflownMission
        {
            get => PilotRecordBase.ContinuedOrReflownMission.ToString();
            set { PilotRecordBase.ContinuedOrReflownMission = SetIntProperty(value); }
        }

        public string IsHosting
        {
            get => PilotRecordBase.IsHosting.ToString();
            set { PilotRecordBase.IsHosting = SetIntProperty(value); }
        }

        public string NumHumanPlayersInMission
        {
            get => PilotRecordBase.NumHumanPlayersInMission.ToString();
            set { PilotRecordBase.NumHumanPlayersInMission = SetIntProperty(value); }
        }

        public string FrontFlyMode
        {
            get => PilotRecordBase.FrontFlyMode.ToString();
            set { PilotRecordBase.FrontFlyMode = SetIntProperty(value); }
        }

        public IntArrayViewModel Unknown0x26 { get; private set; }
        public IntArrayViewModel Unknown0x166 { get; private set; }
        public IntArrayViewModel Unknown0x186 { get; private set; }

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

        public string PromoPoints
        {
            get => PilotRecordBase.PromoPoints.ToString();
            set { PilotRecordBase.PromoPoints = SetIntProperty(value); }
        }

        public string WorsePromoPoints
        {
            get => PilotRecordBase.WorsePromoPoints.ToString();
            set { PilotRecordBase.WorsePromoPoints = SetIntProperty(value); }
        }

        public string RankAdjustmentApplied
        {
            get => PilotRecordBase.RankAdjustmentApplied.ToString();
            set { PilotRecordBase.RankAdjustmentApplied = SetIntProperty(value); }
        }

        public string PercentToNextRank
        {
            get => PilotRecordBase.PercentToNextRank.ToString();
            set { PilotRecordBase.PercentToNextRank = SetIntProperty(value); }
        }

        // TotalCategoryScore
        public string TotalCategoryScoreExercise
        {
            get => PilotRecordBase.TotalCategoryScore.Exercise.ToString();
            set { PilotRecordBase.TotalCategoryScore.Exercise = SetIntProperty(value); }
        }
        public string TotalCategoryScoreMelee
        {
            get => PilotRecordBase.TotalCategoryScore.Melee.ToString();
            set { PilotRecordBase.TotalCategoryScore.Melee = SetIntProperty(value); }
        }
        public string TotalCategoryScoreCombatEngagement
        {
            get => PilotRecordBase.TotalCategoryScore.CombatEngagement.ToString();
            set { PilotRecordBase.TotalCategoryScore.CombatEngagement = SetIntProperty(value); }
        }

        // NumFlownNonSeries
        public string NumFlownNonSeriesExercise
        {
            get => PilotRecordBase.NumFlownNonSeries.Exercise.ToString();
            set { PilotRecordBase.NumFlownNonSeries.Exercise = SetIntProperty(value); }
        }
        public string NumFlownNonSeriesMelee
        {
            get => PilotRecordBase.NumFlownNonSeries.Melee.ToString();
            set { PilotRecordBase.NumFlownNonSeries.Melee = SetIntProperty(value); }
        }
        public string NumFlownNonSeriesCombatEngagement
        {
            get => PilotRecordBase.NumFlownNonSeries.CombatEngagement.ToString();
            set { PilotRecordBase.NumFlownNonSeries.CombatEngagement = SetIntProperty(value); }
        }

        // NumFlownSeries
        public string NumFlownSeriesExercise
        {
            get => PilotRecordBase.NumFlownSeries.Exercise.ToString();
            set { PilotRecordBase.NumFlownSeries.Exercise = SetIntProperty(value); }
        }
        public string NumFlownSeriesMelee
        {
            get => PilotRecordBase.NumFlownSeries.Melee.ToString();
            set { PilotRecordBase.NumFlownSeries.Melee = SetIntProperty(value); }
        }
        public string NumFlownSeriesCombatEngagement
        {
            get => PilotRecordBase.NumFlownSeries.CombatEngagement.ToString();
            set { PilotRecordBase.NumFlownSeries.CombatEngagement = SetIntProperty(value); }
        }

        // TotalKills
        public string TotalKillsExercise
        {
            get => PilotRecordBase.TotalKills.Exercise.ToString();
            set { PilotRecordBase.TotalKills.Exercise = SetIntProperty(value); }
        }
        public string TotalKillsMelee
        {
            get => PilotRecordBase.TotalKills.Melee.ToString();
            set { PilotRecordBase.TotalKills.Melee = SetIntProperty(value); }
        }
        public string TotalKillsCombatEngagement
        {
            get => PilotRecordBase.TotalKills.CombatEngagement.ToString();
            set { PilotRecordBase.TotalKills.CombatEngagement = SetIntProperty(value); }
        }

        // FriendlyKills
        public string FriendlyKillsExercise
        {
            get => PilotRecordBase.FriendlyKills.Exercise.ToString();
            set { PilotRecordBase.FriendlyKills.Exercise = SetIntProperty(value); }
        }
        public string FriendlyKillsMelee
        {
            get => PilotRecordBase.FriendlyKills.Melee.ToString();
            set { PilotRecordBase.FriendlyKills.Melee = SetIntProperty(value); }
        }
        public string FriendlyKillsCombatEngagement
        {
            get => PilotRecordBase.FriendlyKills.CombatEngagement.ToString();
            set { PilotRecordBase.FriendlyKills.CombatEngagement = SetIntProperty(value); }
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
            get => PilotRecordBase.TotalHiddenCargoFound.Exercise.ToString();
            set { PilotRecordBase.TotalHiddenCargoFound.Exercise = SetIntProperty(value); }
        }
        public string TotalHiddenCargoFoundMelee
        {
            get => PilotRecordBase.TotalHiddenCargoFound.Melee.ToString();
            set { PilotRecordBase.TotalHiddenCargoFound.Melee = SetIntProperty(value); }
        }
        public string TotalHiddenCargoFoundCombatEngagement
        {
            get => PilotRecordBase.TotalHiddenCargoFound.CombatEngagement.ToString();
            set { PilotRecordBase.TotalHiddenCargoFound.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLaserHit
        public string TotalLaserHitExercise
        {
            get => PilotRecordBase.TotalLaserHit.Exercise.ToString();
            set { PilotRecordBase.TotalLaserHit.Exercise = SetIntProperty(value); }
        }
        public string TotalLaserHitMelee
        {
            get => PilotRecordBase.TotalLaserHit.Melee.ToString();
            set { PilotRecordBase.TotalLaserHit.Melee = SetIntProperty(value); }
        }
        public string TotalLaserHitCombatEngagement
        {
            get => PilotRecordBase.TotalLaserHit.CombatEngagement.ToString();
            set { PilotRecordBase.TotalLaserHit.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLaserFired
        public string TotalLaserFiredExercise
        {
            get => PilotRecordBase.TotalLaserFired.Exercise.ToString();
            set { PilotRecordBase.TotalLaserFired.Exercise = SetIntProperty(value); }
        }
        public string TotalLaserFiredMelee
        {
            get => PilotRecordBase.TotalLaserFired.Melee.ToString();
            set { PilotRecordBase.TotalLaserFired.Melee = SetIntProperty(value); }
        }
        public string TotalLaserFiredCombatEngagement
        {
            get => PilotRecordBase.TotalLaserFired.CombatEngagement.ToString();
            set { PilotRecordBase.TotalLaserFired.CombatEngagement = SetIntProperty(value); }
        }

        // TotalWarheadHit
        public string TotalWarheadHitExercise
        {
            get => PilotRecordBase.TotalWarheadHit.Exercise.ToString();
            set { PilotRecordBase.TotalWarheadHit.Exercise = SetIntProperty(value); }
        }
        public string TotalWarheadHitMelee
        {
            get => PilotRecordBase.TotalWarheadHit.Melee.ToString();
            set { PilotRecordBase.TotalWarheadHit.Melee = SetIntProperty(value); }
        }
        public string TotalWarheadHitCombatEngagement
        {
            get => PilotRecordBase.TotalWarheadHit.CombatEngagement.ToString();
            set { PilotRecordBase.TotalWarheadHit.CombatEngagement = SetIntProperty(value); }
        }

        // TotalWarheadFired
        public string TotalWarheadFiredExercise
        {
            get => PilotRecordBase.TotalWarheadFired.Exercise.ToString();
            set { PilotRecordBase.TotalWarheadFired.Exercise = SetIntProperty(value); }
        }
        public string TotalWarheadFiredMelee
        {
            get => PilotRecordBase.TotalWarheadFired.Melee.ToString();
            set { PilotRecordBase.TotalWarheadFired.Melee = SetIntProperty(value); }
        }
        public string TotalWarheadFiredCombatEngagement
        {
            get => PilotRecordBase.TotalWarheadFired.CombatEngagement.ToString();
            set { PilotRecordBase.TotalWarheadFired.CombatEngagement = SetIntProperty(value); }
        }

        // TotalCraftLosses
        public string TotalCraftLossesExercise
        {
            get => PilotRecordBase.TotalCraftLosses.Exercise.ToString();
            set { PilotRecordBase.TotalCraftLosses.Exercise = SetIntProperty(value); }
        }
        public string TotalCraftLossesMelee
        {
            get => PilotRecordBase.TotalCraftLosses.Melee.ToString();
            set { PilotRecordBase.TotalCraftLosses.Melee = SetIntProperty(value); }
        }
        public string TotalCraftLossesCombatEngagement
        {
            get => PilotRecordBase.TotalCraftLosses.CombatEngagement.ToString();
            set { PilotRecordBase.TotalCraftLosses.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLossesFromCollisions
        public string TotalLossesFromCollisionsExercise
        {
            get => PilotRecordBase.TotalLossesFromCollisions.Exercise.ToString();
            set { PilotRecordBase.TotalLossesFromCollisions.Exercise = SetIntProperty(value); }
        }
        public string TotalLossesFromCollisionsMelee
        {
            get => PilotRecordBase.TotalLossesFromCollisions.Melee.ToString();
            set { PilotRecordBase.TotalLossesFromCollisions.Melee = SetIntProperty(value); }
        }
        public string TotalLossesFromCollisionsCombatEngagement
        {
            get => PilotRecordBase.TotalLossesFromCollisions.CombatEngagement.ToString();
            set { PilotRecordBase.TotalLossesFromCollisions.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLossesFromStarships
        public string TotalLossesFromStarshipsExercise
        {
            get => PilotRecordBase.TotalLossesFromStarships.Exercise.ToString();
            set { PilotRecordBase.TotalLossesFromStarships.Exercise = SetIntProperty(value); }
        }
        public string TotalLossesFromStarshipsMelee
        {
            get => PilotRecordBase.TotalLossesFromStarships.Melee.ToString();
            set { PilotRecordBase.TotalLossesFromStarships.Melee = SetIntProperty(value); }
        }
        public string TotalLossesFromStarshipsCombatEngagement
        {
            get => PilotRecordBase.TotalLossesFromStarships.CombatEngagement.ToString();
            set { PilotRecordBase.TotalLossesFromStarships.CombatEngagement = SetIntProperty(value); }
        }

        // TotalLossesFromMines
        public string TotalLossesFromMinesExercise
        {
            get => PilotRecordBase.TotalLossesFromMines.Exercise.ToString();
            set { PilotRecordBase.TotalLossesFromMines.Exercise = SetIntProperty(value); }
        }
        public string TotalLossesFromMinesMelee
        {
            get => PilotRecordBase.TotalLossesFromMines.Melee.ToString();
            set { PilotRecordBase.TotalLossesFromMines.Melee = SetIntProperty(value); }
        }
        public string TotalLossesFromMinesCombatEngagement
        {
            get => PilotRecordBase.TotalLossesFromMines.CombatEngagement.ToString();
            set { PilotRecordBase.TotalLossesFromMines.CombatEngagement = SetIntProperty(value); }
        }

        public MissionCategoryRecordMatrixViewModel TotalLossesFromPlayerRank { get; private set; }

        public MissionCategoryRecordMatrixViewModel TotalLossesFromAIRank { get; private set; }

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.

        // Leave this number value as-is; do not convert to a Pilot Rating description.  That is handled by the RankString property.
        public string CurrentRank
        {
            get => PilotRecordBase.CurrentRank.ToString();
            set { PilotRecordBase.CurrentRank = SetUIntProperty(value); }
        }

        public string TotalCountMissionsFlown
        {
            get => PilotRecordBase.TotalCountMissionsFlown.ToString();
            set { PilotRecordBase.TotalCountMissionsFlown = SetIntProperty(value); }
        }

        public IntArrayViewModel RankAchievedOnMissionCount { get; private set; }

        public string RankString
        {
            get => PilotRecordBase.RankString;
            set { PilotRecordBase.RankString = SetStringProperty(value, Constants.PILOT_RATING_NAME_MAX_LENGTH); }
        }

        public string DebriefMissionScore
        {
            get => PilotRecordBase.DebriefMissionScore.ToString();
            set { PilotRecordBase.DebriefMissionScore = SetIntProperty(value); }
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

        public ObservableCollection<TeamResultRecordViewModel> DebriefTeamResult { get; private set; } = new();

        // TODO: Plt-specific properties (i.e., not present in Pl2) are skipped here for now, but will need to be added in the future.
    }
}
