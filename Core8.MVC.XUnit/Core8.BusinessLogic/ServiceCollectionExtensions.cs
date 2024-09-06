using Core8.BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core8.BusinessLogic
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomService, CustomService>();
        }
    }
}
