using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

//docker GRID
namespace SeleniumGRID_withDOCKER
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting : Hooks
    {
        public FirefoxTesting() : base(BrowserType.Firefox)
        {
        }

        [Test]
        public void FirefoxTest()
        {
            //System.Threading.Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            driver.FindElement(By.LinkText("LIBRARY")).Click();

            //if (driver.FindElement(By.LinkText("Articles & Databases")).Displayed == false) { }

            driver.FindElement(By.LinkText("E-Journals")).Click();
            driver.FindElement(By.LinkText("Research Guides")).Click();
            driver.FindElement(By.LinkText("Ask Us")).Click();
            Assert.That(driver.PageSource.Contains("University Library"), Is.EqualTo(true), "Not at the library page");
            driver.Close();
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void ChromeTest()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            driver.FindElement(By.LinkText("LIBRARY")).Click();

            //if (driver.FindElement(By.LinkText("Articles & Databases")).Displayed == false) { }

            driver.FindElement(By.LinkText("E-Journals")).Click();
            driver.FindElement(By.LinkText("Research Guides")).Click();
            driver.FindElement(By.LinkText("Ask Us")).Click();
            Assert.That(driver.PageSource.Contains("University Library"), Is.EqualTo(true), "Not at the library page");
            driver.Close();
        }
    }
}