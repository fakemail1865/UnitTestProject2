using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\ojas.sable.FRESHGRAVITY\\Documents\\chromedriver_win32");
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
    }
}
