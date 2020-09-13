using SupervisionApp.ModelAPI;
using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels;
using SupervisionApp.WPF.ViewModels.Factories;

namespace SupervisionApp.WPF.Commands
{
    public class AddTabItemCommand : CommandBase
    {
        private readonly ITabItemViewModelNavigator _tabItemViewModelNavigator;
        private readonly ITabItemViewModelFactory _tabViewModelFactory;

        public AddTabItemCommand(ITabItemViewModelFactory tabViewModelFactory, ITabItemViewModelNavigator tabItemViewModelNavigator)
        {
            _tabViewModelFactory = tabViewModelFactory;
            _tabItemViewModelNavigator = tabItemViewModelNavigator;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (parameter is object[] values)
            {
                if (values[0] is TabItemViewType tabViewType)
                {
                    if (values[1] is BaseEntity entity)
                        OpenTab(tabViewType, entity);
                    else
                        OpenTab(tabViewType);
                }
            }
            else if (parameter is TabItemViewType tabViewType)
            {
                OpenTab(tabViewType);
            }
        }

        public void OpenTab(TabItemViewType tabViewType, BaseEntity entity = null)
        {
            _tabItemViewModelNavigator.OpenTab(_tabViewModelFactory.CreateTabViewModel(tabViewType, entity));
        }
    }
}