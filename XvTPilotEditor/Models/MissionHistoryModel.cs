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

            // TODO: Mockup of data for development purposes.  Removed once real data is available.
            TrainingResultModel TMission1 = new TrainingResultModel
            {
                Evaluation = MissionEvaluation.Bad,
                Name = "Test Training Mission 1",
                BestScore = 1000,
                PlayCount = 1,
                BestCompletionTimeInSeconds = 84
            };

            TrainingResultModel TMission2 = new TrainingResultModel
            {
                Evaluation = MissionEvaluation.Good,
                Name = "Test Training Mission 2",
                BestScore = 2000,
                PlayCount = 34,
                BestCompletionTimeInSeconds = 300
            };

            Training.Add(0, TMission1);
            Training.Add(1, TMission2);

            MeleeResultModel MMission1 = new MeleeResultModel
            {
                Evaluation = MissionEvaluation.Bad,
                Name = "Test Melee Mission 1",
                BestScore = 1000,
                PlayCount = 1,
                BestPlaceFinish = 3
            };

            MeleeResultModel MMission2 = new MeleeResultModel
            {
                Evaluation = MissionEvaluation.Good,
                Name = "Test Melee Mission 2",
                BestScore = 2000,
                PlayCount = 34,
                BestPlaceFinish = 10
            };

            Melee.Add(0, MMission1);
            Melee.Add(1, MMission2);

            CombatResultModel CMission1 = new CombatResultModel
            {
                Evaluation = MissionEvaluation.Bad,
                Name = "Test Combat Mission 1",
                BestScore = 1234,
                PlayCount = 12,
                BestCompletionTimeInSeconds = 670
            };

            CombatResultModel CMission2 = new CombatResultModel
            {
                Evaluation = MissionEvaluation.Good,
                Name = "Test Combat Mission 2",
                BestScore = 8765,
                PlayCount = 31,
                BestCompletionTimeInSeconds = 1000
            };

            Combat.Add(0, CMission1);
            Combat.Add(1, CMission2);
        }
    }
}
