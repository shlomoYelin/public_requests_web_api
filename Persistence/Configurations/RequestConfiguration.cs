using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using public_requests.Domain.Entities;

namespace public_requests.Persistence.Configurations;

public class RequestConfiguration : IEntityTypeConfiguration<Request>
{
    public void Configure(EntityTypeBuilder<Request> e)
    {
        e.ToTable("Requests", "dbo");

        e.HasKey(x => x.RequestId);

        e.Property(x => x.RequestId)
         .ValueGeneratedOnAdd();

        e.Property(x => x.FullName);

        e.Property(x => x.Phone);

        e.Property(x => x.Email);

        e.Property(x => x.Description);

        e.Property(x => x.DepartmentId);

        e.Property(x => x.CreatedAt)
        .HasDefaultValueSql("SYSUTCDATETIME()") 
        .ValueGeneratedOnAdd();

        e.HasOne(x => x.Department)
         .WithMany(d => d.Requests)
         .HasForeignKey(x => x.DepartmentId)
         .HasConstraintName("FK_Requests_Department");
    }
}
