using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abp.carpark
{
    [Dependency(ReplaceServices = true)]
    public class carparkBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "carpark";
    }
}
