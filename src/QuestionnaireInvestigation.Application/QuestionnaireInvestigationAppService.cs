using System;
using System.Collections.Generic;
using System.Text;
using QuestionnaireInvestigation.Localization;
using Volo.Abp.Application.Services;

namespace QuestionnaireInvestigation
{
    /* Inherit your application services from this class.
     */
    public abstract class QuestionnaireInvestigationAppService : ApplicationService
    {
        protected QuestionnaireInvestigationAppService()
        {
            LocalizationResource = typeof(QuestionnaireInvestigationResource);
        }
    }
}
