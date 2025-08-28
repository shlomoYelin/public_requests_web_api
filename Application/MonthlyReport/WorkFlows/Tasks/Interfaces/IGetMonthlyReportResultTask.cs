using public_requests.Domain.Entities;

namespace public_requests.Application.MonthlyReport.WorkFlows.Tasks.Interfaces
{
    public interface IGetMonthlyReportResultTask
    {
        IEnumerable<MonthlyReportResult> Get();
    }
}
