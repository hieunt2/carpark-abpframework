using abp.carpark.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abp.carpark.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(carparkEntityFrameworkCoreDbMigrationsModule),
        typeof(carparkApplicationContractsModule)
        )]
    public class carparkDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
