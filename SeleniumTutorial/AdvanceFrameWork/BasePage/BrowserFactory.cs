using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace AdvanceFrameWork.BasePage
{
    class BrowserFactory
    {
        
        private static IWebDriver driver;
        private static string ChromeDriverPath =
            @"c:\Users\Benjamin\source\repos\Selenium Tutorial\packages\Selenium.WebDriver.ChromeDriver.2.34.0\driver\win32\";

        public static IWebDriver BrowserSelection(string broswerName, string Url)
        {
            if (broswerName.Equals("firefox", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new FirefoxDriver();
            }
            else if (broswerName.Equals("chrome", StringComparison.InvariantCultureIgnoreCase))
            {
                //ChromeOptions options = new ChromeOptions();
                // options.AddArgument("--headless");
                //driver = new ChromeDriver(options);
                driver = new ChromeDriver();
            }
            else if (broswerName.Equals("Explorer", StringComparison.InvariantCultureIgnoreCase))
            {
                driver = new InternetExplorerDriver();
            }
            driver.Navigate().GoToUrl(Url);
            return driver;
        }

    }

}

