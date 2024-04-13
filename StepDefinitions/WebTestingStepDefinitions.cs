using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecFlowAutomationProject.StepDefinitions
{
    [Binding]
    public class WebTestingStepDefinitions
    {
        private readonly IWebDriver driver;

        public WebTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I have connected to the website")]
        public void GivenIHaveConnectedToTheWebsite()
        {
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://blazedemo.com");
        }

        [When(@"I select the home tab")]
        public void WhenISelectTheHomeTab()
        {
            driver.FindElement(By.XPath("//*[@href='home']")).Click(); 
            Thread.Sleep(3000);
        }

        [Then(@"I will be sent to the home tab")]
        public void ThenIWillBeSentToTheHomeTab()
        {
            //Sepparating assertion comparison string for vis
            string currentPageUrl = driver.Url;

            Assert.That(currentPageUrl.Equals("https://blazedemo.com/login"), "The login page url was incorrect!");
            Thread.Sleep(1000);
        }

        [Given(@"I have connected to the home tab")]
        public void GivenIHaveConnectedToTheHomeTab()
        {
            driver.Navigate().GoToUrl("https://blazedemo.com/login");
            Thread.Sleep(2000);
        }

        [When(@"I have selected the register tab")]
        public void WhenIHaveSelectedTheRegisterTab()
        {
            driver.FindElement(By.XPath("//*[@href='https://blazedemo.com/register']")).Click();
            Thread.Sleep(500);

            //Sepparating assertion comparison string for vis
            string currentPageUrl = driver.Url;

            Assert.That(currentPageUrl.Equals("https://blazedemo.com/register"), "The login page url was incorrect!");
        }

        [Then(@"I will input my name")]
        public void ThenIWillInputMyName()
        {
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("Test");
        }

        [Then(@"I will input my company name")]
        public void ThenIWillInputMyCompanyName()
        {
            //TODO: Add another test for email without @
            driver.FindElement(By.XPath("//*[@id='company']")).SendKeys("Test");
        }

        [Then(@"I will input my e-mail address")]
        public void ThenIWillInputMyE_MailAddress()
        {
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("Test@test.com");
        }

        [Then(@"I will input my password")]
        public void ThenIWillInputMyPassword()
        {
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("Test");
        }

        [Then(@"I will confirm my password")]
        public void ThenIWillConfirmMyPassword()
        {
            //TODO: Add another test for incorrect pass
            driver.FindElement(By.XPath("//*[@id='password-confirm']")).SendKeys("Test");
        }

        [Then(@"I will press the Register button")]
        public void ThenIWillPressTheRegisterButton()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            Thread.Sleep(1000);
        }

    }
}
