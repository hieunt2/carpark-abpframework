using Volo.Abp.Modularity;

namespace abp.carpark
{
    [DependsOn(
        typeof(carparkApplicationModule),
        typeof(carparkDomainTestModule)
        )]
    public class carparkApplicationTestModule : AbpModule
    {

    }
}