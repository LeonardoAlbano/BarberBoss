using BarberBoss.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarberBoss.Infrastructure.DataAccess
{
    public class BarberBossDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=barberbossdb;Uid=root;Pwd=@Password123;";

            var version = new Version(8, 0, 42);
            var serverVersion = new MySqlServerVersion(version);

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
