using SupervisionApp.WPF.ViewModels.TabItems;
using SupervisionApp.WPF.ViewModels.TabItems.Employees;
using SupervisionApp.WPF.ViewModels.TabItems.Orders;
using System;

namespace SupervisionApp.WPF.ViewModels.Factories
{
    public class TabItemViewModelFactory : ITabItemViewModelFactory
    {

        private readonly CreateTabViewModel<EmployeeListViewModel> _createEmployeeListViewModel;
        private readonly CreateTabViewModel<EmployeeViewModel> _createEmployeeViewModel;
        private readonly CreateTabViewModel<SpecificationListViewModel> _createSpecificationListViewModel;

        public TabItemViewModelFactory(CreateTabViewModel<EmployeeListViewModel> createEmployeeListViewModel,
            CreateTabViewModel<EmployeeViewModel> createEmployeeViewModel, 
            CreateTabViewModel<SpecificationListViewModel> createSpecificationListViewModel)
        {
            _createEmployeeListViewModel = createEmployeeListViewModel;
            _createEmployeeViewModel = createEmployeeViewModel;
            _createSpecificationListViewModel = createSpecificationListViewModel;
        }

        public TabItemViewModelBase CreateTabViewModel(TabItemViewType tabViewType, object args = null)
        {
            return tabViewType switch
            {
                TabItemViewType.EmployeeList => _createEmployeeListViewModel(),
                TabItemViewType.EmployeeEdit => _createEmployeeViewModel(args),
                TabItemViewType.SpecificationList => _createSpecificationListViewModel(),
                _ => throw new ArgumentException("The TabViewType does not have a ViewModel.", "tabViewType"),
            };
        }
    }
}
