using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    class MissionHistory
    {
        public List<TrainingMissionResult>? Training    { get; set; }
        public List<MeleeMissionResult>?    Melee       { get; set; }
        public List<TournamentResult>?      Tournament  { get; set; }
        public List<CombatMissionResult>?   Combat      { get; set; }
        public List<BattleResult>?          Battle      { get; set; }
        public List<CampaignResult>?        Campaign    { get; set; }
    }
}
