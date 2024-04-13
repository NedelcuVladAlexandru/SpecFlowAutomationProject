using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlowAutomationProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario()]
        public void FirstBeforeScenario()
        {
            if (_container != null && !_container.IsRegistered<IWebDriver>())
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                _container.RegisterInstanceAs<IWebDriver>(driver);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if(driver != null)
            {
                driver.Quit();
            }

        }
    }
}