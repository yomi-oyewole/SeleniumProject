using OpenQA.Selenium;


namespace AdvanceFrameWork.BasePage
{
    public static class DriverContent
    {

        private static IWebDriver driver;

        public static IWebDriver Drivers
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }

    }
}
