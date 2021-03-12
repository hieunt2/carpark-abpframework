using abp.carpark.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abp.carpark.Permissions
{
    public class carparkPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(carparkPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(carparkPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<carparkResource>(name);
        }
    }
}
