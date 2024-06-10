using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using XvTPilotEditor.Commands;

namespace XvTPilotEditor.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Page ActivePage                      { get; set; }
        public Faction ActiveFaction                { get; set; }
        public PageViewModel ActivePageViewModel    { get; set; }

        public ICommand ChangeActivePageCommand     { get; private set; }

        private Dictionary<Page, PageViewModel> pageViewModels;

        public MainViewModel()
        {
            pageViewModels = BuildViewModels();

            ChangeActivePageCommand = new DelegateCommand(o => this.UpdateActivePageViewModel());

            // Initial state
            ActiveFaction           = Faction.Rebel;
            ActivePage              = Page.Statistics;
            ActivePageViewModel     = pageViewModels[ActivePage];
        }

        private Dictionary<Page, PageViewModel> BuildViewModels()
        {
            Dictionary<Page, PageViewModel> viewModels = new Dictionary<Page, PageViewModel>();

            foreach (var page in Enum.GetValues<Page>())
            {
                switch (page)
                {
                    case Page.Statistics:
                        viewModels.Add(Page.Statistics, new StatisticsPageViewModel());
                        break;
                    case Page.RatingHistory:
                        viewModels.Add(Page.RatingHistory, new RatingHistoryViewModel());
                        break;
                    case Page.MissionAchievements:
                        viewModels.Add(Page.MissionAchievements, new MissionAchievementsViewModel());
                        break;
                }
            }

            return viewModels;
        }

        private void UpdateActivePageViewModel()
        {
            ActivePageViewModel = pageViewModels[ActivePage];
            OnPropertyChanged(nameof(ActivePageViewModel));
        }
    }
}
