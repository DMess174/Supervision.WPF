using Microsoft.EntityFrameworkCore;
using System;

namespace SupervisionApp.EF.DataContexts.Factories
{
    public class DataContextFactory<T> where T : DbContext
    {
        private readonly string _connectionString;

        public DataContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public T CreateDbContext()
        {
            DbContextOptionsBuilder<T> options = new DbContextOptionsBuilder<T>();

            options.UseSqlite(_connectionString);

            return (T)Activator.CreateInstance(typeof(T), options.Options);
        }
    }
}