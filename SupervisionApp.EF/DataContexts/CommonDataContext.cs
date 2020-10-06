using Microsoft.EntityFrameworkCore;
using Supervision.CommonModel.Models.Customers;
using Supervision.CommonModel.Models.Orders;
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
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<PID> PIDs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        public CommonDataContext(DbContextOptions options) : base(options) { }

    }
}
