using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
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
        private readonly IEmployeeService _employeeService;
        private readonly ITabItemViewModelFactory _tabViewModelFactory;

        public ITabItemViewModelNavigator TabViewModelNavigator { get; set; }

        public TabItemViewModelBase CurrentTab
        {
            get => TabViewModelNavigator.CurrentTab;
            set => TabViewModelNavigator.CurrentTab = value;
        }

        public ObservableCollection<TabItemViewModelBase> TabItems => TabViewModelNavigator.TabItems;

        public ICommand OpenTabCommand { get; }

        public ICommand CloseTabCommand { get; }

        public IList<ProductType> ProductTypes { get; private set; }

        public ObservableCollection<TabItemViewModelBase> Tabs { get; set; }

        public MainViewModel(IAuthenticator authenticator, ITabItemViewModelNavigator tabViewModelNavigator, 
            IEmployeeService employeeService = null, ITabItemViewModelFactory tabViewModelFactory = null) : base(authenticator)
        {
            _employeeService = employeeService;

            _tabViewModelFactory = tabViewModelFactory;

            TabViewModelNavigator = tabViewModelNavigator;

            TabViewModelNavigator.StateChanged += TabViewModelNavigator_StateChanged;

            OpenTabCommand = new AddTabItemCommand(_tabViewModelFactory, this);

            CloseTabCommand = new CloseTabItemCommand(TabViewModelNavigator);

            TabViewModelNavigator.TabItems = new ObservableCollection<TabItemViewModelBase>()
            {
                new EmployeeListViewModel(Authenticator, "Персонал", 
                TabViewModelNavigator, this, _tabViewModelFactory, _employeeService),
            };
            CurrentTab = TabViewModelNavigator.TabItems[0];

            ProductTypes = new List<ProductType>();
            foreach (var i in Authenticator.CurrentFactory.ProductTypes)
                ProductTypes.Add(i.ProductType);
        }

        private void TabViewModelNavigator_StateChanged()
        {
            OnPropertyChanged(nameof(CurrentTab));
            OnPropertyChanged(nameof(TabItems));
        }



    }
}
