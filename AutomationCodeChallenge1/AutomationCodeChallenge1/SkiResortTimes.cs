using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationCodeChallenge1
{
    class SkiResortTimes
    {
        public void GetTimeFromAirport(string resortName)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.skiutah.com/");
            driver.Manage().Window.Maximize();

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            if (resortName == "Beaver Mountain")
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"ski-utah-welcome-map\"]/div")).Click();

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

                    driver.FindElement(By.CssSelector("#ski-utah-welcome-map > div > div.map-Container-menu > div.map-Container-compare.is-expanded > label > span.map-Compare-selected.map-Compare-selected--reset")).Click();

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                    IWebElement resortDetails =
                        driver.FindElement(By.XPath("//input[@id=\'map-popover-beaver-mountain\']"));
                    resortDetails.Click();

                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                    var minutesFromAirport = resortDetails.FindElement(By.CssSelector("#ski-utah-welcome-map > div > div.map-Container-content > div.map-Areas > div.map-Area.map-Area--logan > div.map-Popover.map-Popover--beaver-mountain > div.map-Popover-content > p")).Text;

                    Console.WriteLine(minutesFromAirport);
                
                }
                catch (ElementNotVisibleException ex)
                { 
                    Console.WriteLine("Could not find element(s)");
                }
            }
        }
    }
}
