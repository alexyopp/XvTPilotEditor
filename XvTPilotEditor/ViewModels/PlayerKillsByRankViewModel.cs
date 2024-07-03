using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class PlayerKillsByRankViewModel : PageViewModel
    {
        public class PlayerKillByRankItem
        {
            public uint Kills               { get; set; }
            public uint SharedKills         { get; set; }

            public PlayerKillByRankItem(uint kills, uint sharedKills)
            {
                this.Kills = kills;
                this.SharedKills = sharedKills;
            }
        }

        public class PlayerKillByRankLine
        {
            public Dictionary<MissionType, PlayerKillByRankItem> PlayerKillsByRankByMissionType { get; set; }

            private PilotModel activePilotModel;
            private Faction activeFaction;

            public PlayerKillByRankLine(PilotModel pilotModel, Faction faction, PilotRating rating)
            {
                this.activePilotModel = pilotModel;
                this.activeFaction = faction;

                this.PlayerKillsByRankByMissionType = new Dictionary<MissionType, PlayerKillByRankItem>();
                foreach (MissionType missionType in Enum.GetValues<MissionType>())
                {
                    PlayerKillsByRankByMissionType.Add(
                        missionType,
                        new PlayerKillByRankItem(
                            activePilotModel.Faction[activeFaction].MissionStats[missionType].PlayerKillsByRank[rating],
                            activePilotModel.Faction[activeFaction].MissionStats[missionType].PlayerSharedKillsByRank[rating]));
                }
            }
        }

        public Dictionary<PilotRating, PlayerKillByRankLine> playerKillsByRank;
        public Dictionary<PilotRating, PlayerKillByRankLine> PlayerKillsByRank
        {
            get => playerKillsByRank;
        }

        private PilotModel activePilotModel;
        private Faction activeFaction;

        internal PlayerKillsByRankViewModel(PilotModel pilotModel, Faction faction)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;

            this.playerKillsByRank = new Dictionary<PilotRating, PlayerKillByRankLine>();

            foreach (PilotRating rating in Enum.GetValues<PilotRating>())
            {
                playerKillsByRank.Add(
                    rating,
                    new PlayerKillByRankLine(pilotModel, faction, rating));
            }
        }
    }
}
