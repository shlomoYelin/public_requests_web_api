
using public_requests.Application.DependencyInjection.Requests;

namespace public_requests.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddRequestModule();
            return services;
        }

    }
}
