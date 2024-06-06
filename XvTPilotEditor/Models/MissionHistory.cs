using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    class MissionHistory
    {
        public List<TrainingResult>?    Training    { get; set; }
        public List<MeleeResult>?       Melee       { get; set; }
        public List<TournamentResult>?  Tournament  { get; set; }
        public List<CombatResult>?      Combat      { get; set; }
        public List<BattleResult>?      Battle      { get; set; }
        public List<CampaignResult>?    Campaign    { get; set; }
    }
}
