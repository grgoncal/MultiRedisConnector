using Microsoft.Extensions.DependencyInjection;

namespace MultiRedisConnector.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection serviceCollection)
        {


            return serviceCollection;
        }
    }
}
 