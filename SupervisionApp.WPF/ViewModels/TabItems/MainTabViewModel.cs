using SupervisionApp.WPF.Models.Accounts;

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
