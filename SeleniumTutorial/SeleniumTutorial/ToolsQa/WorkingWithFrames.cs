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
    class WorkingWithFrames:Base
    {

        [FindsBy(How =How.Id, Using = "IF1")]
        public IWebElement Frame1 { get; set; }

        [FindsBy(How = How.Name, Using ="firstname")]
        public IWebElement Firstname { get; set; }

        [FindsBy(How = How.Name,Using ="lastname")]
        public IWebElement Lastname { get; set; }

        [FindsBy(How = How.Id, Using ="sex-1")]
        public IWebElement genderFemale { get; set; }

        [FindsBy(How = How.Id, Using ="sex-0")]
        public IWebElement genderMale { get; set; }

        [FindsBy(How =How.Name,Using ="iframe2")]
        public IWebElement Frame2 { get; set; }

        [FindsBy(How = How.Id, Using = "ui-id-3")]
        public IWebElement tab3 { get; set; }
    }
}
