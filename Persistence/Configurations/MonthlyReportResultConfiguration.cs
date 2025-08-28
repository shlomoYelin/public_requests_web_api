using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using public_requests.Domain.Entities;

namespace public_requests.Persistence.Configurations.Reports;

public class MonthlyReportResultConfiguration
    : IEntityTypeConfiguration<MonthlyReportResult>
{
    public void Configure(EntityTypeBuilder<MonthlyReportResult> e)
    {
        e.HasNoKey();
    }
}
