using MvcMusicStore.Models;
using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace Seleno.Pages
{
    public class RegisterPage : Page<RegisterModel>
    {
        public HomePage CreateValidUser(RegisterModel model)
        {
            Input.Model(model);
            return Navigate.To<HomePage>(By.CssSelector("input[type='submit']"));
        }
    }
}