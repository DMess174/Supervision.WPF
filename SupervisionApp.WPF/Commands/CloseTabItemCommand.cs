using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.ViewModelNavigators;

namespace SupervisionApp.WPF.Commands
{
    public class CloseTabItemCommand : CommandBase
    {
        private readonly ITabItemViewModelNavigator _tabViewModelNavigator;

        public CloseTabItemCommand(ITabItemViewModelNavigator tabViewModelNavigator)
        {
            _tabViewModelNavigator = tabViewModelNavigator;
        }

        public override bool CanExecute(object parameter)
        {
            return _tabViewModelNavigator.CurrentTab != null;
        }

        public override void Execute(object parameter) // TODO: Баг с закрытием не того окна
        {
            var index = _tabViewModelNavigator.TabItems.IndexOf(_tabViewModelNavigator.CurrentTab) - 1;
            _tabViewModelNavigator.CloseTab(_tabViewModelNavigator.CurrentTab);
            if (index == -1)
                _tabViewModelNavigator.CurrentTab = _tabViewModelNavigator.TabItems[index + 1];
            else
                _tabViewModelNavigator.CurrentTab = _tabViewModelNavigator.TabItems[index];
        }
    }
}
