using NUnit.Framework;
using OpenQA.Selenium;
using PHPTravelsTestProject.Helper_Classes;
using PHPTravelsTestProject.UIElements;
using System.Threading;
using PHPTravelsTestProject.ConfigDefaults;
using System;

namespace PHPTravelsTestProject.Scenarios.HotelPages
{
    class TestHotelWriteReviewSection
    {
        IWebDriver Driver { get; set; }
        HotelDetailsPage hotelItem;


        [SetUp]
        public void Initializer()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            hotelItem = new HotelDetailsPage(Driver);
        }


        [Test]
        public void TestAverageReviewCalculator()
        {
            hotelItem.WriteReviewButton.Click();
            Thread.Sleep(1000);
           
            hotelItem.ReviewCleanDropdown.SelectFromDropdown(TestVariables.HotelReviewAverage.Clean);
            hotelItem.ReviewConfortDropdown.SelectFromDropdown(TestVariables.HotelReviewAverage.Confort);
            hotelItem.ReviewLocationDropdown.SelectFromDropdown(TestVariables.HotelReviewAverage.Location);
            hotelItem.ReviewFacilityDropdown.SelectFromDropdown(TestVariables.HotelReviewAverage.Facilities);
            hotelItem.ReviewStaffDropdown.SelectFromDropdown(TestVariables.HotelReviewAverage.Staff);
            Thread.Sleep(1000);
            //asert we get the correct average
            Console.WriteLine(":: Comparing the average result: ");
            Console.WriteLine(hotelItem.AverageReturnValue.Text);
            Assert.AreEqual(TestVariables.HotelReviewAverage.CorrectAverage, hotelItem.AverageReturnValue.Text);
            Thread.Sleep(1000);
        }


        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }


    }
}
