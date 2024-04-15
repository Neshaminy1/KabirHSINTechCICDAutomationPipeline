using AventStack.ExtentReports;
using HSINTechCICDAutomationPipeline.Core;
using MongoDB.Bson.Serialization.Serializers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace HSINTechCICDAutomationPipeline.Tests.Practice
{
   // [TestClass]
    public class ReadValuesFromRunSettingsFile : TestBase
    {

        // This is for the runsetting file to instantiate
        public TestContext? TestContext { get; set; }

        //Declare variable
        public IWebDriver? driver;


        [TestMethod]
        public void TestMethod_ReadValuesFromRunSettingsFile()
        {

            //===========================================================================

            OpenGoogleAndEnterValue();

        }

        public void OpenGoogleAndEnterValue()
        {

            //========================== Headless Mode ==========================
           // ChromeOptions options = new ChromeOptions();
          //  options.AddArgument("--headless=new");
          //  driver = new ChromeDriver(options);
            //====================================================

            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();


            string googleurl = TestContext.Properties["GoogleURL"].ToString();
            //var googleurl = TestContext.Properties["GoogleURL"].ToString();

            Console.WriteLine("Get url:" + googleurl);
            System.Diagnostics.Trace.WriteLine(googleurl);


            driver.Navigate().GoToUrl(googleurl);
            Console.WriteLine("Open google home page");

            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize the window");
        }


        [TestCleanup]
        public void TeardownTest()
        {
            driver.Quit();
            Console.WriteLine("Close Browser");
            Console.WriteLine("Quit Driver");
        }
    }
}
