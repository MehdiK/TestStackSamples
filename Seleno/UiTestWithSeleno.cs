using MvcMusicStore.Controllers;
using NUnit.Framework;
using Seleno.Pages;

namespace Seleno
{
    public class UiTestWithSeleno
    {
        [Test]
        public void Can_buy_an_Album_when_registered()
        {
            var orderedPage = Host.Instance.NavigateToInitialPage<HomeController, HomePage>(x => x.Index())
                .Menu
                .GoToAdminForAnonymousUser()
                .GoToRegisterPage()
                .CreateValidUser(ObjectMother.CreateRegisterModel())
                .GenreMenu
                .SelectGenreByName("Disco")
                .SelectAlbumByName("Le Freak")
                .AddAlbumToCart()
                .Checkout()
                .SubmitShippingInfo(ObjectMother.CreateShippingInfo(), "Free");

            Assert.AreEqual("Checkout Complete", orderedPage.Title);
        }
    }
}
