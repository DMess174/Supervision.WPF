using SupervisionApp.WPF.ViewModels.Base;
using System;

namespace SupervisionApp.WPF.Models.ViewModelNavigators
{
    public enum ViewType
    {
        Login,
        Main
    }

    public interface IViewModelNavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        event Action StateChanged;
    }
}
