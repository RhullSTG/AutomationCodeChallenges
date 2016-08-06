using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
                    driver.FindElement(By.XPath("//*[@id=\"ski-utah-welcome-map\"]/div/div[4]/div[2]/div[1]/label[1]")).Click();

                    IWebElement resortDetails =
                        driver.FindElement(By.CssSelector(".map-Popover--" + resortName.ToLower()));
                    IWebElement minutesFromAirport = resortDetails.FindElement(By.XPath("./div[2]/p/span[3]")); 
                }
                catch (ElementNotVisibleException ex)
                { 
                    Console.WriteLine("Could not find element(s)");
                }
            }
        }
    }
}
