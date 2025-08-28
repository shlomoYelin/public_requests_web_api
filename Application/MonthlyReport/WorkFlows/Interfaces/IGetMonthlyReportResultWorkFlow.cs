using public_requests.Domain.Entities;

namespace public_requests.Application.MonthlyReport.WorkFlows.Interfaces
{
    public interface IGetMonthlyReportResultWorkFlow
    {
        IEnumerable<MonthlyReportResult> Get();
    }
}
