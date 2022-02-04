using System.Threading.Tasks;
using NhatKyDienTu.Models.TokenAuth;
using NhatKyDienTu.Web.Controllers;
using Shouldly;
using Xunit;

namespace NhatKyDienTu.Web.Tests.Controllers
{
    public class HomeController_Tests: NhatKyDienTuWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}