using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Base;

namespace SupervisionApp.WPF.ViewModels.TabItems
{
    public delegate TTabViewModel CreateTabViewModel<TTabViewModel>(object args = null) where TTabViewModel : TabItemViewModelBase;

    public abstract class TabItemViewModelBase : ViewModelBase
    {
        public MainViewModel MainViewModel;
        public ITabItemViewModelNavigator TabViewModelNavigator;
        public bool IsBusy { get; set; }
        public string Header { get; set; }

        public TabItemViewModelBase(IAuthenticator authenticator,
            string header, MainViewModel mainViewModel, ITabItemViewModelNavigator tabViewModelNavigator) : base(authenticator)
        {
            IsBusy = false;
            Header = header;
            MainViewModel = mainViewModel;
            TabViewModelNavigator = tabViewModelNavigator;
        }

        public abstract bool CanClosed();
    }
}
