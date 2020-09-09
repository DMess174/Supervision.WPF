using Microsoft.EntityFrameworkCore;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;

namespace SupervisionApp.EF.DataContexts
{
    public class CommonDataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Factory> Factory { get; set; }
        public DbSet<EmployeeFactories> EmployeeFactories { get; set; }

        public CommonDataContext(DbContextOptions options) : base(options) { }

    }
}
