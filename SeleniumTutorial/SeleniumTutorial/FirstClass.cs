using AdvanceFrameWork.BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTutorial.MercuryTourDemo;
using System;
using System.Collections.Generic;

namespace SeleniumTutorial
{
    public class FirstClass : TestInitialization
    {
        
      

        static void Main()
        {
           
        }

        [SetUp]
         public void SetupMethod()
        {

            StarAut();
            log.Info("browser opening....");
            Console.WriteLine("browser opening....");
            Console.WriteLine("browser open");
           
            
           


        }
        [Test]
        public void LoginTest()
        {
                    

            CurrentPage = GetInstance<HomePage>();
            log.Info("getting instance of current page");
            CurrentPage = CurrentPage.As<HomePage>().UserLogin("tutorial", "tutorial");
            log.Info("Got instance. User logging in");
            
            DriverContent.Drivers.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            log.Debug("waiting for web element initalization in current page");

            CurrentPage.As<FlightFinder>().OneWayTrip.Click();
            bool Result = CurrentPage.As<FlightFinder>().OneWayTrip.Selected;
            Assert.AreEqual(Result, true);
            CurrentPage.As<FlightFinder>().SelectPassengers();
            CurrentPage.As<FlightFinder>().EconomyClass.Click();
            
            //Console.WriteLine(CurrentPage.As<FlightFinder>().ListOfDepartLocation());
            //Thread.Sleep(5000);

           // SelectElement Sel = new SelectElement(CurrentPage.As<FlightFinder>().DepartingAirport);
            //IList<IWebElement> DepartAir = Sel.Options;
            //Console.WriteLine("List of all airports");
            foreach (IWebElement Dep in CurrentPage.As<FlightFinder>().SelectDepartOption())
            {
                String d = Dep.Text;
               
                Console.WriteLine(d);
                log.Info(d);

            }

            SelectUtilities.SelectUtil(CurrentPage.As<FlightFinder>().DepartingAirport, "Text", "New York");
            SelectUtilities.SelectUtil(CurrentPage.As<FlightFinder>().DepartingMonth, "value", "6");
            SelectUtilities.SelectUtil(CurrentPage.As<FlightFinder>().DepartingDay, "index", "3");

            

            //Here new page object is returned to CurrentPage
            CurrentPage = CurrentPage.As<FlightFinder>().ContinueBtn_lnk();

            CurrentPage.As<SelectFlight>().OutBlueSkiesAirlines.Click();
            CurrentPage.As<SelectFlight>().ReturnBlueSkiesAirlines.Click();

            String parentHandle = DriverContent.Drivers.CurrentWindowHandle;
            Console.WriteLine("page handle is: " + parentHandle);



            DriverContent.Drivers.Quit();

        }


       
    }
}
