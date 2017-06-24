using OpenQA.Selenium;

namespace Back_Office_Automation.Objects.Southwest
{
    class PriceReservationsPage
    {

        //expected page title
        public static string Title => "Southwest Airlines - Pricing and Restrictions";

        //click continue button below air total
        public static void ClickContinue()
        {
            var continueBtn = Driver.Instance.FindElement(By.Id("priceSubmitButton"));

            continueBtn.Click();
        }
    }
}
