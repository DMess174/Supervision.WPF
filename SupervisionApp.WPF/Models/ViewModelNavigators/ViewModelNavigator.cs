using SupervisionApp.WPF.ViewModels.Base;
using System;

namespace SupervisionApp.WPF.Models.ViewModelNavigators
{
    public class ViewModelNavigator : IViewModelNavigator
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}
