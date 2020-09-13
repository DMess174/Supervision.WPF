using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Accounts;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels.TabItems.Employees
{
    public class EmployeeViewModel : TabItemViewModelBase
    {
        private readonly IEmployeeService _employeeService;

        public Employee Employee { get; private set; }

        public ICommand SaveEntityCommand { get; }

        public EmployeeViewModel(IAccountStore accountStore, string header, IEmployeeService employeeService) 
            : base(accountStore, header)
        {
            _employeeService = employeeService;
            SaveEntityCommand = new UpdateEntityCommand<Employee>(_employeeService);
        }

        public static EmployeeViewModel LoadViewModel(IAccountStore accountStore, string header, 
            IEmployeeService employeeService, Employee employee)
        {
            var vm = new EmployeeViewModel(accountStore, header, employeeService);
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
