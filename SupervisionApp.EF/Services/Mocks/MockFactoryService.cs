using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Models.Products;
using SupervisionApp.CommonModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupervisionApp.EF.Services.Mocks
{
    public class MockFactoryService : MockDataService<Factory>, IFactoryService
    {
        public MockFactoryService()
        {
            Items = new List<Factory>()
            {
                new Factory() { City = "Челябинск", CreationDate = DateTime.Now, FullName = "ООО \"Корнет\"", ShortName = "ООО \"Корнет\"", Id = 1,
                    ProductTypes = new List<FactoryProductType>()
                    {
                        new FactoryProductType() 
                        { 
                            Id = 1,
                            ProductType = new ProductType() { Id = 1, CreationDate = DateTime.Now, FullName = "Задвижка шиберная", ShortName = "ЗШ"},
                        }
                    }, 
                    EmployeeFactories = new List<EmployeeFactories>()
                    {
                        new EmployeeFactories() 
                        { 
                            Id = 1,
                            Employee = new Employee()
                            {
                                Id = 1, BirthDate = DateTime.Now, CreationDate = DateTime.Now, FirstName = "Дмитрий", LastName = "Амбурцев", Patronymic = "Андреевич"
                            }
                        }
                    }
                }
            };
        }

        public async Task<IEnumerable<Factory>> GetAllIncludeAsync()
        {
            return Items;
        }

        public async Task<IEnumerable<Factory>> GetEmployeeFactories(Employee employee)
        {
            return Items.Where(i => i.EmployeeFactories.Any(e => e.Employee.Id == employee.Id)).ToList();
        }
    }
}
