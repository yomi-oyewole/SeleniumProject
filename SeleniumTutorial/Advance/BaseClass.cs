using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    public abstract class BaseClass
    {



        public BaseClass()
        {
            
            PageFactory.InitElements(DriverContent.Drive, this);
        }
    }
}
