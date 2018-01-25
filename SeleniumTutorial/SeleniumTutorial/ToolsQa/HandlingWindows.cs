using AdvanceFrameWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial.ToolsQa
{
    class HandlingWindows:Base
    {

        [FindsBy(How = How.Id, Using ="button1")]
        public IWebElement newBrowserWindow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='newMsgWin()']")]
        public IWebElement newMessageWindow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='newBrwTab()']")]
        public IWebElement newTabWindow { get; set; }

        [FindsBy(How =How.Id, Using ="alert")]
        public IWebElement btnAlert { get; set; }

        [FindsBy(How = How.Id, Using ="timingAlert")]
        public IWebElement bntTimingAlert { get; set; }






    }
}
