using SupervisionApp.ModelAPI;
using SupervisionApp.WPF.Commands.Base;
using SupervisionApp.WPF.Models.ViewModelNavigators;
using SupervisionApp.WPF.ViewModels.Factories;
using SupervisionApp.WPF.ViewModels.TabItems;

namespace SupervisionApp.WPF.Commands
{
    public class AddTabItemCommand : CommandBase
    {
        private readonly TabItemCollectionViewModel _tabsViewModel;
        private readonly ITabItemViewModelFactory _tabViewModelFactory;

        public AddTabItemCommand(ITabItemViewModelFactory tabViewModelFactory, TabItemCollectionViewModel tabsViewModel)
        {
            _tabViewModelFactory = tabViewModelFactory;
            _tabsViewModel = tabsViewModel;
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
            _tabsViewModel.OpenTab(_tabViewModelFactory.CreateTabViewModel(tabViewType, entity));
        }
    }
}