using EmployeeManagement.Domain.Entities;
using EmployeeManagent.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagement.Persistence
{
    public class EmployeeManagementContext : DbContext
    {
        public EmployeeManagementContext(DbContextOptions options) : base(options) { }       
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeManagementContext).Assembly);
        }
    }
}
