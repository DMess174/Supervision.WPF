using SupervisionApp.CommonModel.Enums;
using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.WPF.Commands;
using SupervisionApp.WPF.Models.Accounts;
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

        public UserRoles CurrentRole => _accountStore.CurrentRole;
        public TabItemCollectionViewModel TabsViewModel { get; }

        public ObservableCollection<TabItemViewModelBase> Tabs => TabsViewModel.Tabs;

        public TabItemViewModelBase CurrentTab
        {
            get => TabsViewModel.CurrentTab;
            set
            {
                TabsViewModel.CurrentTab = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenTabCommand { get; }

        public ICommand CloseTabCommand { get; }

        public IList<ProductType> ProductTypes { get; private set; }


        public MainViewModel(IAccountStore accountStore, IEmployeeService employeeService, ITabItemViewModelFactory tabViewModelFactory)
        {
            _accountStore = accountStore;

            _employeeService = employeeService;

            _tabViewModelFactory = tabViewModelFactory;

            TabsViewModel = new TabItemCollectionViewModel
            {
                Tabs = new ObservableCollection<TabItemViewModelBase>()
                {
                new EmployeeListViewModel(_accountStore, "Персонал", _employeeService),
                }
            };
            CurrentTab = Tabs[0];

            TabsViewModel.StateChanged += OnCurrentTab_StateChanged;

            OpenTabCommand = new AddTabItemCommand(_tabViewModelFactory, TabsViewModel);

            CloseTabCommand = new CloseTabItemCommand(TabsViewModel);

            ProductTypes = new List<ProductType>();
            foreach (var i in _accountStore.CurrentFactory.ProductTypes)
                ProductTypes.Add(i.ProductType);
        }

        private void OnCurrentTab_StateChanged()
        {
            OnPropertyChanged(nameof(CurrentTab));
        }
    }
}
