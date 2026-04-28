using System.Collections.ObjectModel;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public class PilotRecordBaseViewModel : PilotDataViewModelBase
    {
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

        public MissionCategoryRecordViewModel TotalCategoryScore { get; private set; }

        public MissionCategoryRecordViewModel NumFlownNonSeries { get; private set; }

        public MissionCategoryRecordViewModel NumFlownSeries { get; private set; }

        public MissionCategoryRecordViewModel TotalKills { get; private set; }

        public MissionCategoryRecordViewModel FriendlyKills { get; private set; }

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

        public MissionCategoryRecordViewModel TotalHiddenCargoFound { get; private set; }

        public MissionCategoryRecordViewModel TotalLaserHit { get; private set; }

        public MissionCategoryRecordViewModel TotalLaserFired { get; private set; }

        public MissionCategoryRecordViewModel TotalWarheadHit { get; private set; }

        public MissionCategoryRecordViewModel TotalWarheadFired { get; private set; }

        public MissionCategoryRecordViewModel TotalCraftLosses { get; private set; }

        public MissionCategoryRecordViewModel TotalLossesFromCollisions { get; private set; }

        public MissionCategoryRecordViewModel TotalLossesFromStarships { get; private set; }

        public MissionCategoryRecordViewModel TotalLossesFromMines { get; private set; }

        public MissionCategoryRecordMatrixViewModel TotalLossesFromPlayerRank { get; private set; }

        public MissionCategoryRecordMatrixViewModel TotalLossesFromAIRank { get; private set; }

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

        public ObservableCollection<ConnectedPlayerRecordViewModel> ConnectedPlayer { get; private set; } = new();

        public ObservableCollection<TeamResultRecordViewModel> DebriefTeamResult { get; private set; } = new();

        protected PilotRecordBase PilotRecordBase;

        public PilotRecordBaseViewModel(PilotRecordBase initPilotRecordBase)
        {
            this.PilotRecordBase = initPilotRecordBase;

            Unknown0x26 = new IntArrayViewModel(PilotRecordBase.Unknown0x26);
            Unknown0x166 = new IntArrayViewModel(PilotRecordBase.Unknown0x166);
            Unknown0x186 = new IntArrayViewModel(PilotRecordBase.Unknown0x186);

            TotalCategoryScore = new MissionCategoryRecordViewModel("Total Category Score", PilotRecordBase.TotalCategoryScore);

            NumFlownNonSeries = new MissionCategoryRecordViewModel("Num Flown Non-Series", PilotRecordBase.NumFlownNonSeries);

            NumFlownSeries = new MissionCategoryRecordViewModel("Num Flown Series", PilotRecordBase.NumFlownSeries);

            TotalKills = new MissionCategoryRecordViewModel("Total Kills", PilotRecordBase.TotalKills);

            FriendlyKills = new MissionCategoryRecordViewModel("Friendly Kills", PilotRecordBase.FriendlyKills);

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

            TotalHiddenCargoFound = new MissionCategoryRecordViewModel("Total Hidden Cargo Found", PilotRecordBase.TotalHiddenCargoFound);

            TotalLaserHit = new MissionCategoryRecordViewModel("Total Laser Hit", PilotRecordBase.TotalLaserHit);

            TotalLaserFired = new MissionCategoryRecordViewModel("Total Laser Fired", PilotRecordBase.TotalLaserFired);

            TotalWarheadHit = new MissionCategoryRecordViewModel("Total Warhead Hit", PilotRecordBase.TotalWarheadHit);

            TotalWarheadFired = new MissionCategoryRecordViewModel("Total Warhead Fired", PilotRecordBase.TotalWarheadFired);

            TotalCraftLosses = new MissionCategoryRecordViewModel("Total Craft Losses", PilotRecordBase.TotalCraftLosses);

            TotalLossesFromCollisions = new MissionCategoryRecordViewModel("Total Losses From Collisions", PilotRecordBase.TotalLossesFromCollisions);

            TotalLossesFromStarships = new MissionCategoryRecordViewModel("Total Losses From Starships", PilotRecordBase.TotalLossesFromStarships);

            TotalLossesFromMines = new MissionCategoryRecordViewModel("Total Losses From Mines", PilotRecordBase.TotalLossesFromMines);

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
    }
}
