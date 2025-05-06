using System.Collections.Generic;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class MissionAchievementsViewModel : PageViewModel
    {
        public class MissionData
        {
            public MissionEvaluation Evaluation { get; set; }
            public string Name                  { get; set; }
            public int Score                    { get; set; }
            public uint PlayCount               { get; set; }
            public uint Finish                  { get; set; }

            public MissionData(MissionEvaluation evaluation, string name, int score, uint playCount, uint finish)
            {
                this.Evaluation = evaluation;
                this.Name = name;
                this.Score = score;
                this.PlayCount = playCount;
                this.Finish = finish;
            }
        }

        private Dictionary<uint, MissionData> singleplayerTrainingMissionData;
        public Dictionary<uint, MissionData> SingleplayerTrainingMissionData
        {
            get => singleplayerTrainingMissionData;
        }

        public Dictionary<uint, MissionData> MultiplayerTrainingMissionData;

        public Dictionary<uint, MissionData> SingleplayerMeleeMissionData;
        public Dictionary<uint, MissionData> MultiplayerMeleeMissionData;

        public Dictionary<uint, MissionData> SingleplayerCombatMissionData;
        public Dictionary<uint, MissionData> MultiplayerCombatMissionData;

        private PilotModel activePilotModel;
        private Faction activeFaction;

        internal MissionAchievementsViewModel(PilotModel pilotModel)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = Faction.Rebel;

            singleplayerTrainingMissionData = new Dictionary<uint, MissionData>();
            foreach (var item in activePilotModel.Faction[activeFaction].MissionHistory[GameMode.Singleplayer].Training)
            {
                singleplayerTrainingMissionData.Add(
                    item.Key,
                    new MissionData(
                        item.Value.Evaluation,
                        item.Value.Name,
                        item.Value.BestScore,
                        item.Value.PlayCount,
                        item.Value.BestCompletionTimeInSeconds));
            }

            MultiplayerTrainingMissionData = new Dictionary<uint, MissionData>();
            foreach (var item in activePilotModel.Faction[activeFaction].MissionHistory[GameMode.Multiplayer].Training)
            {
                MultiplayerTrainingMissionData.Add(
                    item.Key,
                    new MissionData(
                        item.Value.Evaluation,
                        item.Value.Name,
                        item.Value.BestScore,
                        item.Value.PlayCount,
                        item.Value.BestCompletionTimeInSeconds));
            }

            SingleplayerMeleeMissionData = new Dictionary<uint, MissionData>();
            foreach (var item in activePilotModel.Faction[activeFaction].MissionHistory[GameMode.Singleplayer].Melee)
            {
                SingleplayerMeleeMissionData.Add(
                    item.Key,
                    new MissionData(
                        item.Value.Evaluation,
                        item.Value.Name,
                        item.Value.BestScore,
                        item.Value.PlayCount,
                        item.Value.BestPlaceFinish));
            }

            MultiplayerMeleeMissionData = new Dictionary<uint, MissionData>();
            foreach (var item in activePilotModel.Faction[activeFaction].MissionHistory[GameMode.Multiplayer].Melee)
            {
                MultiplayerMeleeMissionData.Add(
                    item.Key,
                    new MissionData(
                        item.Value.Evaluation,
                        item.Value.Name,
                        item.Value.BestScore,
                        item.Value.PlayCount,
                        item.Value.BestPlaceFinish));
            }

            SingleplayerCombatMissionData = new Dictionary<uint, MissionData>();
            foreach (var item in activePilotModel.Faction[activeFaction].MissionHistory[GameMode.Singleplayer].Combat)
            {
                SingleplayerCombatMissionData.Add(
                    item.Key,
                    new MissionData(
                        item.Value.Evaluation,
                        item.Value.Name,
                        item.Value.BestScore,
                        item.Value.PlayCount,
                        item.Value.BestCompletionTimeInSeconds));
            }

            MultiplayerCombatMissionData = new Dictionary<uint, MissionData>();
            foreach (var item in activePilotModel.Faction[activeFaction].MissionHistory[GameMode.Multiplayer].Combat)
            {
                MultiplayerCombatMissionData.Add(
                    item.Key,
                    new MissionData(
                        item.Value.Evaluation,
                        item.Value.Name,
                        item.Value.BestScore,
                        item.Value.PlayCount,
                        item.Value.BestCompletionTimeInSeconds));
            }
        }
    }
}
