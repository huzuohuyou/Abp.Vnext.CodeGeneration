using QuestionnaireInvestigation.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QuestionnaireInvestigation.Permissions
{
    public class QuestionnaireInvestigationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QuestionnaireInvestigationPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(QuestionnaireInvestigationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QuestionnaireInvestigationResource>(name);
        }
    }
}
