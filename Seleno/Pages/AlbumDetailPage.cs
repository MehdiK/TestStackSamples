using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace Seleno.Pages
{
    public class AlbumDetailPage : Page
    {
        public ShoppingCartPage AddAlbumToCart()
        {
            return Navigate.To<ShoppingCartPage>(By.LinkText("Add to cart"));
        }
    }
}