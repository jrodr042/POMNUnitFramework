using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PHPTravelsTestProject.UIElements
{
    class SocialAppsIconLinks
    {

        public SocialAppsIconLinks(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > div.rightsdiv > div.container.hidden-xs.hidden-sm > div:nth-child(1) > a:nth-child(1) > img")]
        public IWebElement FacebookIcon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div.rightsdiv > div.container.hidden-xs.hidden-sm > div:nth-child(1) > a:nth-child(2) > img")]
        public IWebElement TwitterIcon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div.rightsdiv > div.container.hidden-xs.hidden-sm > div:nth-child(1) > a:nth-child(3) > img")]
        public IWebElement YouTubeIcon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div.rightsdiv > div.container.hidden-xs.hidden-sm > div:nth-child(1) > a:nth-child(4) > img")]
        public IWebElement GooglePlusIcon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div.rightsdiv > div.container.hidden-xs.hidden-sm > div:nth-child(1) > a:nth-child(5) > img")]
        public IWebElement InstagramIcon { get; set; }


    }
}
