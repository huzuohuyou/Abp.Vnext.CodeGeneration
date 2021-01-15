using QuestionnaireInvestigation.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QuestionnaireInvestigation.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class QuestionnaireInvestigationPageModel : AbpPageModel
    {
        protected QuestionnaireInvestigationPageModel()
        {
            LocalizationResourceType = typeof(QuestionnaireInvestigationResource);
        }
    }
}