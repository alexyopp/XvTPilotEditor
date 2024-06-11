using System;
using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class FactionModel
    {
        public Dictionary<MissionType, MissionStatsModel> MissionStats { get; }
        public Dictionary<GameMode, MissionHistoryModel> MissionHistory { get; }

        public FactionModel()
        {
            MissionStats = new Dictionary<MissionType, MissionStatsModel>();
            foreach (MissionType missionType in Enum.GetValues<MissionType>())
            {
                MissionStats.Add(missionType, new MissionStatsModel());
            }

            MissionHistory = new Dictionary<GameMode, MissionHistoryModel>();
            foreach (GameMode gameMode in Enum.GetValues<GameMode>())
            {
                MissionHistory.Add(gameMode, new MissionHistoryModel());
            }
        }
    }
}
