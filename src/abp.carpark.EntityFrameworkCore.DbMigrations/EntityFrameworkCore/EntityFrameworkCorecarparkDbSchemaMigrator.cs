using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abp.carpark.Data;
using Volo.Abp.DependencyInjection;

namespace abp.carpark.EntityFrameworkCore
{
    public class EntityFrameworkCorecarparkDbSchemaMigrator
        : IcarparkDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorecarparkDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the carparkMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<carparkMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}