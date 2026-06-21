using EmployeeManagent.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("tblEmployee");

        builder.HasKey(e => e.EmployeeId);

        builder.Property(e => e.EmployeeName)
               .HasMaxLength(100);

        builder.Property(e => e.EmailId)
               .HasMaxLength(100);

        builder.Property(e => e.PhoneNumber)
               .HasMaxLength(20);

        builder.Property(e => e.Salary)
               .HasPrecision(18, 2);
    }
}