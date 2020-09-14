using Microsoft.EntityFrameworkCore;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using SupervisionApp.EF.DataContexts;
using SupervisionApp.EF.DataContexts.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services
{
    public class AccountService : DataService<Account>, IAccountService
    {
        public AccountService(CommonDataContextFactory contextFactory) : base(contextFactory)
        {
        }

        public async Task<Account> GetByUsernameAsync(string username)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {

                return await context.Accounts
                    .Include(a => a.Employee)
                    .ThenInclude(a => a.EmployeeFactories)
                    .ThenInclude(a => a.Factory)
                    .SingleOrDefaultAsync(a => a.Username == username);
            }
        }

        public async Task<IEnumerable<Account>> GetAllIncludeAsync()
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Account> entities = await context.Accounts
                    .Include(a => a.Employee)
                    .ThenInclude(a => a.Post)
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<Account> GetByIdIncludeAsync(int id)
        {
            using (CommonDataContext context = _contextFactory.CreateDbContext())
            {
                Account entity = await context.Accounts
                    .Include(a => a.Employee)
                    .ThenInclude(a => a.EmployeeFactories)
                    .ThenInclude(a => a.Factory)
                    .FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }
    }
}
