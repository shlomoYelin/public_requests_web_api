using public_requests.Application.Requests.Validators;
using public_requests.Application.Requests.Validators.Interfaces;
using public_requests.Application.Requests.WorkFlows;
using public_requests.Application.Requests.WorkFlows.Interfaces;
using public_requests.Application.Requests.WorkFlows.Tasks;
using public_requests.Application.Requests.WorkFlows.Tasks.Interfaces;

namespace public_requests.Application.DependencyInjection.Requests
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRequestModule(this IServiceCollection services)
        {
            services.AddTransient<ICreateNewRequestValidator, CreateNewRequestValidator>();
            
            services.AddTransient<ICreateNewRequestWorkFlow, CreateNewRequestWorkFlow>();
            services.AddTransient<IGetAllRequestsWorkFlow, GetAllRequestsWorkFlow>();
            
            services.AddTransient<ICreateRequestTask, CreateRequestTask>();
            services.AddTransient<IGetAllRequestsTask, GetAllRequestsTask>();

            return services;
        }

    }
}
