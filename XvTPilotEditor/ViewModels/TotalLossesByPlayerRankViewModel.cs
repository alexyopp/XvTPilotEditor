using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class TotalLossesByPlayerRankViewModel : PageViewModel
    {
        public class TotalLossesByPlayerRankItem
        {
            public uint Losses { get; set; }

            public TotalLossesByPlayerRankItem(uint losses)
            {
                this.Losses = losses;
            }
        }

        public class TotalLossesByPlayerRankLine
        {
            public Dictionary<MissionType, TotalLossesByPlayerRankItem> TotalLossesByPlayerRankByMissionType { get; set; }

            private PilotModel activePilotModel;
            private Faction activeFaction;

            public TotalLossesByPlayerRankLine(PilotModel pilotModel, Faction faction, PilotRating rating)
            {
                this.activePilotModel = pilotModel;
                this.activeFaction = faction;

                this.TotalLossesByPlayerRankByMissionType = new Dictionary<MissionType, TotalLossesByPlayerRankItem>();
                foreach (MissionType missionType in Enum.GetValues<MissionType>())
                {
                    TotalLossesByPlayerRankByMissionType.Add(
                        missionType,
                        new TotalLossesByPlayerRankItem(
                            activePilotModel.Faction[activeFaction].MissionStats[missionType].LossesToPlayersByRank[rating]));
                }
            }
        }

        public Dictionary<PilotRating, TotalLossesByPlayerRankLine> totalLossesByPlayerRank;
        public Dictionary<PilotRating, TotalLossesByPlayerRankLine> TotalLossesByPlayerRank
        {
            get => totalLossesByPlayerRank;
        }

        private PilotModel activePilotModel;
        private Faction activeFaction;

        internal TotalLossesByPlayerRankViewModel(PilotModel pilotModel, Faction faction)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;

            this.totalLossesByPlayerRank = new Dictionary<PilotRating, TotalLossesByPlayerRankLine>();

            foreach (PilotRating rating in Enum.GetValues<PilotRating>())
            {
                totalLossesByPlayerRank.Add(
                    rating,
                    new TotalLossesByPlayerRankLine(pilotModel, faction, rating));
            }
        }
    }
}
