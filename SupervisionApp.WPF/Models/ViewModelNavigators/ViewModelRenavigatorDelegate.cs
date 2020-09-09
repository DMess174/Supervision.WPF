using SupervisionApp.WPF.ViewModels.Base;

namespace SupervisionApp.WPF.Models.ViewModelNavigators
{
    public class ViewModelRenavigatorDelegate<TViewModel> : IViewModelRenavigator where TViewModel : ViewModelBase
    {
        private readonly IViewModelNavigator _navigator;
        private readonly CreateViewModel<TViewModel> _createViewModel;

        public ViewModelRenavigatorDelegate(IViewModelNavigator navigator, CreateViewModel<TViewModel> createViewModel)
        {
            _navigator = navigator;
            _createViewModel = createViewModel;
        }

        public void Renavigate()
        {
            _navigator.CurrentViewModel = _createViewModel();
        }
    }
}