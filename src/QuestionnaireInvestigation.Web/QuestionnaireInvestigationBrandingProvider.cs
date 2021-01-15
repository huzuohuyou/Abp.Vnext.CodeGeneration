using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace QuestionnaireInvestigation.Web
{
    [Dependency(ReplaceServices = true)]
    public class QuestionnaireInvestigationBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "QuestionnaireInvestigation";
    }
}
