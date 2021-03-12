using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abp.carpark.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class carparkBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "carpark";
    }
}
