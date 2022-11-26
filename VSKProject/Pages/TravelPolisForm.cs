using OpenQA.Selenium;

namespace VSKProject
{
    public class TravelPolisForm : BasePage
    {
        public TravelPolisForm(IWebDriver webDriver) : base(webDriver)
        {
        }

        IWebElement OrderPolisButton => driver.FindElement(By.Id("sidebar_step_next"));

        public IWebElement CountryField => driver.FindElement(By.ClassName("sidebar-travel__policy-countries"));

        public IWebElement PeriodField => driver.FindElement(By.ClassName("sidebar-travel__policy-period"));

        public IWebElement DaysCountField => driver.FindElement(By.CssSelector(".sidebar-travel__policy-period.ng-star-inserted"));

        public void OrderPolisClick()
        {
            wait.Until(x => !OrderPolisButton.GetAttribute("class").Contains("button_mute"));
            OrderPolisButton.Click();
            wait.Until(x => OrderPolisButton.Text.Equals("Оплатить полис"));
        }
    }
}
