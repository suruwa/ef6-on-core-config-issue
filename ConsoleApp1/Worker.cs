using Microsoft.Extensions.Hosting;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Worker : IHostedService
    {
        private readonly ShopDbContext dbContext;

        public Worker(ShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Startup!");

            var users = await this.dbContext.Users.ToListAsync();

            Console.WriteLine("User count: " + users.Count);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Shutdown!");
        }
    }
}
