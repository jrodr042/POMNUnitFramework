using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PHPTravelsTestProject.UIElements
{
    class AccountElements
    {

        public AccountElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /* 
            This fields are use for the sign up form of the application
             */

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement firstName { get; set; }


        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement lastName { get; set; }


        [FindsBy(How = How.Name, Using = "phone")]
        public IWebElement phoneNumber { get; set; }


        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement password { get; set; }


        [FindsBy(How = How.Name, Using ="confirmpassword")]
        public IWebElement confirmPassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#headersignupform > div:nth-child(9) > button")]
        public IWebElement submitButton { get; set; }


        /* 
            This fields are use for the login page of the application
             */
        [FindsBy(How = How.CssSelector, Using = "#loginfrm > div.panel.panel-default > div.wow.fadeIn.animated > button")]
        public IWebElement loginButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#loginfrm > div.panel.panel-default > div.wow.fadeIn.animated > div > div:nth-child(1) > input")]
        public IWebElement emailForLogin { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#loginfrm > div.panel.panel-default > div.wow.fadeIn.animated > div > div:nth-child(2) > input")]
        public IWebElement passwordForLogin { get; set; }


        //this elements are use to trackanyreturn message from signup/login page

        [FindsBy(How = How.XPath, Using = "//*[@id=\"headersignupform\"]/div[2]/div/p")]
        public IWebElement returnMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginfrm\"]/div[1]/div[2]/div")]
        public IWebElement returnMessageLogin { get; set; }
        
    }
}
