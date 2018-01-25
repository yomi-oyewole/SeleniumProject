using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace AdvanceFrameWork.BasePage
{
    public class ParentBase 
    {
        private IWebDriver _driver { get; set; }
        
        public Base CurrentPage { get; set; }

       

        protected TPage GetInstance<TPage>() where TPage : Base, new()
        {
            TPage pageInstance = new TPage();
            {
                _driver = DriverContent.Drivers;
            }

            PageFactory.InitElements(DriverContent.Drivers, pageInstance);

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : Base
        {
            return (TPage)this;
        }
    }

    
}
