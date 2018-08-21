
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using PHPTravelsTestProject.UIElements;

namespace PHPTravelsTestProject.Scenarios
{
    class TestSocialIconsLinks
    {
        class GoToFlights
        {
            public IWebDriver Driver { get; set; }
            public string mainHandle;
            public SocialAppsIconLinks links;


            [SetUp]
            public void Initialize()
            {
                Driver = Actions.InitializeDriver();
                links = new SocialAppsIconLinks(Driver);
                mainHandle = Driver.CurrentWindowHandle;
                
            }

            [Test]
            public void TestFacebook()
            {

                links.FacebookIcon.Click();

                //create an array for the tabs
                var newTab = Driver.WindowHandles[1];

                //did the window opened
                Assert.IsTrue(!string.IsNullOrEmpty(newTab));

                //check the strings to accert a test
                Assert.AreEqual(ConfigDefaults.SocialLinksUrl.FacebookUrl, Driver.SwitchTo().Window(newTab).Url);
                

            }
            

            [Test]
            public void TestTwitter()
            {


                links.TwitterIcon.Click();

                Thread.Sleep(1000);

                var newTab = Driver.WindowHandles[1];

                Assert.AreEqual(ConfigDefaults.SocialLinksUrl.TwitterUrl, Driver.SwitchTo().Window(newTab).Url);

                

            }

            [Test]
            public void TestYouTube()
            {
                Driver.SwitchTo().Window(mainHandle);
                links.YouTubeIcon.Click();


                var newTab = Driver.WindowHandles[1];

                Assert.AreEqual(ConfigDefaults.SocialLinksUrl.YouTubeUrl, Driver.SwitchTo().Window(newTab).Url);
                
            }

            [Test]
            public void TestInstagram()
            {
                links.InstagramIcon.Click();
                var newTab = Driver.WindowHandles[1];

                Assert.AreEqual(ConfigDefaults.SocialLinksUrl.InstagramUrl, Driver.SwitchTo().Window(newTab).Url);

            }

            [Test]
            public void TestGooglePlus()
            {
                links.GooglePlusIcon.Click();
                var newTab = Driver.WindowHandles[1];

                Assert.AreEqual(ConfigDefaults.SocialLinksUrl.GooglePlusUrl, Driver.SwitchTo().Window(newTab).Url);

            }


            [TearDown]
            public void CleanUp()
            {
                //close the newly open tab everytime
                Driver.SwitchTo().Window(Driver.WindowHandles[1]).Close(); // close the tab

                Driver.Quit();
                
            }

        }


    }
}
