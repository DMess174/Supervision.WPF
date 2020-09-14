using SupervisionApp.WPF.Models.Accounts;
using SupervisionApp.WPF.Models.ViewModelNavigators;

namespace SupervisionApp.WPF.ViewModels.TabItems
{
    public class MainTabViewModel : TabItemViewModelBase
    {
        public MainTabViewModel(IAccountStore accountStore, string header) : base(accountStore, header)
        {
        }

        public override bool CanClosed() => false;
    }
}
