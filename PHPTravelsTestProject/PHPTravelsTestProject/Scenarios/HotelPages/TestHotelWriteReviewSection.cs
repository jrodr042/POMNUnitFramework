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


        [OneTimeSetUp]
        public void Initializer()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            hotelItem = new HotelDetailsPage(Driver);
        }

         
        [Test]
        public void TestValidateHotelDetailPageReviewSectionTitle()
        {
            Console.WriteLine("::Validating HotelDetails Page Review Section Title: ");
            Assert.AreEqual(TestVariables.HotelDetailsPageReviewSection.ReviewSectionTitle.title, hotelItem.ReviewSectionTitle.GetAttribute("innerText"));

        }

        [Test]
        public void TestAverageReviewCalculator()
        {
            hotelItem.WriteReviewButton.Click();
            Thread.Sleep(1000);
           
            hotelItem.ReviewCleanDropdown.SelectFromDropdown(TestVariables.HotelDetailsPageReviewSection.HotelReviewAverage.Clean);
            hotelItem.ReviewConfortDropdown.SelectFromDropdown(TestVariables.HotelDetailsPageReviewSection.HotelReviewAverage.Confort);
            hotelItem.ReviewLocationDropdown.SelectFromDropdown(TestVariables.HotelDetailsPageReviewSection.HotelReviewAverage.Location);
            hotelItem.ReviewFacilityDropdown.SelectFromDropdown(TestVariables.HotelDetailsPageReviewSection.HotelReviewAverage.Facilities);
            hotelItem.ReviewStaffDropdown.SelectFromDropdown(TestVariables.HotelDetailsPageReviewSection.HotelReviewAverage.Staff);
            Thread.Sleep(1000);
            //asert we get the correct average
            Console.WriteLine(":: Comparing the average result: ");
            Console.WriteLine(hotelItem.AverageReturnValue.Text);
            Assert.AreEqual(TestVariables.HotelDetailsPageReviewSection.HotelReviewAverage.CorrectAverage, hotelItem.AverageReturnValue.Text);
            Thread.Sleep(1000);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }


    }
}
