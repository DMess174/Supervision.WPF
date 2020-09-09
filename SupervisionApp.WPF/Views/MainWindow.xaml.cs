using SupervisionApp.WPF.ViewModels;
using System;
using System.Windows;

namespace SupervisionApp.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AppWindow_Deactivated(object sender, EventArgs e)
        {
            // Show overlay if we lose focus
            ((MainWindowViewModel)DataContext).DimmableOverlayVisible = true;
        }

        private void AppWindow_Activated(object sender, EventArgs e)
        {
            // Hide overlay if we are focused
            ((MainWindowViewModel)DataContext).DimmableOverlayVisible = false;
        }
    }
}
