namespace AdvanceFrameWork.BasePage
{
   public class TestInitialization:ParentBase
    {
        private static readonly string AUT = "http://newtours.demoaut.com/";
        private static readonly string browser = "chrome";

        public static log4net.ILog log=
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public void StarAut()
        {
            DriverContent.Drivers = BrowserFactory.BrowserSelection(browser, AUT);
        }

       
    }
}
