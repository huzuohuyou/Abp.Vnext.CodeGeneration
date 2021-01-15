using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestionnaireInvestigation.Data;
using Volo.Abp.DependencyInjection;

namespace QuestionnaireInvestigation.EntityFrameworkCore
{
    public class EntityFrameworkCoreQuestionnaireInvestigationDbSchemaMigrator
        : IQuestionnaireInvestigationDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreQuestionnaireInvestigationDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the QuestionnaireInvestigationMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<QuestionnaireInvestigationMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}