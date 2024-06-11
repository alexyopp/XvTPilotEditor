using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class MissionHistory
    {
        // Single Missions
        public Dictionary<uint, TrainingResult>     Training    { get; }
        public Dictionary<uint, MeleeResult>        Melee       { get; }
        public Dictionary<uint, CombatResult>       Combat      { get; }

        // Collections
        public Dictionary<uint, TournamentResult>   Tournament  { get; }
        public Dictionary<uint, BattleResult>       Battle      { get; }
        public Dictionary<uint, CampaignResult>     Campaign    { get; }

        public MissionHistory()
        {
            Training = new Dictionary<uint, TrainingResult>();
            Melee = new Dictionary<uint, MeleeResult>();
            Combat = new Dictionary<uint, CombatResult>();

            Tournament = new Dictionary<uint, TournamentResult>();
            Battle = new Dictionary<uint, BattleResult>();
            Campaign = new Dictionary<uint, CampaignResult>();
        }
    }
}
