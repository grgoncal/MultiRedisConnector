using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace MultiRedisConnector
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            var buider = new ConfigurationBuilder().SetBasePath(env.ContentRootPath)
                                                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                                  .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                                                  .AddEnvironmentVariables();

            buider.Build();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDependencies();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
