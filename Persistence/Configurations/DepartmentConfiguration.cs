using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using public_requests.Domain.Entities;

namespace public_requests.Persistence.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> e)
    {
        e.ToTable("Departments");
        e.HasKey(x => x.DepartmentId);

        e.Property(x => x.DepartmentId).ValueGeneratedOnAdd().HasColumnName("DepartmentId");
        e.Property(x => x.DepartmentName).HasColumnName("DepartmentName");
    }
}
