using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using SupervisionApp.EF.Services.Mocks;
using SupervisionApp.WPF.Models.Accounts;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using SupervisionApp.WPF.ViewModels.Base;
using SupervisionApp.WPF.ViewModels.Factories;
using SupervisionApp.WPF.ViewModels.TabItems;
using SupervisionApp.WPF.ViewModels.TabItems.Employees;
using System;

namespace SupervisionApp.WPF.DI
{
    public static class Ioc
    {
        public static readonly IHost AppHost;

        static Ioc()
        {
            AppHost = HostInit();

        }

        public static IHost HostInit()
        {
            return CreateHostBuilder().Build();
        }

        /// <summary>
        /// Return implementation instance from DI container
        /// </summary>
        /// <typeparam name="T">Service</typeparam>
        /// <returns></returns>
        public static T Resolve<T>() => AppHost.Services.GetRequiredService<T>();

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile("appsettings.json");
                    c.AddEnvironmentVariables();
                })
                .ConfigureServices((context, services) =>
                {
                    string commonConnectionString = context.Configuration.GetConnectionString("common-data");
                    services.AddDbContext<CommonDataContext>(o => o.UseSqlite(commonConnectionString));
                    services.AddSingleton<CommonDataContextFactory>(new CommonDataContextFactory(commonConnectionString));
                    services.AddSingleton<IAuthenticationService, AuthenticationService>();
                    services.AddSingleton<IAccountService, MockAccountService>();
                    services.AddSingleton<IEmployeeService, MockEmployeeService>();
                    services.AddSingleton<IFactoryService, MockFactoryService>();

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
                            Resolve<IAuthenticator>(),
                            Resolve<ViewModelRenavigatorDelegate<LoginFactoryViewModel>>());
                    });
                    services.AddSingleton<CreateViewModel<LoginFactoryViewModel>>(service =>
                    {
                        return () => LoginFactoryViewModel.LoadViewModel(
                            Resolve<IAuthenticator>(),
                            Resolve<ViewModelRenavigatorDelegate<LoginViewModel>>(),
                            Resolve<ViewModelRenavigatorDelegate<MainViewModel>>(),
                            Resolve<IFactoryService>());
                    });
                    services.AddSingleton<CreateTabViewModel<EmployeeListViewModel>>(service =>
                    {
                        return (args) => new EmployeeListViewModel(
                            Resolve<IAuthenticator>(),
                            "Персонал",
                            Resolve<ITabItemViewModelNavigator>(),
                            Resolve<MainViewModel>(),
                            Resolve<ITabItemViewModelFactory>(),
                            Resolve<IEmployeeService>());
                    });
                    services.AddSingleton<CreateTabViewModel<EmployeeViewModel>>(service =>
                    {
                        return (args) => EmployeeViewModel.LoadViewModel(
                            Resolve<IAuthenticator>(),
                            $"{args}",
                            Resolve<IEmployeeService>(),
                            Resolve<ITabItemViewModelNavigator>(),
                            Resolve<MainViewModel>(),
                            (Employee)args);
                    });

                    services.AddSingleton<IViewModelNavigator, ViewModelNavigator>();
                    services.AddSingleton<ITabItemViewModelNavigator, TabItemViewModelNavigator>();

                    services.AddSingleton<IAuthenticator, Authenticator>();
                    services.AddSingleton<IAccountStore, AccountStore>();

                    services.AddScoped<MainViewModel>();
                });
        }
    }
}
