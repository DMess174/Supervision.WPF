using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.WPF.Models.Accounts;

namespace SupervisionApp.WPF.ViewModels.TabItems.Employees
{
    public class EmployeeCardViewModel : TabItemViewModelBase
    {
        public Employee Employee { get; set; }

        public EmployeeCardViewModel(IAccountStore accountStore, string header, Employee employee) : base(accountStore, header)
        {
            Employee = employee;
        }

        public static EmployeeCardViewModel LoadViewModel(IAccountStore accountStore, string header, Employee employee)
        {
            var vm = new EmployeeCardViewModel(accountStore, header, employee);

            return vm;
        }

        public override bool CanClosed() => true;
    }
}
