using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceFrameWork.BasePage
{
    public class Utilities
    {
        private static SelectElement select;

        public static IList<IWebElement> GetDropdownValues(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            IList<IWebElement> SelectOption = select.Options;
            return SelectOption;
        }

        public static void SelectElement(IWebElement element, string Locator, string selection)
        {
            if (Locator.Equals("value", StringComparison.InvariantCultureIgnoreCase))
            {
                select = new SelectElement(element);
                select.SelectByValue(selection);
            }
            else if (Locator.Equals("text", StringComparison.InvariantCultureIgnoreCase))
            {
                select = new SelectElement(element);
                select.SelectByText(selection);
            }
            else if (Locator.Equals("index", StringComparison.InvariantCultureIgnoreCase))
            {
                select = new SelectElement(element);
                select.SelectByIndex(Int32.Parse(selection));
            }

        }


    }
}
