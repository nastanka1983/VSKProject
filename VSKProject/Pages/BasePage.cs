using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VSKProject
{
    public class BasePage
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
    }
}
