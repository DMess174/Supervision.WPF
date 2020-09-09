using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.TabItems;
using SupervisionApp.WPF.ViewModels.TabItems.Employees;
using System;

namespace SupervisionApp.WPF.ViewModels.Factories
{
    public class TabItemViewModelFactory : ITabItemViewModelFactory
    {

        private readonly CreateTabViewModel<EmployeeListViewModel> _createEmployeeListViewModel;
        private readonly CreateTabViewModel<EmployeeViewModel> _createEmployeeViewModel;

        public TabItemViewModelFactory(CreateTabViewModel<EmployeeListViewModel> createEmployeeListViewModel, 
            CreateTabViewModel<EmployeeViewModel> createEmployeeViewModel)
        {
            _createEmployeeListViewModel = createEmployeeListViewModel;
            _createEmployeeViewModel = createEmployeeViewModel;
        }

        public TabItemViewModelBase CreateTabViewModel(TabItemViewType tabViewType, object args = null)
        {
            return tabViewType switch
            {
                TabItemViewType.EmployeeList => _createEmployeeListViewModel(),
                TabItemViewType.EmployeeEdit => _createEmployeeViewModel(args),
                _ => throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType"),
            };
        }
    }
}
