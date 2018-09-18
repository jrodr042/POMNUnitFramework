using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PHPTravelsTestProject
{
    public static class Actions
    {
        //initialize the webdriver
        public static IWebDriver InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(ConfigDefaults.BaseUrl.DefaultUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }


        public static IWebDriver InitializePartialDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }




    }
}
