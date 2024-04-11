﻿using AventStack.ExtentReports;
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

            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();

            string GoogleURL = TestContext.Properties["GoogleURL"].ToString();
            Console.WriteLine(GoogleURL);
            System.Diagnostics.Trace.WriteLine(GoogleURL);


            driver.Navigate().GoToUrl(GoogleURL);
            Console.WriteLine("Open google home page");
            exChildTest.Log(Status.Pass, "Open google home page");

            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize the window");
            exChildTest.Log(Status.Pass, "Maximize the window");

            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Selenium ChromeDriver");
            Console.WriteLine("Enter Selenium ChromeDriver into Search Text box");
            exChildTest.Log(Status.Pass, "Enter Selenium ChromeDriver into Search Text box");

            searchBox.Submit();
            Console.WriteLine("Click Search / Submit");
            exChildTest.Log(Status.Pass, "Click Search / Submit");
            Thread.Sleep(3000);
        }


    }
}