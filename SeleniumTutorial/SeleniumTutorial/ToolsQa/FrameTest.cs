using AdvanceFrameWork.BasePage;
using NUnit.Framework;
using SeleniumTutorial.MercuryTourDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial.ToolsQa
{
    class FrameTest:ParentBase
    {

        [SetUp]
        public void setup()
        {
            DriverContent.Drivers = BrowserInit.BrowserSelection("chrome", "http://toolsqa.com/iframe-practice-page/");
        }

        [Test]
        public void ActualTest()
        {
            CurrentPage = GetInstance<WorkingWithFrames>();
            DriverContent.Drivers.Manage().Window.Maximize();
            DriverContent.Drivers.SwitchTo().Frame(CurrentPage.As<WorkingWithFrames>().Frame1);
            CurrentPage.As<WorkingWithFrames>().Firstname.SendKeys("Florence");
            CurrentPage.As<WorkingWithFrames>().Lastname.SendKeys("Oluokun");
            CurrentPage.As<WorkingWithFrames>().genderFemale.Click();
            DriverContent.Drivers.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            DriverContent.Drivers.SwitchTo().Frame(CurrentPage.As<WorkingWithFrames>().Frame2);
            CurrentPage.As<WorkingWithFrames>().tab3.Click();
            DriverContent.Drivers.Quit();
        }
    }
}
