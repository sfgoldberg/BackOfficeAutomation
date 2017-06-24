using OpenQA.Selenium;
using System.Configuration;

namespace Back_Office_Automation.Objects.Southwest
{
    public class SouthwestHomepage
    {
        //expected page title
        public static string Title => "Southwest Airlines | Book Flights, Airline Tickets, Airfare";

        //takes user to southwest homepage url
        public static void GoTo()
        {
            {
                var southwestHomepage = ConfigurationManager.AppSettings["SouthwestHomepageUrl"];

                Driver.Instance.Navigate().GoToUrl(southwestHomepage);
            }
        }

        //selects and clears the depart text field
        public static void ClickDepart()
        {
            {
                var departBox = Driver.Instance.FindElement(By.Id("air-city-departure"));

                departBox.Click();
                departBox.Clear();
            }
        }

        //applies location to depart text field
        public static void EnterDepartLocation(string location = "")
        {
            {
                var departBox = Driver.Instance.FindElement(By.Id("air-city-departure"));

                departBox.SendKeys(location);
                departBox.SendKeys(Keys.Enter);
            }
        }

        //selects and clears the arrive text field
        public static void ClickArrive()
        {
            {
                var arriveBox = Driver.Instance.FindElement(By.Id("air-city-arrival"));

                arriveBox.Click();
                arriveBox.Clear();
            }
        }

        //applies location to arrive text field
        public static void EnterArriveLocation(string location = "")
        {
            {
                var arriveBox = Driver.Instance.FindElement(By.Id("air-city-arrival"));

                arriveBox.SendKeys(location);
                arriveBox.SendKeys(Keys.Enter);
            }
        }

        //selects and clears the depart date field
        public static void ClickDepartDate()
        {
            {
                var departDate = Driver.Instance.FindElement(By.Id("air-date-departure"));

                departDate.Click();
                departDate.Clear();
            }
        }

        //applies date to depart date field
        public static void EnterDepartDate(string date)
        {
            {
                var departDate = Driver.Instance.FindElement(By.Id("air-date-departure"));

                departDate.SendKeys(date);
            }
        }

        //selects and clears the arrive date field
        public static void ClickArriveDate()
        {
            {
                var arriveDate = Driver.Instance.FindElement(By.Id("air-date-return"));

                arriveDate.Click();
                arriveDate.Clear();
            }
        }

        //applies date to depart date field
        public static void EnterArrivalDate(string date)
        {
            {
                var arriveDate = Driver.Instance.FindElement(By.Id("air-date-return"));

                arriveDate.SendKeys(date);
            }
        }

        //clicks the search button
        public static void ClickSearchBtn()
        {
            var searchBtn = Driver.Instance.FindElement(By.Id("jb-booking-form-submit-button"));

            searchBtn.Click();
        }
    }
}
