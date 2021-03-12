using Volo.Abp.Settings;

namespace abp.carpark.Settings
{
    public class carparkSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(carparkSettings.MySetting1));
        }
    }
}
