using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Repositories
{
    public class ShopDbContext : DbContext
    {
        // Uncomment this to in order to get update-database working with
        // -connectionString "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EF6Test1;Integrated Security=True" -connectionProviderName "System.Data.SqlClient"
        // Parameters
        ///// <summary>
        ///// Creates a new database context
        ///// </summary>
        //public ShopDbContext()
        //{

        //}

        // This overrides the -connectionString parameter in update-database, but EF cannot for some reason locate the connection string in App.config
        // Comment out in order to run update-database with -connectionString and -connectionProviderName parameters
        /// <summary>
        /// creates a new database context
        /// </summary>
        public ShopDbContext()
            : base("name=ShopDbContext")
        {

        }

        /// <summary>
        /// Creates a new database context using the specified connection
        /// string.
        /// </summary>
        public ShopDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }               
    }
}
