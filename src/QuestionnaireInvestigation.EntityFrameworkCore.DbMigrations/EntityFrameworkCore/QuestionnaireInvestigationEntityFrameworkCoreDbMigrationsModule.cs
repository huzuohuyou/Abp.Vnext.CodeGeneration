using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace QuestionnaireInvestigation.EntityFrameworkCore
{
    [DependsOn(
        typeof(QuestionnaireInvestigationEntityFrameworkCoreModule)
        )]
    public class QuestionnaireInvestigationEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QuestionnaireInvestigationMigrationsDbContext>();
        }
    }
}
