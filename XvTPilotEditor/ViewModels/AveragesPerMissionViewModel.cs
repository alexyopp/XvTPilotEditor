using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class AveragesPerMissionViewModel : PageViewModel
    {
        public string TotalKillsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalKillsPerMission.ToString();
            set {
                uint totalKillsPerMission;
                if (uint.TryParse(value, out totalKillsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalKillsPerMission = totalKillsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string TotalSharedKillsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalSharedKillsPerMission.ToString();
            set
            {
                uint totalSharedKillsPerMission;
                if (uint.TryParse(value, out totalSharedKillsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalSharedKillsPerMission = totalSharedKillsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string PlayerKillsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerKillsPerMission.ToString();
            set
            {
                uint playerKillsPerMission;
                if (uint.TryParse(value, out playerKillsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerKillsPerMission = playerKillsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string PlayerSharedKillsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerSharedKillsPerMission.ToString();
            set
            {
                uint playerSharedKillsPerMission;
                if (uint.TryParse(value, out playerSharedKillsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerSharedKillsPerMission = playerSharedKillsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string NonPlayerKillsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerKillsPerMission.ToString();
            set
            {
                uint nonPlayerKillsPerMission;
                if (uint.TryParse(value, out nonPlayerKillsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerKillsPerMission = nonPlayerKillsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string NonPlayerSharedKillsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerSharedKillsPerMission.ToString();
            set
            {
                uint nonPlayerSharedKillsPerMission;
                if (uint.TryParse(value, out nonPlayerSharedKillsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerSharedKillsPerMission = nonPlayerSharedKillsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string AssistsPerMission
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].AssistsPerMission.ToString();
            set
            {
                uint assistsPerMission;
                if (uint.TryParse(value, out assistsPerMission))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].AssistsPerMission = assistsPerMission;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private PilotModel activePilotModel;
        private Faction activeFaction;
        private MissionType activeMissionType;

        internal AveragesPerMissionViewModel(PilotModel pilotModel, Faction faction, MissionType missionType)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;
            this.activeMissionType = missionType;
        }
    }
}
