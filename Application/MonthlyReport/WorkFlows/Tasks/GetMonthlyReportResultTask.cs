using public_requests.Application.Data.MonthlyReportResult;
using public_requests.Application.MonthlyReport.WorkFlows.Tasks.Interfaces;
using public_requests.Domain.Entities;

namespace public_requests.Application.MonthlyReport.WorkFlows.Tasks
{
    public class GetMonthlyReportResultTask : IGetMonthlyReportResultTask
    {
        private readonly IGetMonthlyReportResultProcedure _getMonthlyReportResultProcedure;
        public GetMonthlyReportResultTask(IGetMonthlyReportResultProcedure getMonthlyReportResultProcedure)
        {
            _getMonthlyReportResultProcedure = getMonthlyReportResultProcedure;
        }

        public IEnumerable<MonthlyReportResult> Get()
        {
            return _getMonthlyReportResultProcedure.Get();
        }
    }
}
