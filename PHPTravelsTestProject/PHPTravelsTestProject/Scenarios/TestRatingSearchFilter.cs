using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using PHPTravelsTestProject.UIElements;
using System.Collections.Generic;
using System;

namespace PHPTravelsTestProject.Scenarios
{
    class TestRatingSearchFilter
    {
        IWebDriver Driver { get; set; }
        HotelsFilterSearch hotelPage;
        ComparisonFunctions compare = new ComparisonFunctions();

        //create rating number 1 - 5
        int oneStar = 1;
        int twoStar = 2;
        int threeStar = 3;
        int fourStar = 4;
        int fiveStar = 5;
        
        IReadOnlyList<IWebElement> childs;
        IWebElement itemHolder;


        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            hotelPage = new HotelsFilterSearch(Driver);
            NavigateTo.NavigateToHotels(Driver);
        }

        [Test]
        public void TestFiveStarRating()
        {
            hotelPage.FiveStarGrade.Click();
            Thread.Sleep(1000);
            hotelPage.SearchButton.Click();
            Thread.Sleep(3000);
            itemHolder = Driver.FindElement(By.ClassName("itemscontainer"));


            childs = itemHolder.FindElements(By.TagName("tr"));

            foreach (IWebElement item in childs)
            {
                //pass the item and amount of stars expected to find
                Assert.IsTrue(compare.MarchNumberOfstars(item, fiveStar));
            }

        }

        [Test]
        public void TestFourStarRating()
        {
            hotelPage.FourStarGrade.Click();
            Thread.Sleep(1000);
            hotelPage.SearchButton.Click();
            Thread.Sleep(3000);
            itemHolder = Driver.FindElement(By.ClassName("itemscontainer"));


            childs = itemHolder.FindElements(By.TagName("tr"));

            foreach (IWebElement item in childs)
            {
                Assert.IsTrue(compare.MarchNumberOfstars(item, fourStar));
                
            }
        }

        [Test]
        public void TestThreeStarRating()
        {
            hotelPage.ThreeStarGrade.Click();
            Thread.Sleep(1000);
            hotelPage.SearchButton.Click();
            Thread.Sleep(3000);
            itemHolder = Driver.FindElement(By.ClassName("itemscontainer"));


            childs = itemHolder.FindElements(By.TagName("tr"));

            foreach (IWebElement item in childs)
            {
                Assert.IsTrue(compare.MarchNumberOfstars(item, threeStar));

            }

        }

        [Test]
        public void TestTwoStarRating()
        {
            hotelPage.TwoStarGrade.Click();
            Thread.Sleep(1000);
            hotelPage.SearchButton.Click();
            Thread.Sleep(3000);
            itemHolder = Driver.FindElement(By.ClassName("itemscontainer"));


            childs = itemHolder.FindElements(By.TagName("tr"));

            foreach (IWebElement item in childs)
            {
                Assert.IsTrue(compare.MarchNumberOfstars(item, twoStar));

            }
        }

        [Test]
        public void TestOneStarRating()
        {
            hotelPage.OneStarGrade.Click();
            Thread.Sleep(1000);
            hotelPage.SearchButton.Click();
            Thread.Sleep(3000);
            itemHolder = Driver.FindElement(By.ClassName("itemscontainer"));


            childs = itemHolder.FindElements(By.TagName("tr"));

            foreach (IWebElement item in childs)
            {
                Assert.IsTrue(compare.MarchNumberOfstars(item, oneStar));

            }
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }

    }
}
