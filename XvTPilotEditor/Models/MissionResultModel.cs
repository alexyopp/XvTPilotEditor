using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace XvTPilotEditor.Models
{
    public class MissionResultBase
    {
        public MissionEvaluation Evaluation { get; set; }
        public string Name                  { get; set; }
        public int BestScore                { get; set; }

        public uint PlayCount               { get; set; }     // TODO: Investigate whether this should be a base property or not
    
        public MissionResultBase()
        {
            Name = string.Empty;
        }
    }

    public class TrainingResultModel : MissionResultBase
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }

    public class MeleeResultModel : MissionResultBase
    {
        public uint BestPlaceFinish { get; set; }
    }

    public class TournamentResultModel : MissionResultBase
    {
        public uint BestPlaceFinish { get; set; }
    }

    public class CombatResultModel : MissionResultBase
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }

    public class BattleResultModel : MissionResultBase
    {
        public uint BestMarginOfVictoryInMissions { get; set; }
    }

    public class CampaignResultModel : MissionResultBase
    {
        //  Campaigns do not have overall evaluations (just per mission results)
        new public MissionEvaluation Evaluation = MissionEvaluation.Empty;

        public uint BestProgressInMissions { get; set; }
        public Dictionary<uint, CampaignMissionResultModel> CampaignHistory { get; set; }

        public CampaignResultModel()
        {
            CampaignHistory = new Dictionary<uint, CampaignMissionResultModel>();
        }
    }

    public class CampaignMissionResultModel : MissionResultBase
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }
}
