using AdvanceFrameWork;
using AdvanceFrameWork.BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTutorial.MercuryTourDemo
{
    class HomePage : Base
    {
       
        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement LoginBtn { get; set; }

        public FlightFinder UserLogin(string Username, string password)
        {
            UserName.SendKeys(Username);
            Password.SendKeys(password);
            LoginBtn.Click();

            return GetInstance<FlightFinder>();
        }




    }
}
