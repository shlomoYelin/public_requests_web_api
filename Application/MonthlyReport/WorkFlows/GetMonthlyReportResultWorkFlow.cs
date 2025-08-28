using public_requests.Application.MonthlyReport.WorkFlows.Interfaces;
using public_requests.Application.MonthlyReport.WorkFlows.Tasks.Interfaces;
using public_requests.Domain.Entities;

namespace public_requests.Application.MonthlyReport.WorkFlows
{
    public class GetMonthlyReportResultWorkFlow : IGetMonthlyReportResultWorkFlow
    {
        private readonly IGetMonthlyReportResultTask _getMonthlyReportResultTask;
        private readonly ILogger<GetMonthlyReportResultWorkFlow> _logger;

        public GetMonthlyReportResultWorkFlow(IGetMonthlyReportResultTask getMonthlyReportResultTask, ILogger<GetMonthlyReportResultWorkFlow> logger)
        {
            _getMonthlyReportResultTask = getMonthlyReportResultTask;
            _logger = logger;
        }

        public IEnumerable<MonthlyReportResult> Get()
        {
            try
            {
                return _getMonthlyReportResultTask.Get();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace} - {ex.Message}");
                throw;
            }
        }
    }
}
