using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace abp.carpark.EntityFrameworkCore
{
    [DependsOn(
        typeof(carparkEntityFrameworkCoreModule)
        )]
    public class carparkEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<carparkMigrationsDbContext>();
        }
    }
}
