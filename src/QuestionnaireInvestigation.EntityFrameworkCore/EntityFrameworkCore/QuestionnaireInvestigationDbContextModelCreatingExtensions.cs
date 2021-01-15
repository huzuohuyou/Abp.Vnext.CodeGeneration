using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace QuestionnaireInvestigation.EntityFrameworkCore
{
    public static class QuestionnaireInvestigationDbContextModelCreatingExtensions
    {
        public static void ConfigureQuestionnaireInvestigation(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(QuestionnaireInvestigationConsts.DbTablePrefix + "YourEntities", QuestionnaireInvestigationConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}