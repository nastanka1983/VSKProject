using OpenQA.Selenium;

namespace VSKProject
{
    public static class SiteNavigator
    {
        public static VSKMainPage NavigateToMainPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://shop.vsk.ru/");
            return new VSKMainPage(driver);
        }
    }
}
