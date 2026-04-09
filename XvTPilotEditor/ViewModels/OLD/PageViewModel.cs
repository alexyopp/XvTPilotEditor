using XvTPilotEditor.Models.OLD;

namespace XvTPilotEditor.ViewModels.OLD
{
    public class PageViewModel : ViewModelBase
    {
        protected PilotModel pilotModel;

        public PageViewModel(PilotModel pilotModel)
        {
            this.pilotModel = pilotModel;
        }
    }
}
