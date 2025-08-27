using public_requests.Persistence.DependencyInjection.Request;

namespace public_requests.Persistence.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddRequestData();
            return services;
        }

    }
}
