using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class SummaryOfKillsViewModel : PageViewModel
    {
        public string TotalKills
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalKills.ToString();
            set {
                uint totalKills;
                if (uint.TryParse(value, out totalKills))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalKills = totalKills;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string TotalSharedKills
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalSharedKills.ToString();
            set
            {
                uint totalSharedKills;
                if (uint.TryParse(value, out totalSharedKills))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalSharedKills = totalSharedKills;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string PlayerKills
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerKills.ToString();
            set
            {
                uint playerKills;
                if (uint.TryParse(value, out playerKills))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerKills = playerKills;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string PlayerSharedKills
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerSharedKills.ToString();
            set
            {
                uint playerSharedKills;
                if (uint.TryParse(value, out playerSharedKills))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].PlayerSharedKills = playerSharedKills;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string NonPlayerKills
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerKills.ToString();
            set
            {
                uint nonPlayerKills;
                if (uint.TryParse(value, out nonPlayerKills))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerKills = nonPlayerKills;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string NonPlayerSharedKills
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerSharedKills.ToString();
            set
            {
                uint nonPlayerSharedKills;
                if (uint.TryParse(value, out nonPlayerSharedKills))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].NonPlayerSharedKills = nonPlayerSharedKills;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Assists
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].Assists.ToString();
            set
            {
                uint assists;
                if (uint.TryParse(value, out assists))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].Assists = assists;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string HiddenCargoFound
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].HiddenCargoFound.ToString();
            set
            {
                uint hiddenCargoFound;
                if (uint.TryParse(value, out hiddenCargoFound))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].HiddenCargoFound = hiddenCargoFound;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LaserAccuracy
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LaserAccuracy.ToString();
            set
            {
                uint laserAccuracy;
                if (uint.TryParse(value, out laserAccuracy))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LaserAccuracy = laserAccuracy;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string WarheadAccuracy
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].WarheadAccuracy.ToString();
            set
            {
                uint warheadAccuracy;
                if (uint.TryParse(value, out warheadAccuracy))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].WarheadAccuracy = warheadAccuracy;
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

        internal SummaryOfKillsViewModel(PilotModel pilotModel, Faction faction, MissionType missionType)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;
            this.activeMissionType = missionType;
        }
    }
}
