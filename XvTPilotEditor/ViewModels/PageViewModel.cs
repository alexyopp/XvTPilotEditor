using XvTPilotEditor.Models;

namespace XvTPilotEditor.ViewModels
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
