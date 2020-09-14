using SupervisionApp.WPF.ViewModels.Base;
using System;
using System.Collections.ObjectModel;

namespace SupervisionApp.WPF.ViewModels.TabItems
{
    public class TabItemCollectionViewModel : ViewModelBase
    {
        public ObservableCollection<TabItemViewModelBase> Tabs { get; set; }

        private TabItemViewModelBase _currentTab;

        public TabItemViewModelBase CurrentTab
        {
            get => _currentTab;
            set 
            { 
                _currentTab = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
        public void CloseTab(TabItemViewModelBase item)
        {
            var index = Tabs.IndexOf(item);
            Tabs.Remove(item);
            if (index < Tabs.Count && index != 0)
            {
                CurrentTab = Tabs[index];
            }
        }

        public void OpenTab(TabItemViewModelBase item)
        {
            Tabs.Add(item);
            CurrentTab = item;
        }
    }
}
