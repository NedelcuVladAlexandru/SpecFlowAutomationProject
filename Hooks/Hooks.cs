using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

[Binding]
public sealed class Hooks
{
    private static IWebDriver _driver;

    //Adapted the setup in such a way that it is gonna run one web page per feature. Will possibly add the option of running it per scenario like it was before. Maybe with tags or background?

    [BeforeFeature]
    public static void BeforeFeature()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        _driver = driver;
    }

    public static IWebDriver GetDriver()
    {
        return _driver;
    }

    [AfterFeature]
    public static void AfterFeature()
    {
        //GetDriver().Quit();
    }
}