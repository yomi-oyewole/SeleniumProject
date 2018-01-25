

using AdvanceFrameWork.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTutorial.MercuryTourDemo;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumTutorial.ToolsQa
{
    class WindowHandlesTest:ParentBase
    {


        [SetUp]
        public void SetUpMethod()
        {
            DriverContent.Drivers = BrowserInit.BrowserSelection("firefox", "http://toolsqa.com/automation-practice-switch-windows/");
        }

       
        [Test]
        public void TestMethod()
        {
            string parentHandle;
            //string handles;
            CurrentPage = GetInstance<HandlingWindows>();
            parentHandle = DriverContent.Drivers.CurrentWindowHandle;
            Console.WriteLine("this is the parent handle: " + parentHandle);
            CurrentPage.As<HandlingWindows>().newBrowserWindow.Click();
            IList<string> allWindowHandles = DriverContent.Drivers.WindowHandles;
            int size = allWindowHandles.Count;
            Console.WriteLine(size);
            foreach (string handles in allWindowHandles)
            {
                Console.WriteLine(handles);

                // if (handles != parentHandle)
                if (!handles.Equals(parentHandle))
                {
                    DriverContent.Drivers.SwitchTo().Window(handles);
                    DriverContent.Drivers.Manage().Window.Maximize();
                    DriverContent.Drivers.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
                    bool en = DriverContent.Drivers.FindElement(By.Id("trigger-overlay")).Enabled;
                    Assert.True(en);
                    DriverContent.Drivers.Close();

                    break;
                }
                

            }
            DriverContent.Drivers.SwitchTo().Window(parentHandle);

            CurrentPage.As<HandlingWindows>().bntTimingAlert.Click();
            Thread.Sleep(5000);
            IAlert alert = DriverContent.Drivers.SwitchTo().Alert();
            alert.Accept();


            DriverContent.Drivers.Quit();


        }
    }
}
