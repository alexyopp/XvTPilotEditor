using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class MissionResult
    {
        public MissionEvaluation Evaluation { get; set; }
        public string? Name                 { get; set; }
        public int BestScore                { get; set; }

        public uint PlayCount               { get; set; }     // TODO: Investigate whether this should be a base property or not
    }

    public class TrainingResult : MissionResult
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }

    public class MeleeResult : MissionResult
    {
        public uint BestPlaceFinish { get; set; }
    }

    public class TournamentResult : MissionResult
    {
        public uint BestPlaceFinish { get; set; }
    }

    public class CombatResult : MissionResult
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }

    public class BattleResult : MissionResult
    {
        public uint BestMarginOfVictoryInMissions { get; set; }
    }

    public class CampaignResult : MissionResult
    {
        //  Campaigns do not have overall evaluations (just per mission results)
        new public MissionEvaluation Evaluation = MissionEvaluation.Empty;

        public uint BestProgressInMissions { get; set; }
        public Dictionary<uint, CampaignMissionResult> CampaignHistory { get; set; }

        public CampaignResult()
        {
            CampaignHistory = new Dictionary<uint, CampaignMissionResult>();
        }
    }

    public class CampaignMissionResult : MissionResult
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }
}
