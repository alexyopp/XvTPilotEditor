using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class MissionHistoryModel
    {
        // Single Missions
        public Dictionary<uint, TrainingResultModel>     Training    { get; }
        public Dictionary<uint, MeleeResultModel>        Melee       { get; }
        public Dictionary<uint, CombatResultModel>       Combat      { get; }

        // Collections
        public Dictionary<uint, TournamentResultModel>   Tournament  { get; }
        public Dictionary<uint, BattleResultModel>       Battle      { get; }
        public Dictionary<uint, CampaignResultModel>     Campaign    { get; }

        public MissionHistoryModel()
        {
            Training = new Dictionary<uint, TrainingResultModel>();
            Melee = new Dictionary<uint, MeleeResultModel>();
            Combat = new Dictionary<uint, CombatResultModel>();

            Tournament = new Dictionary<uint, TournamentResultModel>();
            Battle = new Dictionary<uint, BattleResultModel>();
            Campaign = new Dictionary<uint, CampaignResultModel>();
        }
    }
}
