using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial.MercuryTourDemo
{
    static class SelectUtilities
    {
       static SelectElement Sel;

       

        public static void SelectUtil(IWebElement Element, string locator, string value)
        {
            

            if(locator.Equals("Value", StringComparison.CurrentCultureIgnoreCase))
            {
                Sel = new SelectElement(Element);
                  Sel.SelectByValue(value);
            }
            else if (locator.Equals("Text", StringComparison.CurrentCultureIgnoreCase))
            {
                Sel = new SelectElement(Element);
                Sel.SelectByText(value);
            }
            else if (locator.Equals("Index", StringComparison.CurrentCultureIgnoreCase))
               {
                Sel = new SelectElement(Element);
                Sel.SelectByIndex(Int32.Parse(value));
               
            }
           
        }

    }
}
