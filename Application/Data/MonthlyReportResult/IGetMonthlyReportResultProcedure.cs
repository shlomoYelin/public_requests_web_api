namespace public_requests.Application.Data.MonthlyReportResult
{
    public interface IGetMonthlyReportResultProcedure
    {
        IEnumerable<Domain.Entities.MonthlyReportResult> Get();
    }
}
