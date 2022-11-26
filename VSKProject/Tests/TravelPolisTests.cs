using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using System.Globalization;

namespace VSKProject
{
    [TestFixture]
    public class TravelPolisTests: BaseTest
    {
        [Test]
        public void BuyTravelPolisTest()
        {
            string country = "Египет";
            DateTime dateFrom = DateTime.Now.Date.AddDays(5);
            DateTime dateTo = DateTime.Now.Date.AddDays(15);
            var ruFormat = CultureInfo.GetCultureInfo("ru-RU");
            string dateFormat = "dd MMMM yyyy";
            string fromStr = dateFrom.ToString(dateFormat, ruFormat);
            string toStr = dateTo.ToString(dateFormat, ruFormat);
            int days = dateTo.Subtract(dateFrom).Days + 1;

            VSKMainPage mainPage = SiteNavigator.NavigateToMainPage(driver);
            CalculatorTravelPage calcTravelPage = mainPage.TravelsClick().BuyPolisClick();
            calcTravelPage.SetCountry(country);
            calcTravelPage.SetDatesPeriod(dateFrom, dateTo);
            TravelPolisForm polis = calcTravelPage.PolisForm;
            polis.OrderPolisClick();

            using (new AssertionScope())
            {
                polis.CountryField.Text.Should().BeEquivalentTo(country);
                polis.PeriodField.Text.Should().BeEquivalentTo($"C {fromStr} по {toStr}");
                polis.DaysCountField.Text.Should().Contain($"{days}");
            }
        }
    }
}
