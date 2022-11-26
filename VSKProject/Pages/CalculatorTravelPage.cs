using OpenQA.Selenium;

namespace VSKProject
{
    public class CalculatorTravelPage: BasePage
    {
        public CalculatorTravelPage(IWebDriver driver) : base(driver)
        {
        }

        IWebElement CountryInput => driver.FindElement(By.CssSelector("input[automation-id='tui-input-tag__native']"));
        IWebElement CountryItemButton(string country) => driver.FindElement(By.XPath($"//button[contains(text(), '{country}')]"));                                                                                
        IWebElement DateStart => driver.FindElement(By.XPath("//label[@label='Дата начала']//input"));
        IWebElement DateEnd => driver.FindElement(By.XPath("//label[@label='Дата окончания']//input"));
        public TravelPolisForm PolisForm => new TravelPolisForm(driver);

        public void SetCountry(string country)
        {
            wait.Until(x => CountryInput.Displayed);
            CountryInput.SendKeys(country.Substring(0, country.Length-1));
            CountryItemButton(country).Click();
            CountryInput.Click();
        }

        public void SetDatesPeriod(DateTime dateFrom, DateTime dateTo)
        {
            string format = "dd.MM.yyyy";
            DateStart.Clear();
            DateStart.SendKeys(dateFrom.ToString(format));
            DateEnd.Click();
            DateEnd.Clear();
            DateEnd.SendKeys(dateTo.ToString(format));
        }

      
    }
}
