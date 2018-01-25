using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumTutorial.MercuryTourDemo
{
    public static class BrowserInit
    {

        static IWebDriver driver;
        
        public static IWebDriver BrowserSelection(string BrowserName, string Url)
        {
            
            if (BrowserName.Equals("firefox", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new FirefoxDriver();
            }
            else if (BrowserName.Equals("chrome", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new ChromeDriver();
            }
            driver.Navigate().GoToUrl(Url);
            return driver;
        }

       
    }
}
