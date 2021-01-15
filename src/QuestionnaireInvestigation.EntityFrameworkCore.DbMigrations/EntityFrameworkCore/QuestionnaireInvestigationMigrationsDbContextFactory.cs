using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QuestionnaireInvestigation.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class QuestionnaireInvestigationMigrationsDbContextFactory : IDesignTimeDbContextFactory<QuestionnaireInvestigationMigrationsDbContext>
    {
        public QuestionnaireInvestigationMigrationsDbContext CreateDbContext(string[] args)
        {
            QuestionnaireInvestigationEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<QuestionnaireInvestigationMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new QuestionnaireInvestigationMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../QuestionnaireInvestigation.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
