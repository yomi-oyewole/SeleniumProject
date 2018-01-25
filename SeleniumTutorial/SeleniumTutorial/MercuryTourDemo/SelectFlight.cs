using AdvanceFrameWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTutorial.MercuryTourDemo
{
    class SelectFlight : Base
    {

        [FindsBy(How = How.CssSelector, Using = "input[value='Pangea Airlines$362$274$9:17']")]
        public IWebElement OutPangeaAirlines { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Blue Skies Airlines$360$270$5:03']")]
        public IWebElement OutBlueSkiesAirlines { get; set; }

        [FindsBy(How =How.CssSelector, Using = "input[value='Unified Airlines$363$281$11:24']")]
        public IWebElement OutUnitedAirlines { get; set; }

        [FindsBy(How =How.CssSelector, Using = "input[value='Pangea Airlines$632$282$16:37']")]
        public IWebElement ReturnPangeaAirlines { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Blue Skies Airlines$630$270$12:23'")]
        public IWebElement ReturnBlueSkiesAirlines { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[vlaue='Unified Airlines$633$303$18:44'")]
        public IWebElement ReturnUnitedAirlines { get; set; }

        [FindsBy(How = How.Name, Using ="reserveFlights")]
        public IWebElement lnkContinueBtn { get; set; }
    }
}
