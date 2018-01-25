using AdvanceFrameWork.BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AdvanceFrameWork
{
    public abstract class Base : ParentBase
    {
        

        public Base()
        {
            PageFactory.InitElements(DriverContent.Drivers, this);
        }


    }
}
