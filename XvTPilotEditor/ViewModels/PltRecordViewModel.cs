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

        public MissionCategoryRecordMatrixViewModel     TotalKillsByCraft                       { get; private set; }
        public MissionCategoryRecordMatrixViewModel     TotalAssistsByCraft                     { get; private set; }

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

        public MissionCategoryRecordViewModel           UnknownRecord1                          { get; private set; }
        public MissionCategoryRecordViewModel           UnknownRecord2                          { get; private set; }
        public MissionCategoryRecordViewModel           UnknownRecord3                          { get; private set; }
        public MissionCategoryRecordViewModel           DebriefEnemyKills                       { get; private set; }
        public MissionCategoryRecordViewModel           DebriefFriendlyKills                    { get; private set; }

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

        public MissionCategoryRecordMatrixViewModel DebriefKillsByPlayerRating { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefAssistByPlayerRating { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefKillsByAIRank { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefAssistsByAIRank { get; private set; }

        public MissionCategoryRecordViewModel           DebriefNumHiddenCargoFound              { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumLaserHit                      { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumLaserFired                    { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumWarheadHit                    { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumWarheadFired                  { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumCraftLosses                   { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumLossesFromCollisions          { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumLossesFromStarships           { get; private set; }
        public MissionCategoryRecordViewModel           DebriefNumLossesFromMines               { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefLossesByPlayerRating { get; private set; }

        public MissionCategoryRecordMatrixViewModel DebriefLossesByAIRank { get; private set; }

        //**** Members
        private PltRecord PltRecord;

        public PltRecordViewModel(PltRecord initPltRecord) : base(initPltRecord)
        {
            this.PltRecord = initPltRecord;

            Unknown0x2F8 = new ByteArrayViewModel(PltRecord.Unknown0x2F8);
            Unknown0x318 = new ByteArrayViewModel(PltRecord.Unknown0x318);

            TotalKillsByCraft = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalFullKillsByCraftExercise,
                                                                         PltRecord.TotalFullKillsByCraftMelee,
                                                                         PltRecord.TotalFullKillsByCraftCombat,
                                                                         PltRecord.TotalSharedKillsByCraftExercise,
                                                                         PltRecord.TotalSharedKillsByCraftMelee,
                                                                         PltRecord.TotalSharedKillsByCraftCombat);

            TotalAssistsByCraft = new MissionCategoryRecordMatrixViewModel(PltRecord.TotalAssistsByCraftExercise,
                                                                           PltRecord.TotalAssistsByCraftMelee,
                                                                           PltRecord.TotalAssistsByCraftCombat);

            Unknown0x1612 = new ByteArrayViewModel(PltRecord.Unknown0x1612);

            foreach (var tournamentTeamRecord in PltRecord.TournamentTeamRecord)
            {
                TournamentTeamRecord.Add(new TournamentTeamRecordViewModel(tournamentTeamRecord));
            }

            Unknown0x171A = new ByteArrayViewModel(PltRecord.Unknown0x171A);

            BattleCombatMissionID = new IntArrayViewModel(PltRecord.BattleCombatMissionID);

            UnknownRecord1                  = new MissionCategoryRecordViewModel(PltRecord.UnknownRecord1);
            UnknownRecord2                  = new MissionCategoryRecordViewModel(PltRecord.UnknownRecord2);
            UnknownRecord3                  = new MissionCategoryRecordViewModel(PltRecord.UnknownRecord3);
            DebriefEnemyKills               = new MissionCategoryRecordViewModel(PltRecord.DebriefEnemyKills);
            DebriefFriendlyKills            = new MissionCategoryRecordViewModel(PltRecord.DebriefFriendlyKills);

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

            DebriefKillsByPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefFullKillsByPlayerRating?.Exercise,
                                                                                  PltRecord.DebriefFullKillsByPlayerRating?.Melee,
                                                                                  PltRecord.DebriefFullKillsByPlayerRating?.CombatEngagement,
                                                                                  PltRecord.DebriefSharedKillsByPlayerRating?.Exercise,
                                                                                  PltRecord.DebriefSharedKillsByPlayerRating?.Melee,
                                                                                  PltRecord.DebriefSharedKillsByPlayerRating?.CombatEngagement);

            DebriefAssistByPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefAssistByPlayerRating?.Exercise,
                                                                                   PltRecord.DebriefAssistByPlayerRating?.Melee,
                                                                                   PltRecord.DebriefAssistByPlayerRating?.CombatEngagement);

            DebriefKillsByAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefFullKillsByAIRank?.Exercise,
                                                                            PltRecord.DebriefFullKillsByAIRank?.Melee,
                                                                            PltRecord.DebriefFullKillsByAIRank?.CombatEngagement,
                                                                            PltRecord.DebriefSharedKillsByAIRank?.Exercise,
                                                                            PltRecord.DebriefSharedKillsByAIRank?.Melee,
                                                                            PltRecord.DebriefSharedKillsByAIRank?.CombatEngagement);

            DebriefAssistsByAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefAssistsByAIRank?.Exercise,
                                                                              PltRecord.DebriefAssistsByAIRank?.Melee,
                                                                              PltRecord.DebriefAssistsByAIRank?.CombatEngagement);

            DebriefNumHiddenCargoFound      = new MissionCategoryRecordViewModel(PltRecord.DebriefNumHiddenCargoFound);
            DebriefNumLaserHit              = new MissionCategoryRecordViewModel(PltRecord.DebriefNumLaserHit);
            DebriefNumLaserFired            = new MissionCategoryRecordViewModel(PltRecord.DebriefNumLaserFired);
            DebriefNumWarheadHit            = new MissionCategoryRecordViewModel(PltRecord.DebriefNumWarheadHit);
            DebriefNumWarheadFired          = new MissionCategoryRecordViewModel(PltRecord.DebriefNumWarheadFired);
            DebriefNumCraftLosses           = new MissionCategoryRecordViewModel(PltRecord.DebriefNumCraftLosses);
            DebriefNumLossesFromCollisions  = new MissionCategoryRecordViewModel(PltRecord.DebriefNumLossesFromCollisions);
            DebriefNumLossesFromStarships   = new MissionCategoryRecordViewModel(PltRecord.DebriefNumLossesFromStarships);
            DebriefNumLossesFromMines       = new MissionCategoryRecordViewModel(PltRecord.DebriefNumLossesFromMines);

            DebriefLossesByPlayerRating = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefLossesByPlayerRating?.Exercise,
                                                                                   PltRecord.DebriefLossesByPlayerRating?.Melee,
                                                                                   PltRecord.DebriefLossesByPlayerRating?.CombatEngagement);

            DebriefLossesByAIRank = new MissionCategoryRecordMatrixViewModel(PltRecord.DebriefLossesByAIRank?.Exercise,
                                                                             PltRecord.DebriefLossesByAIRank?.Melee,
                                                                             PltRecord.DebriefLossesByAIRank?.CombatEngagement);
        }
    }
}
