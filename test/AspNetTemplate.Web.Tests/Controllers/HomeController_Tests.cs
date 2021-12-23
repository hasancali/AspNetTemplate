using System.Threading.Tasks;
using AspNetTemplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace AspNetTemplate.Web.Tests.Controllers
{
    public class HomeController_Tests: AspNetTemplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
