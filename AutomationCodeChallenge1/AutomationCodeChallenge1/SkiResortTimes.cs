using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            if (resortName == "Beaver Mountain")
            {

                driver.FindElement(By.XPath("//*[@id=\"ski-utah-welcome-map\"]/div")).Click();

                Thread.Sleep(10000);

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                driver.FindElement(
                    By.CssSelector(
                        "#ski-utah-welcome-map > div > div.map-Container-menu > div.map-Container-compare.is-expanded > label > span.map-Compare-selected.map-Compare-selected--reset"))
                    .Click();

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                IWebElement resortDetails =
                    driver.FindElement(
                        By.XPath("//*[@id=\"ski-utah-welcome-map\"]/div/div[4]/div[2]/div[1]/label[1]"));
                resortDetails.Click();

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                var minutesFromAirport =
                    driver.FindElement(
                        By.XPath(
                            "//*[@id=\"ski-utah-welcome-map\"]/div/div[4]/div[2]/div[1]/div[2]/div[2]/p/span[3]"))
                        .Text;

                Console.WriteLine("Beaver Mountain: " + minutesFromAirport + " Minutes");
            }

            if (resortName == "Cherry Peak")
                {

                        driver.FindElement(By.XPath("//*[@id=\"ski-utah-welcome-map\"]/div")).Click();

                        Thread.Sleep(10000);

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                        driver.FindElement(
                            By.CssSelector(
                                "#ski-utah-welcome-map > div > div.map-Container-content > div.map-Areas > div.map-Area.map-Area--logan > label.map-Area-label.js-map-popover-toggle.map-Area-label--cherry"))
                            .Click();

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                        IWebElement resortDetails =
                            driver.FindElement(
                                By.XPath("//*[@id=\\\"ski-utah-welcome-map\\\"]//p/span[3]"));
                        resortDetails.Click();

                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

                        var minutesFromAirport =
                            driver.FindElement(
                                By.XPath(
                                    "//*[@id=\"ski-utah-welcome-map\"]/div/div[4]/div[2]/div[1]/div[2]/div[2]/p/span[3]"))
                                .Text;

                        Console.WriteLine("Cherry Peak: " + minutesFromAirport + " Minutes");
                    }
                     
        }
    }
}
