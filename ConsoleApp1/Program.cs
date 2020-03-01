using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostBuilderContext, services) =>
                {
                    var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ShopDbContext"].ConnectionString;

                    services.AddHostedService<Worker>();
                    services.AddScoped<ShopDbContext>(serviceProvider => new ShopDbContext(connectionString));
                });
    }
}
