using AdvanceFrameWork;
using AdvanceFrameWork.BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace SeleniumTutorial.MercuryTourDemo
{
    class FlightFinder: Base

    {
        
      

        [FindsBy(How = How.CssSelector, Using = "input[value='roundtrip']")]
        public IWebElement RoundTrip { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='oneway']")]
        public IWebElement OneWayTrip { get; set; }

        [FindsBy(How = How.Name, Using = "passCount")]
        public IWebElement PassengerSelection { get; set; }

        [FindsBy(How = How.Name, Using = "fromPort")]
        public IWebElement DepartingAirport { get; set; }

        [FindsBy(How = How.Name, Using = "fromMonth")]
        public IWebElement DepartingMonth { get; set; }

        [FindsBy(How = How.Name, Using = "fromDay")]
        public IWebElement DepartingDay { get; set; }

        [FindsBy(How = How.Name, Using = "toPort")]
        public IWebElement ArrivingAirport { get; set; }

        [FindsBy(How = How.Name, Using = "toMonth")]
        public IWebElement ArrivalMonth { get; set; }

        [FindsBy(How = How.Name, Using = "toDay")]
        public IWebElement ArrivalDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Coach']")]
        public IWebElement EconomyClass { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Business']")]
        public IWebElement BusinessClass { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='First']")]
        public IWebElement FirstClass { get; set; }

        [FindsBy(How = How.Name, Using = "findFlights")]
        public IWebElement lnkContinueBtn { get; set; }


        public void SelectPassengers()
        {
            SelectUtilities.SelectUtil(PassengerSelection, "index", "2");
          
        }

        public SelectFlight ContinueBtn_lnk()
        {
            lnkContinueBtn.Click();
            return GetInstance<SelectFlight>();
        }

        public IList<IWebElement> SelectDepartOption()
        {
            return Utilities.GetDropdownValues(DepartingAirport);
        }
        /*public string IList ListOfDepartLocation()
        {
            string dd = null;
            SelectElement Sel = new SelectElement(DepartingAirport);
            IList<IWebElement> DepartAirpout = Sel.Options;
           // dd = DepartAirpout.Count;

            foreach (IWebElement dep in DepartAirpout)
            
            {
                dd = dep.Text;
               
            }
            return dd;
            
            
        }*/



    }
}
