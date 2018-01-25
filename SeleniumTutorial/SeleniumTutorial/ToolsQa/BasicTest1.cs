using AdvanceFrameWork.BasePage;

using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTutorial.MercuryTourDemo;
using System;
using System.Collections.Generic;

using System.Threading;

namespace SeleniumTutorial.ToolsQa
{
    class BasicTest1: TestInitialization
    {



        [SetUp]

        public void setUp()
        {
            DriverContent.Drivers = BrowserInit.BrowserSelection("firefox", "http://store.demoqa.com/");
            log.Info("browser is opening");
        }

        [Test]
        public void sampleTest()
        {
            int displayedImage = 0;

            CurrentPage = GetInstance<EcommerceSiteHome>();
           CurrentPage =  CurrentPage.As<EcommerceSiteHome>().btnClickAccessories();

            DriverContent.Drivers.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);


            IList<IWebElement> image = CurrentPage.As<AccessoriesPage>().pageImage;
            int size = image.Count;
            Console.WriteLine(size);
            log.Info("amount of image on page " + size);

            foreach (IWebElement images in image)
            {
                if (images.Displayed)
                {
                    displayedImage++;
                }
            }
            Console.WriteLine("displayed image is: " + displayedImage);
            log.Warn("this is warn message");

            CurrentPage.As<AccessoriesPage>().AddToCart.Click();

           Thread.Sleep(5000); 
            String ActualCount = CurrentPage.As<AccessoriesPage>().ItemCount.Text;

            SoftAssertions.SoftAsserAreEqual("1", ActualCount);


            /*try
            {
                Assert.AreEqual("1", ActualCount);
                if (ActualCount == "1")
                {
                    Console.WriteLine("both are equal");
                }
            }


            catch (AssertionException)
            {
                Console.WriteLine("They are not equal");
            }*/

            DriverContent.Drivers.Quit();

        }
    }
}
