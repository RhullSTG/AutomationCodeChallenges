using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;

namespace AutomationCodeChallenge1
{
    [TestClass]
    public class AutomationTests : NavbarLinks
    {
        public static IWebDriver driver; 

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();
        }

        /*
         * AUTOMATION CODE CHALLENGE #1
         */
        [TestMethod]
        public void TestForVerifyWebsite()
        {
            string url = "https://www.skiutah.com";
            string validationString = "Ski Utah";

            driver.Navigate().GoToUrl(url);

            string actualTitle = driver.Title;
            string subActualTitle = actualTitle.Substring(0, 8);

            Assert.IsTrue(subActualTitle == validationString);
        }

        /*
        * AUTOMATION CODE CHALLENGE #2
        */
        [TestMethod]
        public void TestForNavigation()
        {
            string url = "https://www.skiutah.com";
            string validationString = "Ski Utah";

            driver.Navigate().GoToUrl(url);


            
        }
    }
}
