using Advance;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial2.PageObj
{
    class ObjectClass:BaseClass
    {
        

    
        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement LoginBtn { get; set; }
    }
}
