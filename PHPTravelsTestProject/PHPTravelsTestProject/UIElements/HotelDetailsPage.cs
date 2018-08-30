using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PHPTravelsTestProject.UIElements
{
    class HotelDetailsPage
    {

        public HotelDetailsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = "#body-section > div.header-mob > div > div > div.col-xs-8.col-sm-7 > div > span:nth-child(1) > strong > span")]
        public IWebElement HotelNameTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"OVERVIEW\"]/div[1]/div[3]/div/div[1]/div[2]")]
        public IWebElement PreviousSliderButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"OVERVIEW\"]/div[1]/div[3]/div/div[1]/div[3]")]
        public IWebElement NextSliderButton { get; set; }

        [FindsBy(How = How.Id, Using = "map")]
        public IWebElement Map { get; set; }

        /*this field returns the Iwebelement for the details section
            Must search for items insdie of details as well
         */

        [FindsBy(How = How.XPath, Using = "//*[@id=\"OVERVIEW\"]/div[5]/div/div")]
        public IWebElement DetailsSection { get; set; }


        /*items for checkin form
            Checkin, Checkout, adults?, child?, modifybutton 
         */

        [FindsBy(How = How.CssSelector, Using = "#body-section > div:nth-child(8) > div.visible-lg.visible-md > div > div.panel-body > form > div:nth-child(1) > div > input")]
        public IWebElement CheckInDateField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#body-section > div:nth-child(8) > div.visible-lg.visible-md > div > div.panel-body > form > div:nth-child(2) > div > input")]
        public IWebElement CheckOutField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"adults\"]")]
        public IWebElement NumberOfAdultsDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"child\"]")]
        public IWebElement NumberOfChildrenDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"body - section\"]/div[4]/div[2]/div/div[2]/form/div[5]/input[3]")]
        public IWebElement ModifyButton { get; set; }


        /*
         * Section for available rooms
         */


        /*
         * Section for privacy policy, payment types, and checkin description
         */ 


        /*
         * Average Review Section
         */ 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"body - section\"]/div[4]/div[6]/div[1]/div[3]/div[2]/button")]
        public IWebElement WriteReviewButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "addwishlist")]
        public IWebElement AddToWishListButton { get; set; }

        /*
         * Reviews 
         */ 


        /*
         * Related Hotels
         */ 

    }
}
