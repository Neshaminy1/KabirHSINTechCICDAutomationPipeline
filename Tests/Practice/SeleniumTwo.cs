using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace HSINTechCICDAutomationPipeline.Tests.Practice
{
    [TestClass]
    public class SeleniumTwo
    {
        //Declare variable
        public IWebDriver driver;

        [TestMethod]
        public void TestMethod_SeleniumTwo()
        {
            //*****************************************************************************

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com");
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

