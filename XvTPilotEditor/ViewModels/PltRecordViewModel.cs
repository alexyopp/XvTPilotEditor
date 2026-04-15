using System.Collections.ObjectModel;
using System.Text;
using XvTPilotEditor.Models;
using XvTPilotEditor.Utilities;

namespace XvTPilotEditor.ViewModels
{
    public sealed class PltRecordViewModel : PilotRecordBaseViewModel
    {
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
        public string Unknown0x2F8
        {
            get => Encoding.UTF8.GetString(PltRecord.Unknown0x2F8);
            set { PltRecord.Unknown0x2F8 = Encoding.UTF8.GetBytes(value); }
        }

        public string GameNameString2
        {
            get => PltRecord.GameNameString2;
            set { PltRecord.GameNameString2 = SetStringProperty(value, Constants.PLT_GAME_NAME_MAX_LENGTH); }
        }

        // TODO: This appears to be padding, in which case we don't want to provide UI for it.
        public string Unknown0x318
        {
            get => Encoding.UTF8.GetString(PltRecord.Unknown0x318);
            set { PltRecord.Unknown0x318 = Encoding.UTF8.GetBytes(value); }
        }

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

        private PltRecord PltRecord;

        public PltRecordViewModel(PltRecord initPltRecord) : base(initPltRecord)
        {
            this.PltRecord = initPltRecord;

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
        }
    }
}
