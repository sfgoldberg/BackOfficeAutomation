using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Back_Office_Automation.Tests
{
    [TestClass]
    public class BaseTest
    {
        public TestContext TestContext { get; set; }

        // Use TestInitialize to run code before running each test 
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            Driver.Instance.Manage().Window.Maximize();
        }
        
        // Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
