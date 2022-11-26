using OpenQA.Selenium;

namespace VSKProject
{
    public class TravelPage : BasePage
    {
        public TravelPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        IWebElement BuyPolisButton => driver.FindElement(By.Id("travel_banner_button_buy"));

        public CalculatorTravelPage BuyPolisClick()
        {
            wait.Until(x => BuyPolisButton.Displayed);
            BuyPolisButton.Click();
            return new CalculatorTravelPage(driver);
        }
    }
}
