using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    class MissionResult
    {
        public MissionEvaluation Evaluation { get; set; }
        public string? Name                 { get; set; }
        public int BestScore                { get; set; }

        public uint PlayCount               { get; set; }     // TODO: Investigate whether this should be a base property or not
    }

    class TrainingResult : MissionResult
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }

    class MeleeResult : MissionResult
    {
        public uint BestPlaceFinish { get; set; }
    }

    class TournamentResult : MissionResult
    {
        public uint BestPlaceFinish { get; set; }
    }

    class CombatResult : MissionResult
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }

    class BattleResult : MissionResult
    {
        public uint BestMarginOfVictoryInMissions { get; set; }
    }

    class CampaignResult : MissionResult
    {
        //  Campaigns do not have overall evaluations (just per mission results)
        new public MissionEvaluation Evaluation = MissionEvaluation.Empty;

        public uint BestProgressInMissions { get; set; }
        public List<CampaignMissionResult>? CampaignHistory { get; set; }
    }

    class CampaignMissionResult : MissionResult
    {
        public uint BestCompletionTimeInSeconds { get; set; }
    }
}
