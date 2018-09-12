using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelsTestProject.UIElements.NavigationBar;
using System.Threading;
using PHPTravelsTestProject.ConfigDefaults;
using PHPTravelsTestProject.UIElements;
using System.Collections.Generic;
using System;

namespace PHPTravelsTestProject
{
    public static class NavigateTo
    {
        //private variables
        private static int firstValueOnTable = 1;
        private static IReadOnlyList<IWebElement> tableChilds;
        private static HotelsFilterSearch hotelPage;

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

        public static void NavigateBackToProfileWhenLogin(IWebDriver driver)
        {
            NavBar navBar = new NavBar(driver);
            navBar.LoggedInAccount.Click();

            //find the account element
            IWebElement elements = driver.FindElement(By.XPath(TestVariables.Credentials.AccountDropDown.AccountPage));

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


        public static void NavigateToItemOnHotelSearch(IWebDriver driver)
        {
            //initialize navbar
            NavBar navBar = new NavBar(driver);
            navBar.Hotels.Click();
            Thread.Sleep(1000);

            //initialize hotelsPage
            hotelPage = new HotelsFilterSearch(driver);
            tableChilds = hotelPage.HotelTable.FindElements(By.TagName("tr"));

            //get the object inside the Iwebelement
            tableChilds[firstValueOnTable].FindElement(By.ClassName("rtl_pic")).Click();
            
        }

    }
}
