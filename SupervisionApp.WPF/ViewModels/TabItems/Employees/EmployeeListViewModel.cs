using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
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

        public EmployeeListViewModel(IAuthenticator authenticator, string header, ITabItemViewModelNavigator tabViewModelNavigator, 
            MainViewModel mainViewModel, ITabItemViewModelFactory tabViewModelFactory, 
            IEmployeeService employeeService = null) : base(authenticator, header, mainViewModel, tabViewModelNavigator)
        {
            Header = "Список персонала";
            _employeeService = employeeService;

            AddTabCommand = new AddTabItemCommand(tabViewModelFactory, mainViewModel);

            EmployeeCards = new ObservableCollection<EmployeeCardViewModel>();

            var items = _employeeService.GetAllInclude();

            if (items != null)
            {
                foreach (var item in items)
                {
                    EmployeeCards.Add(EmployeeCardViewModel.LoadViewModel(Authenticator, Authenticator.CurrentAccount.Employee.LastName, 
                        item, TabViewModelNavigator, MainViewModel, tabViewModelFactory));
                }
            }
        }

        public override bool CanClosed() => true;
    }
}
