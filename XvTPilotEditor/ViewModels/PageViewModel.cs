using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
{
    public class PageViewModel : ViewModelBase
    {
        protected Pilot pilotModel;

        public PageViewModel(Pilot pilotModel)
        {
            this.pilotModel = pilotModel;
        }
    }
}
