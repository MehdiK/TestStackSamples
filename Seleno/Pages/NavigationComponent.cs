using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace Seleno.Pages
{
    public class NavigationComponent : UiComponent
    {
        public LogonPage GoToAdminForAnonymousUser()
        {
            return Navigate.To<LogonPage>(By.LinkText("Admin"));
        }
    }
}