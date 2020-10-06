using SupervisionApp.WPF.Models.Accounts;

namespace SupervisionApp.WPF.ViewModels.TabItems.Customers
{
    public class CustomerListViewModel : TabItemViewModelBase
    {
        public CustomerListViewModel(IAccountStore accountStore, string header) : base(accountStore, header)
        {
        }

        public override bool CanClosed()
        {
            return true;
        }
    }
}
