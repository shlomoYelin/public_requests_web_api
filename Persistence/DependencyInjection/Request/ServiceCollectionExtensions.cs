using public_requests.Application.Data.Request.Command;
using public_requests.Application.Data.Request.Query;
using public_requests.Persistence.Data.Request.Command;
using public_requests.Persistence.Data.Request.Query;

namespace public_requests.Persistence.DependencyInjection.Request
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRequestData(this IServiceCollection services)
        {
            services.AddTransient<IGetAllRequestsQuery, GetAllRequestsQuery>();

            services.AddTransient<ICreateRequestCommand, CreateRequestCommand>();
            return services;
        }

    }
}
