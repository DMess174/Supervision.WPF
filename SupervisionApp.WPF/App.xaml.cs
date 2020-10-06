using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using SupervisionApp.EF.Services;
using SupervisionApp.EF.Services.FactoryService;
using SupervisionApp.WPF.Models.Accounts;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using SupervisionApp.WPF.ViewModels.Base;
using SupervisionApp.WPF.ViewModels.Factories;
using SupervisionApp.WPF.ViewModels.TabItems;
using SupervisionApp.WPF.ViewModels.TabItems.Employees;
using SupervisionApp.WPF.ViewModels.TabItems.Orders;
using SupervisionApp.WPF.Views;
using System.Windows;

namespace SupervisionApp.WPF
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        private static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile("appsettings.json");
                    c.AddEnvironmentVariables();
                })
                .ConfigureServices((context, services) =>
                {
                    string commonDataConnectionString = context.Configuration.GetConnectionString("common-data");
                    string factoryDataConnectionString = context.Configuration.GetConnectionString("kornet-data");
                    services.AddDbContext<CommonDataContext>(o => o.UseSqlServer(commonDataConnectionString));
                    services.AddSingleton<CommonDataContextFactory>(new CommonDataContextFactory(commonDataConnectionString));
                    services.AddSingleton<IAuthenticationService, AuthenticationService>();
                    services.AddSingleton<IAccountService, AccountService>();
                    services.AddSingleton<IDepartmentService, DepartmentService>();
                    services.AddSingleton<IEmployeeFactoriesService, EmployeeFactoriesService>();
                    services.AddSingleton<IEmployeeService, EmployeeService>();
                    services.AddSingleton<IFactoryProductTypeService, FactoryProductTypeService>();
                    services.AddSingleton<IFactoryService, FactoryService>();
                    services.AddSingleton<IPostService, PostService>();
                    services.AddSingleton<IProductTypeService, ProductTypeService>();
                    services.AddSingleton<ISubdivisionDepartmentService, SubdivisionDepartmentService>();
                    services.AddSingleton<ISubdivisionService, SubdivisionService>();
                    services.AddSingleton<ISpecificationService, SpecificationService>();
                    services.AddSingleton<IPIDService, PIDService>();

                    services.AddSingleton<IPasswordHasher<Account>, PasswordHasher<Account>>();

                    services.AddSingleton<IViewModelFactory, ViewModelFactory>();
                    services.AddSingleton<ITabItemViewModelFactory, TabItemViewModelFactory>();

                    services.AddSingleton<CreateViewModel<MainViewModel>>(service =>
                    {
                        return () => service.GetRequiredService<MainViewModel>();
                    });

                    services.AddSingleton<ViewModelRenavigatorDelegate<MainViewModel>>();
                    services.AddSingleton<ViewModelRenavigatorDelegate<LoginViewModel>>();
                    services.AddSingleton<ViewModelRenavigatorDelegate<LoginFactoryViewModel>>();
                    services.AddSingleton<CreateViewModel<LoginViewModel>>(service =>
                    {
                        return () => LoginViewModel.LoadViewModel(
                            service.GetRequiredService<IAuthenticator>(),
                            service.GetRequiredService<ViewModelRenavigatorDelegate<LoginFactoryViewModel>>());
                    });
                    services.AddSingleton<CreateViewModel<LoginFactoryViewModel>>(service =>
                    {
                        return () => LoginFactoryViewModel.LoadViewModel(
                            service.GetRequiredService<IAuthenticator>(),
                            service.GetRequiredService<ViewModelRenavigatorDelegate<LoginViewModel>>(),
                            service.GetRequiredService<ViewModelRenavigatorDelegate<MainViewModel>>(),
                            service.GetRequiredService<IFactoryService>());
                    });
                    services.AddSingleton<CreateTabViewModel<EmployeeListViewModel>>(service =>
                    {
                        return (args) => new EmployeeListViewModel(
                            service.GetRequiredService<IAccountStore>(),
                            "Персонал",
                            service.GetRequiredService<IEmployeeService>());
                    });
                    services.AddSingleton<CreateTabViewModel<EmployeeViewModel>>(service =>
                    {
                        return (args) => EmployeeViewModel.LoadViewModel(
                            service.GetRequiredService<IAccountStore>(),
                            $"{args}",
                            service.GetRequiredService<IEmployeeService>(),
                            (Employee)args);
                    });
                    services.AddSingleton<CreateTabViewModel<SpecificationListViewModel>>(service =>
                    {
                        return (args) => SpecificationListViewModel.LoadViewModel(
                            service.GetRequiredService<IAccountStore>(),
                            "Спецификации",
                            service.GetRequiredService<ISpecificationService>());
                    });

                    services.AddSingleton<IViewModelNavigator, ViewModelNavigator>();

                    services.AddSingleton<IAuthenticator, Authenticator>();
                    services.AddSingleton<IAccountStore, AccountStore>();

                    services.AddScoped<MainViewModel>();
                });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            Current.MainWindow = new MainWindow();
            Current.MainWindow.DataContext = new MainWindowViewModel(Current.MainWindow,
                _host.Services.GetRequiredService<IViewModelNavigator>(),
                _host.Services.GetRequiredService<IViewModelFactory>(),
                _host.Services.GetRequiredService<IAccountStore>());
            Current.MainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
