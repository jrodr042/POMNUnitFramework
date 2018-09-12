using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using PHPTravelsTestProject.UIElements;
using PHPTravelsTestProject.ConfigDefaults;
using System;

namespace PHPTravelsTestProject.Scenarios
{
    class TestAddingAddingToWishList
    {
        //variables
        IWebDriver Driver { get; set; }
        HotelDetailsPage hotelInfo;
        IAlert alertHandler;
        ProfileElements profile;
        public string alertMessage;
        public string HotelName;
        public string HotelNameOnWishList;
        
        

        [SetUp]
        public void Initialize()
        {
            //initialize Driver
            Driver = Actions.InitializeDriver();
            profile = new ProfileElements(Driver);
            
        }


        [Test]
        public void TestAddToWishListWithoutLogin()
        {
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            hotelInfo = new HotelDetailsPage(Driver);
            Thread.Sleep(3000);

            //click on the add to wishlist
            hotelInfo.AddToWishListButton.Click();
            Thread.Sleep(3000);

            //get the text from the pop up window
            alertMessage = Driver.SwitchTo().Alert().Text;
            //testing purpose
            Console.WriteLine(alertMessage);

            Assert.AreEqual(ReturnedErrorMessages.InvalidAddingToWishlistWithoutLogin.message, alertMessage);
        }

        [Test]
        public void TestAddToWishListWhileLogin()
        {
            TestSignUpForm testSignUpForm = new TestSignUpForm();
            testSignUpForm.PartialInitializerSignUp(Driver);
            testSignUpForm.PartialValidSignUp(Driver);

            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            hotelInfo = new HotelDetailsPage(Driver);
            Thread.Sleep(3000);

            //get the name of the current hotel detail item
            HotelName = hotelInfo.HotelNameTitle.Text;
            Console.WriteLine(HotelName);

            //click on the add to wishlist
            hotelInfo.AddToWishListButton.Click();
            Thread.Sleep(3000);

            try
            {
                // Check the presence of alert
                alertHandler = Driver.SwitchTo().Alert();
                //print to console the alert message
                Console.WriteLine(alertHandler.Text);
                // if present consume the alert
                alertHandler.Accept();

            }
            catch (NoAlertPresentException ex)
            {
                Console.Write(ex.Message); 
            }


            //navigate back to account
            NavigateTo.NavigateBackToProfileWhenLogin(Driver);
            Thread.Sleep(3000);

            //load the wishlist
            profile.WishList.Click();
            Thread.Sleep(3000);

            //get the name of the current hotel profile
            //change the name to uppercase
            HotelNameOnWishList = profile.ItemFromWishList.Text.ToUpper();


            //Assert that both are the same names
            Assert.AreEqual(HotelName, HotelNameOnWishList);
            Thread.Sleep(2000);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();

        }

    }
}
