using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QuestionnaireInvestigation.Data
{
    /* This is used if database provider does't define
     * IQuestionnaireInvestigationDbSchemaMigrator implementation.
     */
    public class NullQuestionnaireInvestigationDbSchemaMigrator : IQuestionnaireInvestigationDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}