using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Accounts;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Factories;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels.TabItems.Employees
{
    public class EmployeeListViewModel : TabItemViewModelBase
    {
        private readonly IEmployeeService _employeeService;

        public ICommand AddTabCommand { get; }

        public ObservableCollection<EmployeeCardViewModel> EmployeeCards { get; set; }

        public EmployeeListViewModel(IAccountStore accountStore, string header, IEmployeeService employeeService) : base(accountStore, header)
        {
            Header = "Список персонала";
            _employeeService = employeeService;

            EmployeeCards = new ObservableCollection<EmployeeCardViewModel>();

            var items = _employeeService.GetAllInclude();

            if (items != null)
            {
                foreach (var item in items)
                {
                    EmployeeCards.Add(EmployeeCardViewModel.LoadViewModel(AccountStore, AccountStore.CurrentAccount.Employee.LastName, 
                        item));
                }
            }
        }

        public override bool CanClosed() => true;
    }
}
