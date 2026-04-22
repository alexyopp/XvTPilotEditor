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
        }
    }
}
