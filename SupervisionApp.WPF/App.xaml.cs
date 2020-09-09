using Microsoft.Extensions.Hosting;
using SupervisionApp.WPF.DI;
using SupervisionApp.WPF.Models.Authenticators;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using SupervisionApp.WPF.ViewModels.Factories;
using SupervisionApp.WPF.Views;
using System.Windows;

namespace SupervisionApp.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.HostInit();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Ioc.AppHost.Start();

            Current.MainWindow = new MainWindow();
            Current.MainWindow.DataContext = new MainWindowViewModel(Current.MainWindow,
                Ioc.Resolve<IViewModelNavigator>(),
                Ioc.Resolve<IViewModelFactory>(),
                Ioc.Resolve<IAuthenticator>());
            Current.MainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await Ioc.AppHost.StopAsync();
            Ioc.AppHost.Dispose();

            base.OnExit(e);
        }
    }
}
