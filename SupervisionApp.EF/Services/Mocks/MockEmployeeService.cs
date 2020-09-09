using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services.Mocks
{
    public class MockEmployeeService : MockDataService<Employee>, IEmployeeService
    {
        public MockEmployeeService()
        {
            Items = new List<Employee>()
            {
                new Employee() { Id = 1, BirthDate = DateTime.Now, CreationDate = DateTime.Now, FirstName = "Дмитрий", LastName = "Амбурцев", Patronymic = "Андреевич" },
                new Employee() { Id = 2, BirthDate = DateTime.Now, CreationDate = DateTime.Now, FirstName = "Азат", LastName = "Магадеев", Patronymic = "Рифович" }
            };
        }
        public IEnumerable<Employee> GetAllInclude()
        {
            return Items;
        }

        public async Task<IEnumerable<Employee>> GetAllIncludeAsync()
        {
            return Items;
        }
    }
}
