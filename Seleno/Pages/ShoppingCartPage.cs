using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace Seleno.Pages
{
    public class ShoppingCartPage : Page
    {
        public AddressAndPaymentPage Checkout()
        {
            return Navigate.To<AddressAndPaymentPage>(By.LinkText("Checkout >>"));
        }
    }
}