using SupervisionApp.WPF.ViewModels.TabItems;
using System;
using System.Collections.ObjectModel;

namespace SupervisionApp.WPF.Models.ViewModelNavigators
{
    public class TabItemViewModelNavigator : ITabItemViewModelNavigator
    {
        private TabItemViewModelBase currentTab;

        public TabItemViewModelBase CurrentTab
        {
            get => currentTab;
            set
            {
                currentTab = value;
                StateChanged?.Invoke();
            }
        }

        public ObservableCollection<TabItemViewModelBase> TabItems { get; set; }

        public event Action StateChanged;

        public void CloseTab(TabItemViewModelBase item)
        {
            TabItems.Remove(item);
        }

        public void OpenTab(TabItemViewModelBase item)
        {
            TabItems.Add(item);
            CurrentTab = item; ;
        }
    }
}