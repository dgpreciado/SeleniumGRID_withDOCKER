using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumGRID_withDOCKER
{
    public class Base
    {
        //System.addProperty("webdriver.chrome.driver", "C:\Users\dgpreciado\source\repos\NUnitTestProject1\NUnitTestProject1\bin\Debug\netcoreapp2.1\chromedriver.exe");
        //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("C:\ELE");
        //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
        //IWebDriver Wd = new FirefoxDriver(service);
        public IWebDriver driver { get; set; }

    }
}
