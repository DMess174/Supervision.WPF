using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Accounts;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Base;
using SupervisionApp.WPF.ViewModels.Factories;
using SupervisionApp.WPF.ViewModels.TabItems;
using SupervisionApp.WPF.ViewModels.TabItems.Employees;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SupervisionApp.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IAccountStore _accountStore;
        private readonly IEmployeeService _employeeService;
        private readonly ITabItemViewModelFactory _tabViewModelFactory;

        private readonly ITabItemViewModelNavigator _tabViewModelNavigator;

        public TabItemViewModelBase CurrentTab { get; set; }

        public ObservableCollection<TabItemViewModelBase> Tabs => _tabViewModelNavigator.TabItems;

        public ICommand OpenTabCommand { get; }

        public ICommand CloseTabCommand { get; }

        public IList<ProductType> ProductTypes { get; private set; }


        public MainViewModel(IAccountStore accountStore, ITabItemViewModelNavigator tabViewModelNavigator, 
            IEmployeeService employeeService, ITabItemViewModelFactory tabViewModelFactory)
        {
            _accountStore = accountStore;

            _employeeService = employeeService;

            _tabViewModelFactory = tabViewModelFactory;

            _tabViewModelNavigator = tabViewModelNavigator;

            _tabViewModelNavigator.StateChanged += TabViewModelNavigator_StateChanged;

            OpenTabCommand = new AddTabItemCommand(_tabViewModelFactory, _tabViewModelNavigator);

            CloseTabCommand = new CloseTabItemCommand(_tabViewModelNavigator);

            _tabViewModelNavigator.TabItems = new ObservableCollection<TabItemViewModelBase>()
            {
                new EmployeeListViewModel(_accountStore, "Персонал", _employeeService),
            };
            CurrentTab = Tabs[0];

            ProductTypes = new List<ProductType>();
            foreach (var i in _accountStore.CurrentFactory.ProductTypes)
                ProductTypes.Add(i.ProductType);
        }

        private void TabViewModelNavigator_StateChanged()
        {
            OnPropertyChanged(nameof(Tabs));
            OnPropertyChanged(nameof(CurrentTab));
        }



    }
}
