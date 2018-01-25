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
    class AccessoriesPage:Base
    {

        [FindsBy(How = How.CssSelector, Using = "img[class='product_image']")]
        public IList<IWebElement> pageImage { get; set; }


        [FindsBy(How = How.XPath, Using = 
            "/html/body/div[2]/div/div/div/div/div[1]/article/div/div/div[5]/div[2]/form/div[2]/div[1]/span/input")]
        public IWebElement AddToCart { get; set; }
       


        [FindsBy(How = How.CssSelector, Using = "em[class='count']")]
        public IWebElement ItemCount { get; set; }
    }


    
    
}
