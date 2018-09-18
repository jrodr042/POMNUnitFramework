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

        /*
         * Slide show items 
         */ 

        [FindsBy(How = How.CssSelector, Using = "#OVERVIEW > div.col-xs-12.col-md-8.go-right.mob-row.mt-15.pl0 > div.avgprice")]
        public IWebElement SlideShowPrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = "html")]
        public IWebElement MaxMinClass { get; set; }

        [FindsBy(How = How.ClassName, Using = "fotorama__fullscreen-icon")]
        public IWebElement MaximizeSlideShowButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#body-section > div.header-mob > div > div > div.col-xs-8.col-sm-7 > div > span:nth-child(1) > strong > span")]
        public IWebElement HotelNameTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"OVERVIEW\"]/div[1]/div[3]/div/div[1]/div[1]/div[2]")]
        public IWebElement SlideShow { get; set; }

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

        [FindsBy(How = How.CssSelector, Using = "#ADDREVIEW > div > div.panel-heading")]
        public IWebElement WriteReviewHeader { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_clean")]
        public IWebElement ReviewCleanDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_comfort")]
        public IWebElement ReviewConfortDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_location")]
        public IWebElement ReviewLocationDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_facilities")]
        public IWebElement ReviewFacilityDropdown { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_staff")]
        public IWebElement ReviewStaffDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#reviews-form-40 > div.col-md-8 > div.row > div:nth-child(1) > input")]
        public IWebElement ReviewNameInputField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#reviews-form-40 > div.col-md-8 > div.row > div:nth-child(2) > input")]
        public IWebElement ReviewEmailInputField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#reviews-form-40 > div.col-md-8 > textarea")]
        public IWebElement ReviewInputFieldSection { get; set; }

        [FindsBy(How = How.ClassName, Using = "writeReview")]
        public IWebElement WriteReviewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ADDREVIEW\"]/div//div//div/div/h3/span")]
        public IWebElement AverageReturnValue { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"ADDREVIEW\"]/div/div[1]/a/span[2]")]
        public IWebElement CloseWriteReviewSectionButton { get; set; }





        /*
         * Add to wishlist
         */ 
        [FindsBy(How = How.ClassName, Using = "addwishlist")]
        public IWebElement AddToWishListButton { get; set; }


        /*
         * Reviews 
         */



        /*
         * Related Hotels
         */


        /*
         * Extra needed IwebElements 
         */

        //IwebElementclass item to know when we reach the end of the slide show
        public string DisabledNextButton = "fotorama__arr fotorama__arr--next fotorama__arr--disabled";

        public string DisabledPreviousButton = "fotorama__arr fotorama__arr--prev fotorama__arr--disabled";

    }
}
