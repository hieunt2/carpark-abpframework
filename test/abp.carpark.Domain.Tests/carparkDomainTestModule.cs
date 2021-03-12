using abp.carpark.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abp.carpark
{
    [DependsOn(
        typeof(carparkEntityFrameworkCoreTestModule)
        )]
    public class carparkDomainTestModule : AbpModule
    {

    }
}