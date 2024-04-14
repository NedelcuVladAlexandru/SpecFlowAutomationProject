using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomationProject.StepDefinitions
{
    [Binding]
    public class AccountRegistrationStepDefinitions
    {

        private readonly IWebDriver driver;

        public AccountRegistrationStepDefinitions()
        {
            driver = Hooks.GetDriver();
        }

        [Given(@"I am connected to the Home tab")]
        public void GivenIAmConnectedToTheHomeTab()
        {
            driver.Navigate().GoToUrl("https://blazedemo.com/login");
            Thread.Sleep(2000);
        }

        [When(@"I press the register option")]
        public void WhenIPressTheRegisterOption()
        {
            driver.FindElement(By.XPath("//*[@href='https://blazedemo.com/register']")).Click();
            Thread.Sleep(500);          
        }

        [Then(@"I will be sent to the register page")]
        public void ThenIWillBeSetnToTheRegisterPage()
        {
            //Sepparating assertion comparison string for vis
            string currentPageUrl = driver.Url;

            Assert.That(currentPageUrl.Equals("https://blazedemo.com/register"), "The login page url was incorrect!");
        }

        [Given(@"I will input the (.*) name")]
        public void GivenIWillInputTheName(string p0)
        {
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys(p0);
        }

        [When(@"I try to register")]
        public void WhenITryToRegister()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            Thread.Sleep(500);
        }

        [Then(@"I will be prompted to fill another field")]
        public void ThenIWillBePromptedToFillAnotherField()
        {
            //Assert for pop-up. It is not an object in the HTML so I have to figure out smth

            //Need to also add a clear for the text box
        }
    }
}
