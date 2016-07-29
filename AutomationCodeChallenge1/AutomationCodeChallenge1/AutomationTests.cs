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

            string actualTitle = driver.Title; //This string is "Ski Utah - Ski Utah." 
            string subActualTitle = actualTitle.Substring(0, 8); // Gets a substring of "Ski Utah" from the string "Ski Utah - Ski Utah."

            Assert.IsTrue(subActualTitle == validationString);
        }

        /*
        * AUTOMATION CODE CHALLENGE #2
        */
        [TestMethod]
        public void TestForNavigation()
        {
            
            NavBarNavigation("Plan Your Trip");
            NavBarNavigation("Resorts & Snow");
            NavBarNavigation("Stories");
            NavBarNavigation("Deals");
            NavBarNavigation("Passes");
            NavBarNavigation("Explore");

        }

        /*
         * AUTOMATION CODE CHALLENGE #3
         */
        [TestMethod]
        public void TestForSubMenuNavigation()
        {
            PlanYourTripSubMenu("Action");
            PlanYourTripSubMenu("Food + Drink");
            PlanYourTripSubMenu("Lodging");
            PlanYourTripSubMenu("Retail + Rental");
            PlanYourTripSubMenu("Reservations");
            PlanYourTripSubMenu("Ski Resorts");
            PlanYourTripSubMenu("Ski School");
            PlanYourTripSubMenu("Transportation");
            PlanYourTripSubMenu("Utah Events");
            PlanYourTripSubMenu("Photos");
            PlanYourTripSubMenu("Videos");
            PlanYourTripSubMenu("Stories");
            PlanYourTripSubMenu("Compare Resorts");

            ResortsAndSnowSubMenu("Resort Comparison");
            ResortsAndSnowSubMenu("Alta");
            ResortsAndSnowSubMenu("Beaver Mountain");
            ResortsAndSnowSubMenu("Brian Head");
            ResortsAndSnowSubMenu("Brighton");
            ResortsAndSnowSubMenu("Cherry Peak");
            ResortsAndSnowSubMenu("Deer Valley");
            ResortsAndSnowSubMenu("Eagle Point");
            ResortsAndSnowSubMenu("Nordic Valley");
            ResortsAndSnowSubMenu("Park City");
            ResortsAndSnowSubMenu("Powder Mountain");
            ResortsAndSnowSubMenu("Snowbasin");
            ResortsAndSnowSubMenu("Snowbird");
            ResortsAndSnowSubMenu("Solitude");
            ResortsAndSnowSubMenu("Sundance");
            ResortsAndSnowSubMenu("Sundance");
            ResortsAndSnowSubMenu("Cross Country - Nordic Locations");

            DealsSubMenu("All Deals");
            DealsSubMenu("Lodging");
            DealsSubMenu("Retail & Rental");
            DealsSubMenu("Transportation");
            DealsSubMenu("Learn to Ski Program");
            DealsSubMenu("Beginner");


        }

        /*
         * AUTOMATION CODE CHALLENGE #4
         */

        [TestMethod]
        public void TestForSkiResort()
        {
            
        }

        /*
         * AUTOMATION CODE CHALLENGE #5
         */

        [TestMethod]
        public void ReturnListofResorts(string what, string byResort, string subCategory)
        {
            
        }

        /*
        * AUTOMATION CODE CHALLENGE #6, #7, and #8 are web crawlers
        */

    }
}
