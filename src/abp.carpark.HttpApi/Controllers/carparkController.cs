using abp.carpark.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abp.carpark.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class carparkController : AbpController
    {
        protected carparkController()
        {
            LocalizationResource = typeof(carparkResource);
        }
    }
}