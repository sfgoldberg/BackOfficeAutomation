using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Threading;


namespace Back_Office_Automation
{
    public class Driver
    {
        public static IWebDriver Instance
        {
            get;
            set;
        }

        public static void Initialize()
        {
            var profile = new FirefoxProfile();
            var options = new ChromeOptions();
            var agent = ConfigurationManager.AppSettings["Browser"];

            switch (agent)
            {

                case "Firefox":
                    profile.SetPreference("general.useragent.override", "Mozilla/5.0 (iPad; CPU OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5355d Safari/8536.25");
                    Instance = new FirefoxDriver(profile);
                    break;
                case "Chrome":
                    options.AddArgument("--user-agent=Mozilla/5.0 (iPad; CPU OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5355d Safari/8536.25");
                    options.AddArgument("start-maximized");
                    Instance = new ChromeDriver(options);
                    break;
                default:
                    Instance = new ChromeDriver();
                    break;
            }

            TurnOnWait();
        }

        public static void Close()
        {
            Instance.Quit();
        }

        #region Wait

        public static void Wait(int sec)
        {
            Thread.Sleep(sec * 1000);
        }

        public static IWebElement WaitElement(By by, int time = 10)
        {
            try
            {
                var wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(time));
                return wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException)
            {
                return null;
            }
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
        }

        #endregion
    }
}

