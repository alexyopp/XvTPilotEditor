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

        public MissionCategoryRecordViewModel           TotalCategoryScore                      { get; private set; }
        public MissionCategoryRecordViewModel           NumFlownNonSeries                       { get; private set; }
        public MissionCategoryRecordViewModel           NumFlownSeries                          { get; private set; }
        public MissionCategoryRecordViewModel           TotalKills                              { get; private set; }
        public MissionCategoryRecordViewModel           FriendlyKills                           { get; private set; }
        public MissionCategoryRecordMatrixViewModel     TotalKillsByPlayerRating                { get; private set; }
        public MissionCategoryRecordMatrixViewModel     TotalAssistsByPlayerRating              { get; private set; }
        public MissionCategoryRecordMatrixViewModel     TotalKillsByAIRank                      { get; private set; }
        public MissionCategoryRecordMatrixViewModel     TotalAssistsByAIRank                    { get; private set; }
        public MissionCategoryRecordViewModel           TotalHiddenCargoFound                   { get; private set; }
        public MissionCategoryRecordViewModel           TotalLaserHit                           { get; private set; }
        public MissionCategoryRecordViewModel           TotalLaserFired                         { get; private set; }
        public MissionCategoryRecordViewModel           TotalWarheadHit                         { get; private set; }
        public MissionCategoryRecordViewModel           TotalWarheadFired                       { get; private set; }
        public MissionCategoryRecordViewModel           TotalCraftLosses                        { get; private set; }
        public MissionCategoryRecordViewModel           TotalLossesFromCollisions               { get; private set; }
        public MissionCategoryRecordViewModel           TotalLossesFromStarships                { get; private set; }
        public MissionCategoryRecordViewModel           TotalLossesFromMines                    { get; private set; }

        public MissionCategoryRecordMatrixViewModel TotalLossesByPlayerRating { get; private set; }

        public MissionCategoryRecordMatrixViewModel TotalLossesByAIRank { get; private set; }

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

            TotalCategoryScore              = new MissionCategoryRecordViewModel(PilotRecordBase.TotalCategoryScore);
            NumFlownNonSeries               = new MissionCategoryRecordViewModel(PilotRecordBase.NumFlownNonSeries);
            NumFlownSeries                  = new MissionCategoryRecordViewModel(PilotRecordBase.NumFlownSeries);
            TotalKills                      = new MissionCategoryRecordViewModel(PilotRecordBase.TotalKills);
            FriendlyKills                   = new MissionCategoryRecordViewModel(PilotRecordBase.FriendlyKills);

            TotalKillsByPlayerRating = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalFullKillsByPlayerRating?.Exercise,
                                                                                PilotRecordBase.TotalFullKillsByPlayerRating?.Melee,
                                                                                PilotRecordBase.TotalFullKillsByPlayerRating?.CombatEngagement,
                                                                                PilotRecordBase.TotalSharedKillsByPlayerRating?.Exercise,
                                                                                PilotRecordBase.TotalSharedKillsByPlayerRating?.Melee,
                                                                                PilotRecordBase.TotalSharedKillsByPlayerRating?.CombatEngagement);

            TotalAssistsByPlayerRating = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalAssistsByPlayerRating?.Exercise,
                                                                                  PilotRecordBase.TotalAssistsByPlayerRating?.Melee,
                                                                                  PilotRecordBase.TotalAssistsByPlayerRating?.CombatEngagement);

            TotalKillsByAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalFullKillsByAIRank?.Exercise,
                                                                          PilotRecordBase.TotalFullKillsByAIRank?.Melee,
                                                                          PilotRecordBase.TotalFullKillsByAIRank?.CombatEngagement,
                                                                          PilotRecordBase.TotalSharedKillsByAIRank?.Exercise,
                                                                          PilotRecordBase.TotalSharedKillsByAIRank?.Melee,
                                                                          PilotRecordBase.TotalSharedKillsByAIRank?.CombatEngagement);

            TotalAssistsByAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalAssistsByAIRank?.Exercise,
                                                                            PilotRecordBase.TotalAssistsByAIRank?.Melee,
                                                                            PilotRecordBase.TotalAssistsByAIRank?.CombatEngagement);

            TotalHiddenCargoFound           = new MissionCategoryRecordViewModel(PilotRecordBase.TotalHiddenCargoFound);
            TotalLaserHit                   = new MissionCategoryRecordViewModel(PilotRecordBase.TotalLaserHit);
            TotalLaserFired                 = new MissionCategoryRecordViewModel(PilotRecordBase.TotalLaserFired);
            TotalWarheadHit                 = new MissionCategoryRecordViewModel(PilotRecordBase.TotalWarheadHit);
            TotalWarheadFired               = new MissionCategoryRecordViewModel(PilotRecordBase.TotalWarheadFired);
            TotalCraftLosses                = new MissionCategoryRecordViewModel(PilotRecordBase.TotalCraftLosses);
            TotalLossesFromCollisions       = new MissionCategoryRecordViewModel(PilotRecordBase.TotalLossesFromCollisions);
            TotalLossesFromStarships        = new MissionCategoryRecordViewModel(PilotRecordBase.TotalLossesFromStarships);
            TotalLossesFromMines            = new MissionCategoryRecordViewModel(PilotRecordBase.TotalLossesFromMines);

            TotalLossesByPlayerRating = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalLossesByPlayerRating?.Exercise,
                                                                                 PilotRecordBase.TotalLossesByPlayerRating?.Melee,
                                                                                 PilotRecordBase.TotalLossesByPlayerRating?.CombatEngagement);

            TotalLossesByAIRank = new MissionCategoryRecordMatrixViewModel(PilotRecordBase.TotalLossesByAIRank?.Exercise,
                                                                           PilotRecordBase.TotalLossesByAIRank?.Melee,
                                                                           PilotRecordBase.TotalLossesByAIRank?.CombatEngagement);

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
