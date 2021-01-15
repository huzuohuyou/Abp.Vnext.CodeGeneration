using System.Threading.Tasks;

namespace QuestionnaireInvestigation.Data
{
    public interface IQuestionnaireInvestigationDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
