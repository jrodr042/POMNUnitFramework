using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelsTestProject.UIElements.NavigationBar;
using System.Threading;
using PHPTravelsTestProject.ConfigDefaults;
using PHPTravelsTestProject.UIElements;

namespace PHPTravelsTestProject
{
    public static class NavigateTo
    {
        public static void NavigateToFlights(IWebDriver driver)
        {
            SocialAppsIconLinks links = new SocialAppsIconLinks(driver);

            links.FacebookIcon.Click();

            Thread.Sleep(1000);
        }

        //naigate to the hotels main page
        public static void NavigateToHotels(IWebDriver driver)
        {
            NavBar navBar = new NavBar(driver);

            navBar.Hotels.Click();

            //Thread.Sleep(1000);
            
        }

        public static void NavigateToSignUp(IWebDriver driver)
        {
            NavBar navBar = new NavBar(driver);
            navBar.myAccount.Click();

            //locate the dropdown menu item for signup
            IWebElement elements = driver.FindElement(By.XPath(TestVariables.Credentials.AccountDropDown.SignUp));
            elements.Click();
        }


        public static void NavigateToLogin(IWebDriver driver)
        {
            NavBar navBar = new NavBar(driver);
            navBar.myAccount.Click();

            //locate the dropdown menu item for login
            IWebElement elements = driver.FindElement(By.XPath(TestVariables.Credentials.AccountDropDown.Login));

            elements.Click();
        }

    }
}
