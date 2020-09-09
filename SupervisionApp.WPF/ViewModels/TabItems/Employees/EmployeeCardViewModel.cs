using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Factories;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels.TabItems.Employees
{
    public class EmployeeCardViewModel : TabItemViewModelBase
    {
        public Employee Employee { get; set; }

        public ICommand EditItemCommand { get; }

        public EmployeeCardViewModel(IAuthenticator authenticator, string header, Employee employee, 
            ITabItemViewModelNavigator tabViewModelNavigator, MainViewModel mainViewModel, 
            ITabItemViewModelFactory tabViewModelFactory) : base(authenticator, header, mainViewModel, tabViewModelNavigator)
        {
            Employee = employee;

            EditItemCommand = new AddTabItemCommand(tabViewModelFactory, mainViewModel);
        }

        public static EmployeeCardViewModel LoadViewModel(IAuthenticator authenticator, string header, Employee employee, 
            ITabItemViewModelNavigator tabViewModelNavigator, MainViewModel mainViewModel, ITabItemViewModelFactory tabViewModelFactory)
        {
            var vm = new EmployeeCardViewModel(authenticator, header, employee, tabViewModelNavigator, mainViewModel, tabViewModelFactory);

            return vm;
        }
    }
}
