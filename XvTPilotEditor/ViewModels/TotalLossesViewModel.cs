using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class TotalLossesViewModel : PageViewModel
    {
        public string TotalCraftLosses
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalCraftLosses.ToString();
            set {
                uint totalCraftLosses;
                if (uint.TryParse(value, out totalCraftLosses))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].TotalCraftLosses = totalCraftLosses;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LossesToPlayerPilots
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToPlayerPilots.ToString();
            set
            {
                uint lossesToPlayerPilots;
                if (uint.TryParse(value, out lossesToPlayerPilots))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToPlayerPilots = lossesToPlayerPilots;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LossesToNonPlayerPilots
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToNonPlayerPilots.ToString();
            set
            {
                uint lossesToNonPlayerPilots;
                if (uint.TryParse(value, out lossesToNonPlayerPilots))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToNonPlayerPilots = lossesToNonPlayerPilots;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LossesToStarships
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToStarships.ToString();
            set
            {
                uint lossesToStarships;
                if (uint.TryParse(value, out lossesToStarships))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToStarships = lossesToStarships;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LossesToMines
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToMines.ToString();
            set
            {
                uint lossesToMines;
                if (uint.TryParse(value, out lossesToMines))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesToMines = lossesToMines;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string LossesFromCollisions
        {
            get => activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesFromCollisions.ToString();
            set
            {
                uint lossesFromCollisions;
                if (uint.TryParse(value, out lossesFromCollisions))
                {
                    activePilotModel.Faction[activeFaction].MissionStats[activeMissionType].LossesFromCollisions = lossesFromCollisions;
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

        internal TotalLossesViewModel(PilotModel pilotModel, Faction faction, MissionType missionType)
            : base(pilotModel)
        {
            this.activePilotModel = pilotModel;
            this.activeFaction = faction;
            this.activeMissionType = missionType;
        }
    }
}
