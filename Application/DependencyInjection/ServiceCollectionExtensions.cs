
using public_requests.Application.DependencyInjection.MonthlyReport;
using public_requests.Application.DependencyInjection.Requests;

namespace public_requests.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddRequestModule();
            services.AddMonthlyReportModule();
            return services;
        }

    }
}
