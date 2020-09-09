using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace SupervisionApp.WPF.Commands
{
    public class CloseTabItemCommand : ICommand
    {
        private readonly ITabItemViewModelNavigator _tabViewModelNavigator;
        private readonly MainViewModel _mainViewModel;

        public CloseTabItemCommand(ITabItemViewModelNavigator tabViewModelNavigator, MainViewModel mainViewModel)
        {
            _tabViewModelNavigator = tabViewModelNavigator;
            _mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _mainViewModel.TabViewModelNavigator.CurrentTab != null;
        }

        public void Execute(object parameter) //TODO : Пофиксить баг с закрытием не того окна
        {
            var index = _tabViewModelNavigator.TabItems.IndexOf(_mainViewModel.CurrentTab) - 1;
            _tabViewModelNavigator.CloseTab(_mainViewModel.CurrentTab);
            if (index == -1)
                _tabViewModelNavigator.CurrentTab = _tabViewModelNavigator.TabItems[index + 1];
            else
                _tabViewModelNavigator.CurrentTab = _tabViewModelNavigator.TabItems[index];
        }
    }
}
