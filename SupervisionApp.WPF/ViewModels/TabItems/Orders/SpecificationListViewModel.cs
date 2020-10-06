using Supervision.CommonModel.Models.Orders;
using Supervision.CommonModel.Services;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.WPF.Models.Accounts;
using System.Collections.Generic;

namespace SupervisionApp.WPF.ViewModels.TabItems.Orders
{
    public class SpecificationListViewModel : TabItemViewModelBase
    {
        private readonly ISpecificationService _specificationService;
        public IEnumerable<Specification> Specifications { get; set; }
        public SpecificationListViewModel(IAccountStore accountStore, string header, 
            ISpecificationService specificationService) : base(accountStore, header)
        {
            _specificationService = specificationService;
        }

        public static SpecificationListViewModel LoadViewModel(IAccountStore accountStore, string header, ISpecificationService specificationService)
        {
            var vm = new SpecificationListViewModel(accountStore, header, specificationService);
            vm.Load();
            return vm;
        }

        private async void Load()
        {
            try
            {
                IsBusy = true;
                Specifications = await _specificationService.GetAllByFactoryAsync(AccountStore.CurrentFactory);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public override bool CanClosed()
        {
            return true;
        }
    }
}
