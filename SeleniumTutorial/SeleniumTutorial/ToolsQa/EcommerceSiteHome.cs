using AdvanceFrameWork;
using AdvanceFrameWork.BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial.ToolsQa
{
    class EcommerceSiteHome:Base
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/header/nav/ul/li[2]/a")]
        public IWebElement lnkProductCategory { get; set; }

        [FindsBy(How =How.XPath, Using = "/html/body/div[2]/div/div/header/nav/ul/li[2]/ul/li[1]/a")]
        public IWebElement lnkAccessories { get; set; }



        public AccessoriesPage btnClickAccessories()
        {
            Actions actions = new Actions(DriverContent.Drivers);

            actions.MoveToElement(lnkProductCategory).Perform();
            actions.MoveToElement(lnkAccessories).Click().Perform();
            //actions.Click(lnkAccessories);

            return GetInstance<AccessoriesPage>();

    }

    }
}
