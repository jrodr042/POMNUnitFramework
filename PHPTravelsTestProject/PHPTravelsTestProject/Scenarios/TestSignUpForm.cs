using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelsTestProject.UIElements;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using PHPTravelsTestProject.ConfigDefaults;
using System.Threading;
using System;

namespace PHPTravelsTestProject.Scenarios
{
    class TestSignUpForm
    {

        IWebDriver Driver { get; set; }
        AccountElements accountObject;
   

        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.NavigateToSignUp(Driver);
            accountObject = new AccountElements(Driver);
        }

        [Test]
        public void TestInvalidPasswordSignUp()
        {
            //populate all the values in the sign up form
            accountObject.firstName.SendKeys(TestVariables.Credentials.ValidSignUp.name);
            accountObject.lastName.SendKeys(TestVariables.Credentials.ValidSignUp.lastName);
            accountObject.Email.SendKeys(TestVariables.Credentials.ValidSignUp.email);
            accountObject.password.SendKeys(TestVariables.Credentials.InvalidSignUpPasswordLessThanSixCharacters.password);
            accountObject.confirmPassword.SendKeys(TestVariables.Credentials.InvalidSignUpPasswordLessThanSixCharacters.password);
            accountObject.phoneNumber.SendKeys(TestVariables.Credentials.ValidSignUp.phoneNumber);

            Thread.Sleep(3000);

            accountObject.submitButton.Click();

            Thread.Sleep(1000);
            var retMessage = accountObject.returnMessage.Text;

            Assert.AreEqual(retMessage, ReturnedErrorMessages.InvalidPasswordLessSixCharactersMessage.message);
            Thread.Sleep(3000);

        }

        [Test]
        public void TestInvalidEmail()
        {
            //populate all the values in the sign up form
            accountObject.firstName.SendKeys(TestVariables.Credentials.ValidSignUp.name);
            accountObject.lastName.SendKeys(TestVariables.Credentials.ValidSignUp.lastName);
            accountObject.Email.SendKeys(TestVariables.Credentials.InvalidEmail.email);
            accountObject.password.SendKeys(TestVariables.Credentials.ValidSignUp.password);
            accountObject.confirmPassword.SendKeys(TestVariables.Credentials.ValidSignUp.password);
            accountObject.phoneNumber.SendKeys(TestVariables.Credentials.ValidSignUp.phoneNumber);

            Thread.Sleep(3000);

            accountObject.submitButton.Click();

            Thread.Sleep(1000);
            var retMessage = accountObject.returnMessage.Text;

            Assert.AreEqual(retMessage, ReturnedErrorMessages.InvalidEmailOnSignUp.message);
            Thread.Sleep(3000);
        }

        //[Test]
        //public void TestValidSignUp()
        //{
        //    Console.WriteLine("Testing");

        //    //populate all the values in the sign up form
        //    accountObject.firstName.SendKeys(TestVariables.Credentials.ValidSignUp.name);
        //    accountObject.lastName.SendKeys(TestVariables.Credentials.ValidSignUp.lastName);
        //    accountObject.Email.SendKeys(TestVariables.Credentials.ValidSignUp.email);
        //    accountObject.password.SendKeys(TestVariables.Credentials.ValidSignUp.password);
        //    accountObject.confirmPassword.SendKeys(TestVariables.Credentials.ValidSignUp.repeatPassword);
        //    accountObject.phoneNumber.SendKeys(TestVariables.Credentials.ValidSignUp.phoneNumber);

        //    Thread.Sleep(3000);
        //}



        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }


    }
}
