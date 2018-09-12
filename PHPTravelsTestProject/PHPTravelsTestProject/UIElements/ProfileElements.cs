using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PHPTravelsTestProject.UIElements
{
    class ProfileElements
    {
        public ProfileElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }





        [FindsBy(How = How.XPath, Using = "//*[@id=\"body - section\"]/div/div[1]/div/div[1]/h3")]
        public IWebElement WelcomeHeader { get; set; }


        [FindsBy(How = How.ClassName, Using = "wishlist-icon")]
        public IWebElement WishList { get; set; }

        [FindsBy(How = How.ClassName, Using = "bookings-icon")]
        public IWebElement Bookings { get; set; }

        [FindsBy(How = How.ClassName, Using = "profile-con")]
        public IWebElement Profile { get; set; }

        [FindsBy(How = How.ClassName, Using = "newsletter-icon")]
        public IWebElement Newsletter { get; set; }


        /*
         * items from tables
         * 
         */ 

        [FindsBy(How = How.CssSelector, Using = "#wish7 > div:nth-child(1) > a > b")]
        public IWebElement ItemFromWishList { get; set; }

    }
}
