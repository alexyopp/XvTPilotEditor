using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class CraftKillsByTypeViewModel : PageViewModel
    {
        public class CraftKillsByTypeItem
        {
            public uint Kills               { get; set; }
            public uint SharedKills         { get; set; }

            public CraftKillsByTypeItem(uint kills, uint sharedKills)
            {
                this.Kills = kills;
                this.SharedKills = sharedKills;
            }
        }

        public class CraftKillsByTypeLine
        {
            public Dictionary<MissionType, CraftKillsByTypeItem> CraftKillsByTypeByMissionType { get; set; }

            private PilotModel activePilotModel;
            private Faction activeFaction;

            public CraftKillsByTypeLine(PilotModel pilotModel, Faction faction, CraftType type)
            {
                this.activePilotModel = pilotModel;
                this.activeFaction = faction;

                this.CraftKillsByTypeByMissionType = new Dictionary<MissionType, CraftKillsByTypeItem>();
                foreach (MissionType missionType in Enum.GetValues<MissionType>())
                {
                    CraftKillsByTypeByMissionType.Add(
                        missionType,
                        new CraftKillsByTypeItem(
                            activePilotModel.Faction[activeFaction].MissionStats[missionType].CraftKillsByType[type],
                            activePilotModel.Faction[activeFaction].MissionStats[missionType].CraftSharedKillsByType[type]));
                }
            }
        }

        public Dictionary<CraftType, CraftKillsByTypeLine> craftKillsByType;
        public Dictionary<CraftType, CraftKillsByTypeLine> CraftKillsByType
        {
            get => craftKillsByType;
        }

        private PilotModel activePilotModel;
        private Faction activeFaction;

        internal CraftKillsByTypeViewModel(PilotModel pilotModel, Faction faction)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;

            this.craftKillsByType = new Dictionary<CraftType, CraftKillsByTypeLine>();

            foreach (CraftType type in Enum.GetValues<CraftType>())
            {
                craftKillsByType.Add(
                    type,
                    new CraftKillsByTypeLine(pilotModel, faction, type));
            }
        }
    }
}
