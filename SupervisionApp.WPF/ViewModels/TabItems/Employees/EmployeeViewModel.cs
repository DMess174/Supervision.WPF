using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels.TabItems.Employees
{
    public class EmployeeViewModel : TabItemViewModelBase
    {
        private readonly IEmployeeService _employeeService;
        public Employee Employee { get; private set; }

        public ICommand SaveEntityCommand { get; }

        public EmployeeViewModel(IAuthenticator authenticator, string header, IEmployeeService employeeService,
            ITabItemViewModelNavigator tabViewModelNavigator, MainViewModel mainViewModel) 
            : base(authenticator, header, mainViewModel, tabViewModelNavigator)
        {
            _employeeService = employeeService;
            SaveEntityCommand = new UpdateEntityCommand<Employee>(_employeeService);
        }

        public static EmployeeViewModel LoadViewModel(IAuthenticator authenticator, string header, 
            IEmployeeService employeeService, ITabItemViewModelNavigator tabViewModelNavigator, MainViewModel mainViewModel, Employee employee)
        {
            var vm = new EmployeeViewModel(authenticator, header, employeeService, tabViewModelNavigator, mainViewModel);
            vm.Load(employee);
            return vm;
        }

        private async void Load(Employee employee)
        {
            try
            {
                IsBusy = true;
                if (employee == null)
                    Employee = new Employee();
                else
                {
                    Employee = await _employeeService.GetByIdAsync(employee.Id);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

        public override bool CanClosed() => true;
    }
}
