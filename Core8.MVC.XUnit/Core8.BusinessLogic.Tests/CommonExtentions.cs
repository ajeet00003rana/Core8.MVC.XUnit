using AutoFixture;
using AutoFixture.AutoNSubstitute;
using Bogus;
using Microsoft.Extensions.DependencyInjection;

//not in use
namespace Core8.BusinessLogic.Tests
{    

    public static class ServiceCollectionExtensions
    {
        public static void ConfigureBaseTestServices(this IServiceCollection services)
        {
            services.AddTransient(_ =>
            {
                var fixture = new Fixture()
                  .Customize(new AutoNSubstituteCustomization())
                  ;

                return fixture;
            });

            services.AddSingleton(_ => new Random());
            services.AddSingleton(_ => new Faker("en"));
        }
    }
}
