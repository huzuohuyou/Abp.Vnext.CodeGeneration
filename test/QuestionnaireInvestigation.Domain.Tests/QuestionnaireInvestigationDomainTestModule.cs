using QuestionnaireInvestigation.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuestionnaireInvestigation
{
    [DependsOn(
        typeof(QuestionnaireInvestigationEntityFrameworkCoreTestModule)
        )]
    public class QuestionnaireInvestigationDomainTestModule : AbpModule
    {

    }
}