using Microsoft.EntityFrameworkCore;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Models.Products;

namespace SupervisionApp.EF.DataContexts
{
    public class CommonDataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeFactories> EmployeeFactories { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryProductType> FactoryProductTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<SubdivisionDepartment> SubdivisionDepartments { get; set; }

        public CommonDataContext(DbContextOptions options) : base(options) { }

    }
}
