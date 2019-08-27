using System;/*
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using OpenQA.Selenium;*/
using OpenQA.Selenium.Remote;//grid
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumGRID_withDOCKER
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class Hooks : Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void Intialize()
        {
            ChooseWebDriver(_browserType);
        }

        public void ChooseWebDriver(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                //driver = new ChromeDriver();
                ChromeOptions cap = new ChromeOptions();
                //DesiredCapabilities cap = DesiredCapabilities;//.Chrome();
                //cap.AddAdditionalCapability("version", "");
                //cap.AddAdditionalCapability("platform", "LINUX");
                driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4446/wd/hub"), cap);
                //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
            else if (browserType == BrowserType.Firefox)
            {
                //driver = new FirefoxDriver();
                FirefoxOptions cap = new FirefoxOptions();
                //DesiredCapabilities cap = DesiredCapabilities;//.Firefox();
                //cap.AddAdditionalCapability("version", "");
                //cap.AddAdditionalCapability("platform", "LINUX");
                driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4446/wd/hub"), cap);
                //driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            }
        }
        /*            public void ChooseWebDriver(BrowserType browserType)
                    {
                        if (browserType == BrowserType.Chrome)
                            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                        else if (browserType == BrowserType.FireFox)
                            driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    }*/
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
