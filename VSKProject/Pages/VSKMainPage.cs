using OpenQA.Selenium;


namespace VSKProject
{
    public class VSKMainPage : BasePage
    {
        public VSKMainPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        IWebElement TravelsLink => driver.FindElement(By.LinkText("Путешествия"));
        
        public TravelPage TravelsClick()
        {
            wait.Until(x => TravelsLink.Displayed);
            TravelsLink.Click();
            return new TravelPage(driver);
        }
    }
}
