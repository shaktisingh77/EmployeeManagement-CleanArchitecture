using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("tblRole");

        builder.HasKey(r => r.RoleId);

        builder.Property(r => r.RoleName)
               .HasMaxLength(50)
               .IsRequired();
    }
}