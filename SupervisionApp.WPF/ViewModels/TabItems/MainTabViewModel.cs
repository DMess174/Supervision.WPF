using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;

namespace SupervisionApp.WPF.ViewModels.TabItems
{
    public class MainTabViewModel : TabItemViewModelBase
    {


        public MainTabViewModel(IAuthenticator authenticator, string header, MainViewModel mainViewModel, ITabItemViewModelNavigator tabViewModelNavigator) : base(authenticator, header, mainViewModel, tabViewModelNavigator)
        {
        }

        public override bool CanClosed() => false;
    }
}
