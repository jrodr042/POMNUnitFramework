using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using PHPTravelsTestProject.UIElements;
using OpenQA.Selenium.Support.UI;
using System;


namespace PHPTravelsTestProject.Scenarios
{
    class TestHotelSlideShowImages
    {

        IWebDriver Driver { get; set; }
        HotelDetailsPage hotelItem;
        WebDriverWait wait;
        bool go;
        string classString;
        Screenshot hotelImage;
        int hotelImageNumber, forwardPressTimes, previousPressTimes;
        IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            Driver = Actions.InitializeDriver();
            hotelItem = new HotelDetailsPage(Driver);
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            hotelImageNumber = 1;
            forwardPressTimes = 0;
            previousPressTimes = 0;
            js = Driver as IJavaScriptExecutor;
        }

        [Test]
        public void ValidateTheSlideShowContainsHotelPrice()
        {
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            Console.WriteLine(":: Checking for the hotel price in the slide show");
            Assert.IsTrue(hotelItem.SlideShowPrice.Displayed);
        }

        [Test]
        public void TestMaximizeMinimizeSlideShowWindow()
        {
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            hotelItem.MaximizeSlideShowButton.Click();
            Thread.Sleep(1000);

            //check that the class being called is the full screen
            Console.WriteLine(":: Maximizing...");
            Console.WriteLine(":: Checking that it is in full screen mode");
            Assert.AreEqual("fullscreen",hotelItem.MaxMinClass.GetAttribute("class"));

            Console.WriteLine(":: Minimizing...");
            hotelItem.MaximizeSlideShowButton.Click();
            Thread.Sleep(1000);
            Console.WriteLine(":: Checking that is not in full screen mode");
            Assert.AreEqual("",hotelItem.MaxMinClass.GetAttribute("class"));

        }



        [Test]
        public void TestNextSlideThroughPressingTheImage()
        {
            go = true;
            NavigateTo.NavigateToItemOnHotelSearch(Driver);

            //loop to traverse slide show
            Console.WriteLine(":: Starting to traverse slide show by clicking the images.");
            while (go)
            {
                //use the next button to stop
                //wait for screenshot
                //get the disabled class string
                classString = hotelItem.NextSliderButton.GetAttribute("class");
                if (classString.Equals(hotelItem.DisabledNextButton))
                {
                    go = false;
                }
                else
                {
                    hotelItem.SlideShow.Click();
                }
            }

            //assert that we reach the end
            classString = hotelItem.NextSliderButton.GetAttribute("class");
            Console.WriteLine(":: Checking that we reached the end of the slide show");
            Assert.AreEqual(hotelItem.DisabledNextButton, classString);
        }


        /*
         * This tests test the functuality of the previous and next icon buttons able to traverse the 
         * slide show back and forth
         */ 
        [Test]
        public void TestForwardAndPreviousIcons()
        {
            //set the go to true
            go = true;
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            Thread.Sleep(1000);

            //traverse forward
                while (go)
                {
                    //wait for screenshot
                    Thread.Sleep(100);
                    //get the disabled class string
                    classString = hotelItem.NextSliderButton.GetAttribute("class");
                    if (classString.Equals(hotelItem.DisabledNextButton))
                    {
                        go = false;
                    }
                    else
                    {
                        wait.Until(ExpectedConditions.ElementToBeClickable(hotelItem.NextSliderButton));
                        hotelItem.NextSliderButton.Click();
                    }

                    forwardPressTimes++;

                }

                         
            /*
             * Create the loop for reversing the same ammount of times from
             * the number of pages and also hit the number disabled button of previous
             */
            //set the go back to true
            go = true;
            Thread.Sleep(1000);

            while (go)
            {
                //wait for screenshot
                Thread.Sleep(100);
                //get the disabled class string
                classString = hotelItem.PreviousSliderButton.GetAttribute("class");
                if (classString.Equals(hotelItem.DisabledPreviousButton))
                {
                    go = false;
                }
                else
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(hotelItem.PreviousSliderButton));
                    hotelItem.PreviousSliderButton.Click();
                }
                previousPressTimes++;
            }

            //assert that we have done  a whole cycle
            //check if we reach the end and assert
            classString = hotelItem.PreviousSliderButton.GetAttribute("class");
            Console.WriteLine(":: Checking that we are in the first image on the list.");
            Assert.AreEqual(hotelItem.DisabledPreviousButton, classString);

            Console.WriteLine(":: Checking that the Forward and Previous buttons were pressed equal times.");
            Assert.AreEqual(forwardPressTimes, previousPressTimes);

        }


        [Test]
        public void TestThatNoImagesRepeatOnHotelDetailsPageSlideShow()
        {
            //set go = true
            go = true;
            NavigateTo.NavigateToItemOnHotelSearch(Driver);
            Thread.Sleep(3000);

            //scroll to view
            js.ExecuteScript("window.scrollBy(0, 70)");
            Thread.Sleep(2000);

            while (go)
            {
                Thread.Sleep(1000);
                //take screenshot of current page
                hotelImage = ((ITakesScreenshot)Driver).GetScreenshot();
                hotelImage.SaveAsFile(TestOutputs.HotelSlideShowImagesOutput.OutputPath + "/Hotel Image-" + hotelImageNumber + ".png", ScreenshotImageFormat.Png);

                //get the class name
                classString = hotelItem.NextSliderButton.GetAttribute("class");
                if (classString.Equals(hotelItem.DisabledNextButton))
                {
                    go = false;
                }
                else
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(hotelItem.NextSliderButton));
                    hotelItem.NextSliderButton.Click();

                }

                //increase hotelimagenumber
                hotelImageNumber++;
            }

        }



        /*
         *Teardown the test 
         */ 
        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();

        }

    }
}
