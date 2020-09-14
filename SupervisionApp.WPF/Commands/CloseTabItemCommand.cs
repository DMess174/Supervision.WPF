using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.ViewModels.TabItems;

namespace SupervisionApp.WPF.Commands
{
    public class CloseTabItemCommand : CommandBase
    {
        private readonly TabItemCollectionViewModel _tabsViewModel;

        public CloseTabItemCommand(TabItemCollectionViewModel tabsViewModel)
        {
            _tabsViewModel = tabsViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return _tabsViewModel.CurrentTab != null;
        }

        public override void Execute(object parameter)
        {
            if (_tabsViewModel.CurrentTab.CanClosed())
            {
                _tabsViewModel.CloseTab(_tabsViewModel.CurrentTab);
            }
        }
    }
}
