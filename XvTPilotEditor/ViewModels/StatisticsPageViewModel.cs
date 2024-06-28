using XvTPilotEditor.Models;
using XvTPilotEditor.Views;

namespace XvTPilotEditor.ViewModels
{
    public class StatisticsPageViewModel : PageViewModel
    {
        public SummaryOfKillsViewModel ExerciseSummaryOfKills { get; }
        public SummaryOfKillsViewModel MeleeSummaryOfKills { get; }
        public SummaryOfKillsViewModel CombatSummaryOfKills { get; }

        public PlayerKillsByRankViewModel ExercisePlayerKillsByRank { get; }
        public PlayerKillsByRankViewModel MeleePlayerKillsByRank { get; }
        public PlayerKillsByRankViewModel CombatPlayerKillsByRank { get; }

        public AveragesPerMissionViewModel ExerciseAveragesPerMission { get; }
        public AveragesPerMissionViewModel MeleeAveragesPerMission { get; }
        public AveragesPerMissionViewModel CombatAveragesPerMission { get; }

        public TotalLossesViewModel ExerciseTotalLosses { get; }
        public TotalLossesViewModel MeleeTotalLosses { get; }
        public TotalLossesViewModel CombatTotalLosses { get; }

        internal StatisticsPageViewModel(PilotModel pilotModel)
            : base(pilotModel)
        {
            ExerciseSummaryOfKills = new SummaryOfKillsViewModel(pilotModel, Faction.Rebel, MissionType.Exercise);
            MeleeSummaryOfKills = new SummaryOfKillsViewModel(pilotModel, Faction.Rebel, MissionType.Melee);
            CombatSummaryOfKills = new SummaryOfKillsViewModel(pilotModel, Faction.Rebel, MissionType.Combat);

            ExercisePlayerKillsByRank = new PlayerKillsByRankViewModel(pilotModel, Faction.Rebel, MissionType.Exercise);
            MeleePlayerKillsByRank = new PlayerKillsByRankViewModel(pilotModel, Faction.Rebel, MissionType.Melee);
            CombatPlayerKillsByRank = new PlayerKillsByRankViewModel(pilotModel, Faction.Rebel, MissionType.Combat);

            ExerciseAveragesPerMission = new AveragesPerMissionViewModel(pilotModel, Faction.Rebel, MissionType.Exercise);
            MeleeAveragesPerMission = new AveragesPerMissionViewModel(pilotModel, Faction.Rebel, MissionType.Melee);
            CombatAveragesPerMission = new AveragesPerMissionViewModel(pilotModel, Faction.Rebel, MissionType.Combat);

            ExerciseTotalLosses = new TotalLossesViewModel(pilotModel, Faction.Rebel, MissionType.Exercise);
            MeleeTotalLosses = new TotalLossesViewModel(pilotModel, Faction.Rebel, MissionType.Melee);
            CombatTotalLosses = new TotalLossesViewModel(pilotModel, Faction.Rebel, MissionType.Combat);
        }
    }
}
