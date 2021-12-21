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
    internal class Unit
    {

        [Test]
        public void Test1()
        {

        }
        [Test]
        public void Setb()
        {
         IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
             ((ITakesScreenshot)driver).GetScreenshot()
                .SaveAsFile("C:\\Rohit\\Shot.png", ScreenshotImageFormat.Png);
        }
    }
}
