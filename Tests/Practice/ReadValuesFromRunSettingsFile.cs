using AventStack.ExtentReports;
using HSINTechCICDAutomationPipeline.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace HSINTechCICDAutomationPipeline.Tests.Practice
{
    //[TestClass]
    public class ReadValuesFromRunSettingsFile : TestBase
    {

        // This is for the runsetting file to instantiate
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void TestMethod_ReadValuesFromRunSettingsFile()
        {

            //===========================================================================

            OpenGoogleAndEnterValue();

        }

        public void OpenGoogleAndEnterValue()
        {

            //========================== Headless Mode ==========================
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless=new");
            driver = new ChromeDriver(options);
            //====================================================

            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            //driver = new ChromeDriver();



            string googleurl = TestContext.Properties["GoogleURL"].ToString();
            Console.WriteLine(googleurl);
            System.Diagnostics.Trace.WriteLine(googleurl);


            driver.Navigate().GoToUrl(googleurl);
            Console.WriteLine("Open google home page");

            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize the window");

            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Selenium ChromeDriver");
            Console.WriteLine("Enter Selenium ChromeDriver into Search Text box");

            searchBox.Submit();
            Console.WriteLine("Click Search / Submit");
            Thread.Sleep(3000);
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
