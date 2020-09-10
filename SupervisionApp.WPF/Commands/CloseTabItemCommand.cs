﻿using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.TabItems;

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

        public override void Execute(object parameter)
        {
            var index = _tabViewModelNavigator.TabItems.IndexOf(_tabViewModelNavigator.CurrentTab);
            if (_tabViewModelNavigator.CurrentTab.CanClosed())
            {
                _tabViewModelNavigator.CloseTab(_tabViewModelNavigator.CurrentTab);
                if (index < _tabViewModelNavigator.TabItems.Count && index != 0)
                {
                    _tabViewModelNavigator.CurrentTab = _tabViewModelNavigator.TabItems[index];
                }
            }
        }
    }
}
