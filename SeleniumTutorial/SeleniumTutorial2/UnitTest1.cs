using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using SeleniumTutorial2.PageObj;
using Advance;
using AventStack.ExtentReports;

namespace SeleniumTutorial2
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            DriverContent.Drive = new FirefoxDriver();
           



            DriverContent.Drive.Navigate().GoToUrl("http://newtours.demoaut.com/");
            ObjectClass obj = new ObjectClass();
            obj.UserName.SendKeys("tutorial");
            obj.Password.SendKeys("tutorial");
            obj.LoginBtn.Click();





        }
    }
}
