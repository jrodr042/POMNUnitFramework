using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PHPTravelsTestProject.UIElements
{
    class HotelsFilterSearch
    {
        //constructor
        public HotelsFilterSearch(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        


        //define each ui elements
        [FindsBy(How = How.CssSelector, Using = "#collapse1 > div.hpadding20 > div > div:nth-child(1)")]
        public IWebElement OneStarGrade { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#collapse1 > div.hpadding20 > div > div:nth-child(3)")]
        public IWebElement TwoStarGrade { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#collapse1 > div.hpadding20 > div > div:nth-child(5)")]
        public IWebElement ThreeStarGrade { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#collapse1 > div.hpadding20 > div > div:nth-child(7)")]
        public IWebElement FourStarGrade { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#collapse1 > div.hpadding20 > div > div:nth-child(9)")]
        public IWebElement FiveStarGrade { get; set; }



        //search button
        [FindsBy(How = How.CssSelector, Using = "#searchform")]
        public IWebElement SearchButton { get; set; }




    }
}
