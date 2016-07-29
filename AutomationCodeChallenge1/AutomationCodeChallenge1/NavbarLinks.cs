using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationCodeChallenge1
{
   public class NavbarLinks 
   {
        public static IWebDriver driver = new ChromeDriver();
       public static WebDriverWait wait; 

       public void NavBarNavigation(string navBarButton)
        {

            driver.Navigate().GoToUrl("https://www.skiutah.com");

            string planYourTripExpectedTitle = "All Services - Ski Utah";
            string resortsAndSnowExpectedTitle = "Get the Official Utah Snow Report - Ski Utah";
            string storiesExpectedTitle = "Read About the Latest Happenings on the Slopes - Ski Utah";
            string dealsExpectedTitle = "Ski and Snowboard The Greatest Snow on Earth® - Ski Utah";
            string passesExcpectedTitle = "2016-17 Season Passes - Ski Utah";
            string exploreExpectedTitle = "Utah Areas 101 - Ski Utah"; 


            if (navBarButton == "Plan Your Trip")
            {
                driver.Navigate().GoToUrl("https://www.skiutah.com/members/listing");
                string planYourTripActualTitle = driver.Title;

                Assert.IsTrue( planYourTripActualTitle == planYourTripExpectedTitle);
            }
            if (navBarButton == "Resorts & Snow")
            {
                driver.Navigate().GoToUrl("https://www.skiutah.com/snowreport");
                string resortsAndSnowActualTitle = driver.Title;

                Assert.IsTrue(resortsAndSnowActualTitle == resortsAndSnowExpectedTitle);
            }
            if (navBarButton == "Stories")
            {
                driver.Navigate().GoToUrl("https://www.skiutah.com/blog");
                string storiesActualTitle = driver.Title;

                Assert.IsTrue(storiesActualTitle == storiesExpectedTitle);
            }
            if (navBarButton == "Deals")
            {
                driver.Navigate().GoToUrl("https://www.skiutah.com/deals-search");
                string dealsActualTitle = driver.Title;

                Assert.IsTrue(dealsActualTitle == dealsExpectedTitle);
            }
            if (navBarButton == "Passes")
            {
                driver.Navigate().GoToUrl("https://www.skiutah.com/passes/resort-season-passes");
                string passesActualTitle = driver.Title;

                Assert.IsTrue(passesActualTitle == passesExcpectedTitle);
            }
            if (navBarButton == "Explore")
            {
                driver.Navigate().GoToUrl("https://www.skiutah.com/explore/utah-regions-101");
                string exploreActualTitle = driver.Title;

                Assert.IsTrue(exploreActualTitle == exploreExpectedTitle);
            }
        }

       public void NavBarSubMenuNavigation()
       {

           driver.Navigate().GoToUrl("https://www.skiutah.com");
           driver.Manage().Window.Maximize();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var planYourTripBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id=\'top_menu\']/ul/li/a")));
            Actions action = new Actions(driver);
            action.MoveToElement(planYourTripBtn).Perform();

            
            driver.FindElement(By.XPath("//div[@id=\'top_menu\']/ul/li/ul/li/ul/li[2]/a")).Click(); //Goes to activities and verifies that it is the activities page
        }

    }

}
