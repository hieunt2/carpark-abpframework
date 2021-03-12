using abp.carpark.Localization;
using Volo.Abp.AspNetCore.Components;

namespace abp.carpark.Blazor
{
    public abstract class carparkComponentBase : AbpComponentBase
    {
        protected carparkComponentBase()
        {
            LocalizationResource = typeof(carparkResource);
        }
    }
}
