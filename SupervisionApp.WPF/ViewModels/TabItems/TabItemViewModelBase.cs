using SupervisionApp.WPF.Models.Accounts;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Base;

namespace SupervisionApp.WPF.ViewModels.TabItems
{
    public delegate TTabViewModel CreateTabViewModel<TTabViewModel>(object args = null) where TTabViewModel : TabItemViewModelBase;

    public abstract class TabItemViewModelBase : ViewModelBase
    {
        public IAccountStore AccountStore;
        public bool IsBusy { get; set; } = false;
        public string Header { get; set; }

        public TabItemViewModelBase(IAccountStore accountStore,
            string header)
        {
            Header = header;
            AccountStore = accountStore;
        }

        public abstract bool CanClosed();
    }
}
