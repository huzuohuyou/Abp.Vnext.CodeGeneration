using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using QuestionnaireInvestigation.Localization;
using QuestionnaireInvestigation.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace QuestionnaireInvestigation.Web.Menus
{
    public class QuestionnaireInvestigationMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<QuestionnaireInvestigationResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(QuestionnaireInvestigationMenus.Home, l["Menu:Home"], "~/"));
            context.Menu.Items.Insert(1, new ApplicationMenuItem(QuestionnaireInvestigationMenus.Home, l["调查问卷"], "~/Questions"));

            

        }
    }
}
