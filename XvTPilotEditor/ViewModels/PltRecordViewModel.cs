using System.Collections.ObjectModel;
using System.Text;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public sealed class PltRecordViewModel : PilotRecordBaseViewModel
    {
        //**** Properties
        public string LastTeamNumber
        {
            get => PltRecord.LastTeamNumber.ToString();
            set { PltRecord.LastTeamNumber = SetIntProperty(value); }
        }

        public string LastSelectedMissionType
        {
            get => PltRecord.LastSelectedMissionType.ToString();
            set { PltRecord.LastSelectedMissionType = SetIntProperty(value); }
        }

        public string LastSelectedTraining
        {
            get => PltRecord.LastSelectedTraining.ToString();
            set { PltRecord.LastSelectedTraining = SetIntProperty(value); }
        }

        public string LastSelectedMelee
        {
            get => PltRecord.LastSelectedMelee.ToString();
            set { PltRecord.LastSelectedMelee = SetIntProperty(value); }
        }

        public string LastSelectedTournament
        {
            get => PltRecord.LastSelectedTournament.ToString();
            set { PltRecord.LastSelectedTournament = SetIntProperty(value); }
        }

        public string LastSelectedCombat
        {
            get => PltRecord.LastSelectedCombat.ToString();
            set { PltRecord.LastSelectedCombat = SetIntProperty(value); }
        }

        public string LastSelectedBattle
        {
            get => PltRecord.LastSelectedBattle.ToString();
            set { PltRecord.LastSelectedBattle = SetIntProperty(value); }
        }

        public string GameNameString
        {
            get => PltRecord.GameNameString;
            set { PltRecord.GameNameString = SetStringProperty(value, Constants.PLT_GAME_NAME_MAX_LENGTH); }
        }

        // TODO: This appears to be padding, in which case we don't want to provide UI for it.
        public ByteArrayViewModel Unknown0x2F8 { get; private set; }

        public string GameNameString2
        {
            get => PltRecord.GameNameString2;
            set { PltRecord.GameNameString2 = SetStringProperty(value, Constants.PLT_GAME_NAME_MAX_LENGTH); }
        }

        // TODO: This appears to be padding, in which case we don't want to provide UI for it.
        public ByteArrayViewModel Unknown0x318 { get; private set; }

        // TODO: What does this mean?
        public string LastMissionWasNonSpecific
        {
            get => PltRecord.LastMissionWasNonSpecific.ToString();
            set { PltRecord.LastMissionWasNonSpecific = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string Unknown0x326
        {
            get => PltRecord.Unknown0x326.ToString();
            set { PltRecord.Unknown0x326 = SetIntProperty(value); }
        }

        private MissionCategoryRecordMatrixViewModel TotalCraftFullKills;
        private MissionCategoryRecordMatrixViewModel TotalCraftSharedKills;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedCraftKillsExercise { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedCraftKillsMelee { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedCraftKillsCombat { get; private set; } = new();

        // TODO: Consider renaming "...Assists" instead of "...AssistKills"
        public MissionCategoryRecordMatrixViewModel TotalCraftAssistKills { get; private set; }

        // TODO: This appears to be padding, in which case we don't want to provide UI for it.
        public ByteArrayViewModel Unknown0x1612 { get; private set; }

        // TODO: What is this?
        public string UnknownPlaqueWon
        {
            get => PltRecord.UnknownPlaqueWon.ToString();
            set { PltRecord.UnknownPlaqueWon = SetIntProperty(value); }
        }

        public ObservableCollection<TournamentTeamRecordViewModel> TournamentTeamRecord { get; private set; } = new();

        // TODO: What is this?
        public string NumHumanPlayersUNK
        {
            get => PltRecord.NumHumanPlayersUNK.ToString();
            set { PltRecord.NumHumanPlayersUNK = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string NumTeamsUNK
        {
            get => PltRecord.NumTeamsUNK.ToString();
            set { PltRecord.NumTeamsUNK = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string Unknown0x170E
        {
            get => PltRecord.Unknown0x170E.ToString();
            set { PltRecord.Unknown0x170E = SetIntProperty(value); }
        }

        // TODO: What is this?
        public string Unknown0x1712
        {
            get => PltRecord.Unknown0x1712.ToString();
            set { PltRecord.Unknown0x1712 = SetIntProperty(value); }
        }

        public string NumCombatFlownInLastBattle
        {
            get => PltRecord.NumCombatFlownInLastBattle.ToString();
            set { PltRecord.NumCombatFlownInLastBattle = SetIntProperty(value); }
        }

        // TODO: This is to big to be padding, maybe data for cut content?  Regardless, probably don't want to provide UI for it anyway.
        public ByteArrayViewModel Unknown0x171A { get; private set; }

        public IntArrayViewModel BattleCombatMissionID { get; private set; }

        // TODO: This is to big to be padding, maybe data for cut content?  Regardless, probably don't want to provide UI for it anyway.
        public ByteArrayViewModel Unknown0x1F2E { get; private set; }

        public string TotalScoreForCurrentBattleUNK
        {
            get => PltRecord.TotalScoreForCurrentBattleUNK.ToString();
            set { PltRecord.TotalScoreForCurrentBattleUNK = SetIntProperty(value); }
        }

        public MissionCategoryRecordViewModel UnknownRecord1 { get; private set; }

        public MissionCategoryRecordViewModel UnknownRecord2 { get; private set; }

        public MissionCategoryRecordViewModel UnknownRecord3 { get; private set; }

        public MissionCategoryRecordViewModel DebriefEnemyKills { get; private set; }

        public MissionCategoryRecordViewModel DebriefFriendlyKills { get; private set; }

        private IntArrayViewModel DebriefFullKillsByShipTypeA;
        private IntArrayViewModel DebriefSharedKillsByShipTypeA;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsByShipTypeA { get; private set; } = new();

        private IntArrayViewModel DebriefFullKillsByShipTypeB;
        private IntArrayViewModel DebriefSharedKillsByShipTypeB;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsByShipTypeB { get; private set; } = new();

        private IntArrayViewModel DebriefFullKillsByShipTypeC;
        private IntArrayViewModel DebriefSharedKillsByShipTypeC;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsByShipTypeC { get; private set; } = new();

        public IntArrayViewModel DebriefAssistKillsByShipTypeA { get; private set; }

        public IntArrayViewModel DebriefAssistKillsByShipTypeB { get; private set; }

        public IntArrayViewModel DebriefAssistKillsByShipTypeC { get; private set; }

        private MissionCategoryRecordMatrixViewModel DebriefFullKillsOnPlayerRank;
        private MissionCategoryRecordMatrixViewModel DebriefSharedKillsOnPlayerRank;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnPlayerRatingExercise { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnPlayerRatingMelee { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnPlayerRatingCombat { get; private set; } = new();

        public MissionCategoryRecordMatrixViewModel DebriefAssistKillsOnPlayerRank { get; private set; }

        private MissionCategoryRecordMatrixViewModel DebriefFullKillsOnAIRank;
        private MissionCategoryRecordMatrixViewModel DebriefSharedKillsOnAIRank;
        // Combined collections for UI (Full + Shared pairs)
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnAIRankExercise { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnAIRankMelee { get; private set; } = new();
        public ObservableCollection<KillPairViewModel> CombinedDebriefKillsOnAIRankCombat { get; private set; } = new();

        public MissionCategoryRecordMatrixViewModel DebriefAssistKillsOnAIRank { get; private set; }

        public MissionCategoryRecordViewModel DebriefNumHiddenCargoFound { get; private set; }

        public MissionCategoryRecordViewModel DebriefNumCannonHits { get; private set; }

        public MissionCategoryRecordViewModel DebriefNumCannonFired { get; private set; }

        public MissionCategoryRecordViewModel DebriefNumWarheadHits { get; private set; }

        public MissionCategoryRecordViewModel DebriefNumWarheadFired { get; private set; }

        public MissionCategoryRecordViewModel DebriefNumCraftLosses { get; private set; }

        public MissionCategoryRecordViewModel DebriefCraftLossesFromCollision { get; private set; }

        public MissionCategoryRecordViewModel DebriefCraftLossesFromStarship { get; private set; }

        public MissionCategoryRecordViewModel DebriefCraftLossesFromMine { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefLossesFromPlayerRank { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefLossesFromAIRank { get; private set; }

        //**** Members
        private PltRecord PltRecord;

        public PltRecordViewModel(PltRecord initPltRecord) : base(initPltRecord)
        {
            this.PltRecord = initPltRecord;

            Unknown0x2F8 = new ByteArrayViewModel(PltRecord.Unknown0x2F8);
            Unknown0x318 = new ByteArrayViewModel(PltRecord.Unknown0x318);

            TotalCraftFullKills = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalCraftFullKillsExercise,
                                                                           PltRecord.TotalCraftFullKillsMelee,
                                                                           PltRecord.TotalCraftFullKillsCombat);
            TotalCraftSharedKills = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalCraftSharedKillsExercise,
                                                                             PltRecord.TotalCraftSharedKillsMelee,
                                                                             PltRecord.TotalCraftSharedKillsCombat);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedCraftKillsExercise = CollectionHelpers.Combine(TotalCraftFullKills.Exercise, TotalCraftSharedKills.Exercise);
            CombinedCraftKillsMelee = CollectionHelpers.Combine(TotalCraftFullKills.Melee, TotalCraftSharedKills.Melee);
            CombinedCraftKillsCombat = CollectionHelpers.Combine(TotalCraftFullKills.Combat, TotalCraftSharedKills.Combat);

            TotalCraftAssistKills = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalCraftAssistKillsExercise,
                                                                             PltRecord.TotalCraftAssistKillsMelee,
                                                                             PltRecord.TotalCraftAssistKillsCombat);

            Unknown0x1612 = new ByteArrayViewModel(PltRecord.Unknown0x1612);

            foreach (var tournamentTeamRecord in PltRecord.TournamentTeamRecord)
            {
                TournamentTeamRecord.Add(new TournamentTeamRecordViewModel(tournamentTeamRecord));
            }

            Unknown0x171A = new ByteArrayViewModel(PltRecord.Unknown0x171A);

            BattleCombatMissionID = new IntArrayViewModel(PltRecord.BattleCombatMissionID);

            UnknownRecord1 = new MissionCategoryRecordViewModel("UnknownRecord1", PltRecord.UnknownRecord1);
            UnknownRecord2 = new MissionCategoryRecordViewModel("UnknownRecord2", PltRecord.UnknownRecord2);
            UnknownRecord3 = new MissionCategoryRecordViewModel("UnknownRecord3", PltRecord.UnknownRecord3);
            DebriefEnemyKills = new MissionCategoryRecordViewModel("Debrief Enemy Kills", PltRecord.DebriefEnemyKills);
            DebriefFriendlyKills = new MissionCategoryRecordViewModel("Debrief Friendly Kills", PltRecord.DebriefFriendlyKills);

            Unknown0x1F2E = new ByteArrayViewModel(PltRecord.Unknown0x1F2E);

            DebriefFullKillsByShipTypeA = new IntArrayViewModel(PltRecord.DebriefFullKillsByShipTypeA);
            DebriefSharedKillsByShipTypeA = new IntArrayViewModel(PltRecord.DebriefSharedKillsByShipTypeA);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByShipTypeA = CollectionHelpers.Combine(DebriefFullKillsByShipTypeA.Values, DebriefSharedKillsByShipTypeA.Values);

            DebriefFullKillsByShipTypeB = new IntArrayViewModel(PltRecord.DebriefFullKillsByShipTypeB);
            DebriefSharedKillsByShipTypeB = new IntArrayViewModel(PltRecord.DebriefSharedKillsByShipTypeB);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByShipTypeB = CollectionHelpers.Combine(DebriefFullKillsByShipTypeB.Values, DebriefSharedKillsByShipTypeB.Values);

            DebriefFullKillsByShipTypeC = new IntArrayViewModel(PltRecord.DebriefFullKillsByShipTypeC);
            DebriefSharedKillsByShipTypeC = new IntArrayViewModel(PltRecord.DebriefSharedKillsByShipTypeC);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsByShipTypeC = CollectionHelpers.Combine(DebriefFullKillsByShipTypeC.Values, DebriefSharedKillsByShipTypeC.Values);

            DebriefAssistKillsByShipTypeA = new IntArrayViewModel(PltRecord.DebriefAssistKillsByShipTypeA);

            DebriefAssistKillsByShipTypeB = new IntArrayViewModel(PltRecord.DebriefAssistKillsByShipTypeB);

            DebriefAssistKillsByShipTypeC = new IntArrayViewModel(PltRecord.DebriefAssistKillsByShipTypeC);

            DebriefFullKillsOnPlayerRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefFullKillsOnPlayerRank?.Exercise,
                                                                                    PltRecord.DebriefFullKillsOnPlayerRank?.Melee,
                                                                                    PltRecord.DebriefFullKillsOnPlayerRank?.CombatEngagement);
            DebriefSharedKillsOnPlayerRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefSharedKillsOnPlayerRank?.Exercise,
                                                                                      PltRecord.DebriefSharedKillsOnPlayerRank?.Melee,
                                                                                      PltRecord.DebriefSharedKillsOnPlayerRank?.CombatEngagement);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsOnPlayerRatingExercise = CollectionHelpers.Combine(DebriefFullKillsOnPlayerRank.Exercise, DebriefSharedKillsOnPlayerRank.Exercise);
            CombinedDebriefKillsOnPlayerRatingMelee = CollectionHelpers.Combine(DebriefFullKillsOnPlayerRank.Melee, DebriefSharedKillsOnPlayerRank.Melee);
            CombinedDebriefKillsOnPlayerRatingCombat = CollectionHelpers.Combine(DebriefFullKillsOnPlayerRank.Combat, DebriefSharedKillsOnPlayerRank.Combat);

            DebriefAssistKillsOnPlayerRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefAssistKillsOnPlayerRank?.Exercise,
                                                                                      PltRecord.DebriefAssistKillsOnPlayerRank?.Melee,
                                                                                      PltRecord.DebriefAssistKillsOnPlayerRank?.CombatEngagement);

            DebriefFullKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefFullKillsOnAIRank?.Exercise,
                                                                                PltRecord.DebriefFullKillsOnAIRank?.Melee,
                                                                                PltRecord.DebriefFullKillsOnAIRank?.CombatEngagement);
            DebriefSharedKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefSharedKillsOnAIRank?.Exercise,
                                                                                  PltRecord.DebriefSharedKillsOnAIRank?.Melee,
                                                                                  PltRecord.DebriefSharedKillsOnAIRank?.CombatEngagement);
            // Build combined collections (Full + Shared) so columns can render both values aligned by index.
            CombinedDebriefKillsOnAIRankExercise = CollectionHelpers.Combine(DebriefFullKillsOnAIRank.Exercise, DebriefSharedKillsOnAIRank.Exercise);
            CombinedDebriefKillsOnAIRankMelee = CollectionHelpers.Combine(DebriefFullKillsOnAIRank.Melee, DebriefSharedKillsOnAIRank.Melee);
            CombinedDebriefKillsOnAIRankCombat = CollectionHelpers.Combine(DebriefFullKillsOnAIRank.Combat, DebriefSharedKillsOnAIRank.Combat);

            DebriefAssistKillsOnAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefAssistKillsOnAIRank?.Exercise,
                                                                                  PltRecord.DebriefAssistKillsOnAIRank?.Melee,
                                                                                  PltRecord.DebriefAssistKillsOnAIRank?.CombatEngagement);

            DebriefNumHiddenCargoFound = new MissionCategoryRecordViewModel("Debrief Hidden Cargo Found", PltRecord.DebriefNumHiddenCargoFound);

            DebriefNumCannonHits = new MissionCategoryRecordViewModel("Debrief Cannon Hits", PltRecord.DebriefNumCannonHits);

            DebriefNumCannonFired = new MissionCategoryRecordViewModel("Debrief Cannon Fired", PltRecord.DebriefNumCannonFired);

            DebriefNumWarheadHits = new MissionCategoryRecordViewModel("Debrief Warhead Hits", PltRecord.DebriefNumWarheadHits);

            DebriefNumWarheadFired = new MissionCategoryRecordViewModel("Debrief Warhead Fired", PltRecord.DebriefNumWarheadFired);

            DebriefNumCraftLosses = new MissionCategoryRecordViewModel("Debrief Craft Losses", PltRecord.DebriefNumCraftLosses);

            DebriefCraftLossesFromCollision = new MissionCategoryRecordViewModel("Debrief Craft Losses From Collisions", PltRecord.DebriefCraftLossesFromCollision);

            DebriefCraftLossesFromStarship = new MissionCategoryRecordViewModel("Debrief Craft Losses From Starships", PltRecord.DebriefCraftLossesFromStarship);

            DebriefCraftLossesFromMine = new MissionCategoryRecordViewModel("Debrief Craft Losses From Mines", PltRecord.DebriefCraftLossesFromMine);

            DebriefLossesFromPlayerRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefLossesFromPlayerRank?.Exercise,
                                                                                   PltRecord.DebriefLossesFromPlayerRank?.Melee,
                                                                                   PltRecord.DebriefLossesFromPlayerRank?.CombatEngagement);

            DebriefLossesFromAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefLossesFromAIRank?.Exercise,
                                                                               PltRecord.DebriefLossesFromAIRank?.Melee,
                                                                               PltRecord.DebriefLossesFromAIRank?.CombatEngagement);
        }
    }
}
