using SupervisionApp.CommonModel.Services;
using SupervisionApp.ModelAPI;
using SupervisionApp.WPF.Commands.Base;
using System.Threading.Tasks;

namespace SupervisionApp.WPF.Commands
{
    public class UpdateEntityCommand<T> : AsyncCommand where T : BaseEntity
    {
        private readonly IDataService<T> _dataService;

        public UpdateEntityCommand(IDataService<T> dataService)
        {
            _dataService = dataService;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            if (parameter is T entity)
            {
                await _dataService.UpsertAsync(entity);
            }
        }
    }
}
