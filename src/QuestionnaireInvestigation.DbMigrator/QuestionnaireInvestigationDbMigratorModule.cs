using QuestionnaireInvestigation.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace QuestionnaireInvestigation.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(QuestionnaireInvestigationEntityFrameworkCoreDbMigrationsModule),
        typeof(QuestionnaireInvestigationApplicationContractsModule)
        )]
    public class QuestionnaireInvestigationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
