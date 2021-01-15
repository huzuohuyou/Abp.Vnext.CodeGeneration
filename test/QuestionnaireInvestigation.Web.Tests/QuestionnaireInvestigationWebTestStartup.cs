using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace QuestionnaireInvestigation
{
    public class QuestionnaireInvestigationWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<QuestionnaireInvestigationWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}