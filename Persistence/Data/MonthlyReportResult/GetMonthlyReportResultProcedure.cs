using Microsoft.EntityFrameworkCore;
using public_requests.Application.Data.MonthlyReportResult;

namespace public_requests.Persistence.Data.MonthlyReportResult
{
    public class GetMonthlyReportResultProcedure : IGetMonthlyReportResultProcedure
    {
        private readonly AppDbContext _appContext;

        public GetMonthlyReportResultProcedure(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Domain.Entities.MonthlyReportResult> Get()
        {
            return _appContext.MonthlyReportResults
                 .FromSqlRaw("EXEC dbo.GetMonthlyDepartmentReport")
                   .ToList();
        }
    }
}
