using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class StatisticsPageViewModel : PageViewModel
    {
        public SummaryOfKillsViewModel ExerciseSummaryOfKills { get; }
        public SummaryOfKillsViewModel MeleeSummaryOfKills { get; }
        public SummaryOfKillsViewModel CombatSummaryOfKills { get; }

        internal StatisticsPageViewModel(PilotModel pilotModel)
            : base(pilotModel)
        {
            ExerciseSummaryOfKills = new SummaryOfKillsViewModel(pilotModel, Faction.Rebel, MissionType.Exercise);
            MeleeSummaryOfKills = new SummaryOfKillsViewModel(pilotModel, Faction.Rebel, MissionType.Melee);
            CombatSummaryOfKills = new SummaryOfKillsViewModel(pilotModel, Faction.Rebel, MissionType.Combat);
        }
    }
}
