using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunitfram
{
    [TestFixture]
    internal class ExtentDemo
    {
        //Demo of Github
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\rohit\source\repos\Nunitfram\ExtentReport\Extentreport.html");
            extent.AttachReporter(htmlReporter);


        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }


        [Test]
        public void Test1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();

                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Launched");
                driver.Url = "https://www.facebook.com";

                IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
                email.SendKeys("Selenium C#");

                test.Log(Status.Info, "Email Entered");
                driver.Quit();
                test.Log(Status.Pass, "Test1 passed");

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (driver != null)
                    driver.Quit();
            }
        }



        [Test]
        public void Test2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test2").Info("Test Started");
                driver = new ChromeDriver();

                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Launched");
                driver.Url = "https://www.facebook.com";

                IWebElement email = driver.FindElement(By.XPath("//input[@id='emailfail']"));
                email.SendKeys("Selenium C#");

                test.Log(Status.Info, "Email Entered");
                driver.Quit();
                test.Log(Status.Pass, "Test1 passed");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail,ex.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                    driver.Quit();
            }
        }
    }
}
