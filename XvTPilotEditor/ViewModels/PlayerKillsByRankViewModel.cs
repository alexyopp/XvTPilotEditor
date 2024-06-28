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
            public PilotRating PilotRating  { get; private set;}
            public uint Kills               { get; set; }
            public uint SharedKills         { get; set; }

            public PlayerKillByRankItem(PilotRating pilotRating, uint kills, uint sharedKills)
            {
                this.PilotRating = pilotRating;
                this.Kills = kills;
                this.SharedKills = sharedKills;
            }
        }

        public Dictionary<PilotRating, PlayerKillByRankItem> playerKillsByRank;
        public Dictionary<PilotRating, PlayerKillByRankItem> PlayerKillsByRank
        {
            get => playerKillsByRank;
            set
            {
                playerKillsByRank = value;
            }
        }

        private PilotModel activePilotModel;
        private Faction activeFaction;
        private MissionType activeMissionType;

        internal PlayerKillsByRankViewModel(PilotModel pilotModel, Faction faction, MissionType missionType)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;
            this.activeMissionType = missionType;

            this.PlayerKillsByRank = new Dictionary<PilotRating, PlayerKillByRankItem>();

            foreach (PilotRating rating in Enum.GetValues<PilotRating>())
            {
                PlayerKillsByRank.Add(
                    rating,
                    new PlayerKillByRankItem(
                        rating,
                        activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerKillsByRank[rating],
                        activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerSharedKillsByRank[rating]));
            }
        }
    }
}
