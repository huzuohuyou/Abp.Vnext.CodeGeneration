using QuestionnaireInvestigation.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QuestionnaireInvestigation.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class QuestionnaireInvestigationController : AbpController
    {
        protected QuestionnaireInvestigationController()
        {
            LocalizationResource = typeof(QuestionnaireInvestigationResource);
        }
    }
}