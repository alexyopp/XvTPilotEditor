using System;
using static XvTPilotEditor.Models.PilotFileSchema;

namespace XvTPilotEditor.Utilities
{
    public class NotifyingMissionCategoryRecord
    {
        public NotifyingInt Exercise { get; set; }
        public NotifyingInt Melee { get; set; }
        public NotifyingInt CombatEngagement { get; set; }

        public NotifyingMissionCategoryRecord()
        {
            Exercise = new NotifyingInt(0);
            Melee = new NotifyingInt(0);
            CombatEngagement = new NotifyingInt(0);
        }

        public NotifyingMissionCategoryRecord(int exercise, int melee, int combatEngagement)
        {
            Exercise = new NotifyingInt(exercise);
            Melee = new NotifyingInt(melee);
            CombatEngagement = new NotifyingInt(combatEngagement);
        }

        public NotifyingMissionCategoryRecord(int[] missionCategoryRecord)
        {
            if (missionCategoryRecord.Length != Enum.GetNames(typeof(MissionType)).Length)
            {
                throw new ArgumentException("missionCategoryRecord array must have exactly 3 elements.", nameof(missionCategoryRecord));
            }

            Exercise = new NotifyingInt(missionCategoryRecord[(int)MissionType.Exercise]);
            Melee = new NotifyingInt(missionCategoryRecord[(int)MissionType.Melee]);
            CombatEngagement = new NotifyingInt(missionCategoryRecord[(int)MissionType.Combat]);
        }

        public NotifyingMissionCategoryRecord(NotifyingInt exercise, NotifyingInt melee, NotifyingInt combatEngagement)
        {
            Exercise = exercise;
            Melee = melee;
            CombatEngagement = combatEngagement;
        }

        public NotifyingMissionCategoryRecord(NotifyingInt[] missionCategoryRecord)
        {
            if (missionCategoryRecord.Length != Enum.GetNames(typeof(MissionType)).Length)
            {
                throw new ArgumentException("missionCategoryRecord array must have exactly 3 elements.", nameof(missionCategoryRecord));
            }

            Exercise = missionCategoryRecord[(int)MissionType.Exercise];
            Melee = missionCategoryRecord[(int)MissionType.Melee];
            CombatEngagement = missionCategoryRecord[(int)MissionType.Combat];
        }

        public NotifyingMissionCategoryRecord(PLTCategoryTypeRecord missionCategoryRecord)
        {
            Exercise = new NotifyingInt(missionCategoryRecord.exercise);
            Melee = new NotifyingInt(missionCategoryRecord.melee);
            CombatEngagement = new NotifyingInt(missionCategoryRecord.combat);
        }
    }
}
