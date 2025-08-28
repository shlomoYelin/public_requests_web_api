using public_requests.Application.MonthlyReport.WorkFlows.Tasks.Interfaces;
using public_requests.Application.MonthlyReport.WorkFlows.Tasks;
using public_requests.Application.MonthlyReport.WorkFlows.Interfaces;
using public_requests.Application.MonthlyReport.WorkFlows;

namespace public_requests.Application.DependencyInjection.MonthlyReport
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMonthlyReportModule(this IServiceCollection services)
        {
            services.AddTransient<IGetMonthlyReportResultTask, GetMonthlyReportResultTask>();
            services.AddTransient<IGetMonthlyReportResultWorkFlow, GetMonthlyReportResultWorkFlow>();
            return services;
        }

    }
}
