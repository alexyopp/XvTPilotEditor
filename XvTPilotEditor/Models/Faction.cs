using System;
using System.Collections.Generic;

namespace XvTPilotEditor.Models
{
    public class Faction
    {
        public Dictionary<MissionType, ModeStats> MissionStats { get; }
        public Dictionary<GameMode, MissionHistory> MissionHistory { get; }

        public Faction()
        {
            MissionStats = new Dictionary<MissionType, ModeStats>();
            foreach (MissionType missionType in Enum.GetValues<MissionType>())
            {
                MissionStats.Add(missionType, new ModeStats());
            }

            MissionHistory = new Dictionary<GameMode, MissionHistory>();
            foreach (GameMode gameMode in Enum.GetValues<GameMode>())
            {
                MissionHistory.Add(gameMode, new MissionHistory());
            }
        }
    }
}
