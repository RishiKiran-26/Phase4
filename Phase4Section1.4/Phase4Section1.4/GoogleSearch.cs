using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Phase4Section1._4
{
    [TestClass]
    public class GoogleSearch
    {
        [TestMethod]
        public void Test()
        {
            using (var driver = new ChromeDriver("C:\\Users\\DELL\\OneDrive\\Desktop"))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.google.com");
            }
        }
    }
}
