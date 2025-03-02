using Microsoft.EntityFrameworkCore;
using CrudProject.Models; // Adjust namespace

namespace CrudProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=crudschema;user=root;password=12345678;",
                    new MySqlServerVersion(new Version(8, 0, 23))); // Change version if needed
            }
        }
    }
}
