using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelsTestProject.UIElements;
using System.Threading;
using PHPTravelsTestProject.ConfigDefaults;


namespace PHPTravelsTestProject.Scenarios
{
    class TestLoginForm
    {
        IWebDriver Driver { get; set; }
        AccountElements accountObject;


        /*
         * Partial functions used for initializing logins for multiple test
         * ex:TestingAddtoWishlist
         */ 
        public void PartialInitializer(IWebDriver Driver)
        {
            NavigateTo.NavigateToLogin(Driver);
            accountObject = new AccountElements(Driver);
        }

        public void PartialLoginFunction(IWebDriver Driver)
        {
            accountObject.emailForLogin.SendKeys(TestVariables.Credentials.ValidLogin.email);
            accountObject.passwordForLogin.SendKeys(TestVariables.Credentials.ValidLogin.password);


            Thread.Sleep(1000);
            accountObject.loginButton.Click();

        }


        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.NavigateToLogin(Driver);
            accountObject = new AccountElements(Driver);
        }


        [Test]
        public void _04_TestInvalidLoginEmail()
        {
            accountObject.emailForLogin.SendKeys(TestVariables.Credentials.InvalidEmail.email);
            accountObject.passwordForLogin.SendKeys(TestVariables.Credentials.ValidLogin.password);


            Thread.Sleep(1000);
            accountObject.loginButton.Click();

            Thread.Sleep(1000);
            var retMessage = accountObject.returnMessageLogin.Text;



            Assert.AreEqual(ReturnedErrorMessages.InvalidCredentialsInLogin.message, retMessage);
            Thread.Sleep(3000);
        }

        [Test]
        public void _05_TestValidLogin()
        {
            accountObject.emailForLogin.SendKeys(TestVariables.Credentials.ValidLogin.email);
            accountObject.passwordForLogin.SendKeys(TestVariables.Credentials.ValidLogin.password);

            Thread.Sleep(1000);
            accountObject.loginButton.Click();

            //get the url
            Thread.Sleep(3000);
            var retMessage = Driver.Url;
            Assert.AreEqual(TestVariables.ValidUrlOnLogin.validUrl, retMessage);

            Thread.Sleep(3000);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }

    }
}
