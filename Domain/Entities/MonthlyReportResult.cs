namespace public_requests.Domain.Entities
{
    public class MonthlyReportResult
    {
        public int DepartmentId { get; set; }
        public int CurrentMonthRequests { get; set; }
        public int PreviousMonthRequests { get; set; }
        public int LastYearSameMonthRequests { get; set; }
    }
}
