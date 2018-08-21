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


        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.NavigateToLogin(Driver);
            accountObject = new AccountElements(Driver);
        }


        [Test]
        public void TestInvalidLoginEmail()
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


        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }

    }
}
