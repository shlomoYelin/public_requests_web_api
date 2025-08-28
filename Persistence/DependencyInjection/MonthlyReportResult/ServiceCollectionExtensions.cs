using public_requests.Application.Data.MonthlyReportResult;
using public_requests.Persistence.Data.MonthlyReportResult;

namespace public_requests.Persistence.DependencyInjection.MonthlyReportResult
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMonthlyReportData(this IServiceCollection services)
        {
            services.AddTransient<IGetMonthlyReportResultProcedure, GetMonthlyReportResultProcedure>();

            return services;
        }

    }
}
