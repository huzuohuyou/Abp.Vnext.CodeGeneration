using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace QuestionnaireInvestigation.Pages
{
    public class Index_Tests : QuestionnaireInvestigationWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
