using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VSKProject
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
