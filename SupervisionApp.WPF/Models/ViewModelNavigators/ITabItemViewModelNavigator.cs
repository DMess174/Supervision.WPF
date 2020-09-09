using SupervisionApp.WPF.ViewModels.TabItems;
using System;
using System.Collections.ObjectModel;

namespace SupervisionApp.WPF.Models.ViewModelNavigators
{
    public enum TabItemViewType
    {
        EmployeeList,
        EmployeeEdit
    }

    public interface ITabItemViewModelNavigator
    {
        ObservableCollection<TabItemViewModelBase> TabItems { get; set; }

        TabItemViewModelBase CurrentTab { get; set; }

        event Action StateChanged;

        void CloseTab(TabItemViewModelBase item);

        void OpenTab(TabItemViewModelBase item);
    }
}
