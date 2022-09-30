using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Services.Models;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext() {}
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("dbconnection.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("ConnectionStrings");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Show> Shows { get; set; }
    }
}