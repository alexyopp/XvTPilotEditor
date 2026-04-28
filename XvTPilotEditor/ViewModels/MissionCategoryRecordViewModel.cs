using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public sealed class MissionCategoryRecordViewModel : PilotDataViewModelBase
    {
        public string Name
        {
            get => name;
        }

        public string Exercise
        {
            get => missionCategoryRecord.Exercise.ToString();
            set { missionCategoryRecord.Exercise = SetIntProperty(value); }
        }

        public string Melee
        {
            get => missionCategoryRecord.Melee.ToString();
            set { missionCategoryRecord.Melee = SetIntProperty(value); }
        }

        public string CombatEngagement
        {
            get => missionCategoryRecord.CombatEngagement.ToString();
            set { missionCategoryRecord.CombatEngagement = SetIntProperty(value); }
        }

        private readonly string name;
        private readonly MissionCategoryRecord missionCategoryRecord;

        public MissionCategoryRecordViewModel(string initName, MissionCategoryRecord initRecord)
        {
            this.name = initName;
            this.missionCategoryRecord = initRecord;
        }
    }
}
