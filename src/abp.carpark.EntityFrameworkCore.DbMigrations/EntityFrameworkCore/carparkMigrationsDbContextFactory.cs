using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abp.carpark.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class carparkMigrationsDbContextFactory : IDesignTimeDbContextFactory<carparkMigrationsDbContext>
    {
        public carparkMigrationsDbContext CreateDbContext(string[] args)
        {
            carparkEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<carparkMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new carparkMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abp.carpark.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
