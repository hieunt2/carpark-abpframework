using System;
using System.Collections.Generic;
using System.Text;
using abp.carpark.Localization;
using Volo.Abp.Application.Services;

namespace abp.carpark
{
    /* Inherit your application services from this class.
     */
    public abstract class carparkAppService : ApplicationService
    {
        protected carparkAppService()
        {
            LocalizationResource = typeof(carparkResource);
        }
    }
}
