using Volo.Abp.Bundling;

namespace abp.carpark.Blazor
{
    public class carparkBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}