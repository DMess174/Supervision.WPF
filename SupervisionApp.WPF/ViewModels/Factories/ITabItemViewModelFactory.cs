using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.TabItems;

namespace SupervisionApp.WPF.ViewModels.Factories
{
    public enum TabItemViewType
    {
        EmployeeList,
        EmployeeEdit
    }

    public interface ITabItemViewModelFactory
    {
        TabItemViewModelBase CreateTabViewModel(TabItemViewType tabViewType, object args = null);
    }
}
