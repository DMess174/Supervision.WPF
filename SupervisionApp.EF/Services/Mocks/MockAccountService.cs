using SupervisionApp.CommonModel.Enums;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services.Mocks
{
    public class MockAccountService : MockDataService<Account>, IAccountService
    {
        public MockAccountService()
        {
            Items = new List<Account>()
            { 
                new Account() 
                { 
                    Id = 1, CreationDate = DateTime.Now, Username = "amburtsevda",
                    PasswordHash = "AQAAAAEAACcQAAAAEOYj5XLaxOLZNlE18BjUsgjZjCjJHps/6wABfsNCBO6Zui+pIgFAs0JAXFBupz3fmA==", Role = UserRoles.Admin,
                    Employee = new Employee()
                    {
                        Id = 1, BirthDate = DateTime.Now, CreationDate = DateTime.Now, FirstName = "Дмитрий", LastName = "Амбурцев", Patronymic = "Андреевич"  
                    }
                }
            };
        }

        public bool CheckFactoryPermission(Account account, Factory factory)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> GetAllIncludeAsync()
        {
            return Items;
        }

        public Task<Account> GetByIdIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Account> GetByUsernameAsync(string username)
        {
            return Items.Where(i => i.Username == username).First();
        }
    }
}
