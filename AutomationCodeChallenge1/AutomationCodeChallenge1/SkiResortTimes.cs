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
    public class SkiResortTimes
    {

        public static IWebDriver driver = new ChromeDriver();
        public static WebDriverWait wait;

        public void GetTimeFromAirport(string skiResortName)
        {
            driver.Navigate().GoToUrl("https://www.skiutah.com/");
            driver.Manage().Window.Maximize();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            if (skiResortName == "Beaver Mountain")
            {

                var frontPageImage = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id=\'ski-utah-welcome-map\']/div/div[3]/img")));
                var action = new Actions(driver);
                action.Click(frontPageImage).Perform();

                driver.FindElement(By.XPath("//div[4]/label/span")).Click();

                var beaverMntBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#map-popover-beaver-mountain")));
                action.Click(beaverMntBtn).Perform();

                var time = driver.FindElement(
                    By.XPath("//*[@id=\"ski-utah-welcome-map\"]/div/div[4]/div[2]/div[1]/div[2]/div[2]/p/span[3]")).Text;

                Console.Write(time);

            }
        }

    }
}
