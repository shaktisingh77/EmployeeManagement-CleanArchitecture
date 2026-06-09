using EmployeeManagent.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagement.Persistence
{
    public class EmployeeManagementContext : DbContext
    {
        public EmployeeManagementContext(DbContextOptions options) : base(options) { }       
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            modelBuilder.Entity<Employee>().Property(x => x.Salary).HasPrecision(18, 2);
        }
    }
}
