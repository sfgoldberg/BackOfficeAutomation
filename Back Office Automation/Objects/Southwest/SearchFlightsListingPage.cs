using System.Linq;
using OpenQA.Selenium;

namespace Back_Office_Automation.Objects.Southwest
{
    public class SearchFlightsListingPage
    {
        //expected page title
        public static string Title => "Southwest Airlines - Select Flight(s)";

        //select the first available departing flight
        public static void SelectDepartingFlight()
        {
            var faresOutbound = Driver.Instance.FindElements(By.Id("faresOutbound"));
            var firstOrDefault = faresOutbound.FirstOrDefault();
            firstOrDefault?.Click();
        }

        //select the first available returning flight
        public static void SelectReturnFlight()
        {
            var faresReturn = Driver.Instance.FindElements(By.Id("faresReturn"));
            var firstOrDefault = faresReturn.FirstOrDefault();
            firstOrDefault?.Click();
        }

        //click continue button 
        public static void ClickContinueBtn()
        {
            var continueBtn = Driver.Instance.FindElement(By.Id("priceItinerarySubmit"));
            
            continueBtn.Click();
        }
    }
}
