using Volo.Abp.Modularity;

namespace QuestionnaireInvestigation
{
    [DependsOn(
        typeof(QuestionnaireInvestigationApplicationModule),
        typeof(QuestionnaireInvestigationDomainTestModule)
        )]
    public class QuestionnaireInvestigationApplicationTestModule : AbpModule
    {

    }
}