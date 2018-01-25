using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SeleniumTutorial2
{
    public class ExtentInit
    {
        public static ExtentReports reportInstance;
        public static ExtentHtmlReporter htmlreport;
        public static ExtentTest test;
        public static string path;

        public static ExtentReports GetReportInstance()
        {
            path = @"c: \Users\testi_000\Documents\yomi1.html";
            htmlreport = new ExtentHtmlReporter(path);
            reportInstance = new ExtentReports();
            reportInstance.AttachReporter(htmlreport);
            return reportInstance;
        }

        public static void TestProperties()
        {
            test = reportInstance.CreateTest("Correct username and pass");
            test.AssignAuthor("Oyewole Yomi");
            reportInstance.AddSystemInfo("Host Name", "Benjamin");
            reportInstance.AddSystemInfo("Envirionment", "QA");
            htmlreport.Configuration().DocumentTitle = "Login Functionality";
            htmlreport.Configuration().ReportName = "Regression Test";
            
        }
    }
}
