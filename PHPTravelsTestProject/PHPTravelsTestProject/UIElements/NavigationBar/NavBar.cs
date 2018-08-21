using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PHPTravelsTestProject.UIElements.NavigationBar
{
    class NavBar
    {
        public NavBar(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li.active > a")]
        public IWebElement Home { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(2) > a")]
        public IWebElement Hotels { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(3) > a")]
        public IWebElement Flights { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(4) > a")]
        public IWebElement Tours { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(5) > a")]
        public IWebElement Cars { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(6) > a")]
        public IWebElement Visa { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(7) > a")]
        public IWebElement Offers { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#collapse > ul:nth-child(1) > li:nth-child(8) > a")]
        public IWebElement Blogs { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/nav//*[@id=\"li_myaccount\"]")]
        public IWebElement myAccount { get; set; }

   
    }
}
