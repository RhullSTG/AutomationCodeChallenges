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

       public void PlanYourTripSubMenu(string subNavBarBtn)
       {

            var action = HoverOverNavBarElement("https://www.skiutah.com", "//div[@id=\'top_menu\']/ul/li/a");
            action.Perform();

            if (subNavBarBtn == "Action")
            {
                var actionBtn =
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Activities\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Food + Drink")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Food + Drink\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Lodging")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Lodging\')]")));
                action.Click(actionBtn).Perform();
            }
            if (subNavBarBtn == "Retail + Rental")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Retail + Rental\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Reservation Experts")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Reservation Experts\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Ski Resorts")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Ski Resorts\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Ski School")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Ski School\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Transportation")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Transportation\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Utah Events")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Utah Events\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Photos")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Photos\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Videos")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Videos\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Stories")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Stories\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Compare Resorts")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Compare Resorts\')]")));
                action.Click(actionBtn).Perform();
            }

        }

       public void ResortsAndSnowSubMenu(string subNavBarBtn)
       {
            var action = HoverOverNavBarElement("https://www.skiutah.com", "\"//div[@id=\\\'top_menu\\\']/ul/li[2]/a\"");
            action.Perform();

            
            if (subNavBarBtn == "Resort Comparison")
            {
                var actionBtn =
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Resort Comparison\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Alta")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Alta\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Beaver Mountain")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Beaver Mountain\')]")));
                action.Click(actionBtn).Perform();
            }
            if (subNavBarBtn == "Brian Head")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Brian Head\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Brighton")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Brighton\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Deer Valley")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Deer Valley\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Eagle Point")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Eagle Point\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Nordic Valley")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Nordic Valley\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Park City")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Park City\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Powder Mountain")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Powder Mountain\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Snowbasin")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Snowbasin\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Snowbird")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Snowbird\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Solitude")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Solitude\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Sundance")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Sundance\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Cross Country")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Cross Country - Nordic Locations\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Snow Report")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Snow Report\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Mobile App & TV Display")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Mobile App & TV Display\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Live Mountain Cams")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Live Mountain Cams\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Printable Snow Report")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Printable Snow Report\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Why Utah Snow?")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Why Utah Snow?\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "All Trail Maps")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'All Trail Maps\')]")));
                action.Click(actionBtn).Perform();
            }

        }

       public void DealsSubMenu(string subNavBarBtn)
       {
            var action = HoverOverNavBarElement("https://www.skiutah.com", "//a[contains(text(),\'Deals\')]");
            action.Perform();

            if (subNavBarBtn == "All Deals")
            {
                var actionBtn =
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'All Deals\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Lodging")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id=\'top_menu\']/ul/li[4]/ul/li/ul/li[3]/a")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Retail & Rental")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Retail & Rental\')]")));
                action.Click(actionBtn).Perform();
            }
            if (subNavBarBtn == "Transportation")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id=\'top_menu\']/ul/li[4]/ul/li/ul/li[5]/a")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Learn to Ski Program")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Learn to Ski Program\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Beginner")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Beginner\')]")));
                action.Click(actionBtn).Perform();
            }

        }

       public void PassesSubMenu(string subNavBarBtn)
       {
            var action = GoToNavBarElement("https://www.skiutah.com", "//a[contains(text(),\'Deals\')]");
            action.Perform();

           if (subNavBarBtn == "Purchase Utah Lift Tickets")
            {
                var actionBtn =
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Purchase Utah Lift Tickets\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "5th and 6th Grade Passport")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'5th and 6th Grade Passport\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Ski Utah Yeti Pass")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Ski Utah Yeti Pass\')]")));
                action.Click(actionBtn).Perform();
            }
            if (subNavBarBtn == "Transportation")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id=\'top_menu\']/ul/li[4]/ul/li/ul/li[5]/a")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Learn to Ski Program")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Learn to Ski Program\')]")));
                action.Click(actionBtn).Perform();
            }

            if (subNavBarBtn == "Beginner")
            {
                var actionBtn =
                 wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),\'Beginner\')]")));
                action.Click(actionBtn).Perform();
            }
        }

       private static Actions HoverOverNavBarElement(string url, string element)
       {
           driver.Navigate().GoToUrl(url);
           driver.Manage().Window.Maximize();

           wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

           var planYourTripBtn =
               wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
           Actions action = new Actions(driver);
           action.MoveToElement(planYourTripBtn).Perform();
           return action;
       }
   }

}
