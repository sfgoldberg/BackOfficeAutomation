using Microsoft.VisualStudio.TestTools.UnitTesting;
using Back_Office_Automation.Objects;
using System;
using Back_Office_Automation.Objects.Southwest;

namespace Back_Office_Automation.Tests.Southwest
{
    [TestClass]
    public class BookFlightTest : BaseTest
    {
        [TestMethod]
        [DeploymentItem("chromedriver.exe")]
        [Description("Test Case 1, User goes to Kayak.com to book a flight from Washington (Dulles), DC (IAD) to Los Angeles, CA (LAX) departing any date and returning one week later.")]
        [TestCategory("southwest_bookFlight")]

        public void Southwest_bookFlight_returningOneWeekLater()
        {
            {
                const string location = "IAD";
                const string location2 = "LAX";
                var tomorrow = DateTime.Today.AddDays(1).ToString("MM/dd");
                var weekLater = DateTime.Today.AddDays(8).ToString("MM/dd");

                SouthwestHomepage.GoTo();
                Assert.AreEqual(SouthwestHomepage.Title, Page.PageTitle(), "Southwest page title is not as expected");
                SouthwestHomepage.ClickDepart();
                SouthwestHomepage.EnterDepartLocation(location);
                SouthwestHomepage.ClickArrive();
                SouthwestHomepage.EnterArriveLocation(location2);
                SouthwestHomepage.ClickDepartDate();
                SouthwestHomepage.EnterDepartDate(tomorrow);
                SouthwestHomepage.ClickArriveDate();
                SouthwestHomepage.EnterArrivalDate(weekLater);
                SouthwestHomepage.ClickSearchBtn();
                Assert.AreEqual(SearchFlightsListingPage.Title, Page.PageTitle(),"Search Flights listing page title is not as expected");
                SearchFlightsListingPage.SelectDepartingFlight();
                SearchFlightsListingPage.SelectReturnFlight();
                Driver.Wait(2);
                SearchFlightsListingPage.ClickContinueBtn();
                Assert.AreEqual(PriceReservationsPage.Title, Page.PageTitle(),"Price Reservations page title is not as expected");
                PriceReservationsPage.ClickContinue();
                Assert.AreEqual(BookReservationsPage.Title, Page.PageTitle(),"Book Reservations page title is not as expected");
            }
        }
    }
}
