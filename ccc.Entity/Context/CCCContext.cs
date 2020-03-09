using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ccc.Entity.Context
{
    public partial class CCCContext
    {
        public CCCContext(DbContextOptions<CCCContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.OnModelCreating_Identity(modelBuilder);
            this.OnModelCreating_Lookup(modelBuilder);
            this.OnModelCreating_Common(modelBuilder);
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CCCContext>
        {
            public CCCContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<CCCContext>();
                var connectionString = configuration.GetConnectionString("db");
                builder.UseSqlServer(connectionString);
                return new CCCContext(builder.Options);
            }
        }
    }
}
