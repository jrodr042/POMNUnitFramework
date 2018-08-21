﻿using OpenQA.Selenium;
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
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(ConfigDefaults.BaseUrl.DefaultUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }




    }
}
