using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using System.Configuration;
namespace ZRQA
{
    [TestClass]
    public class LogIn
    {
        public static IWebDriver driver { get; set; }
        [TestMethod]
        public void ValidateLogin()

        {
            var chromOptions = new ChromeOptions();
            // chromOptions.AddArgument("-no-sandbox");
            chromOptions.AddArgument("headless");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromOptions);
            driver.Navigate().GoToUrl("https://zrqa.qwikcoverage.com/Login/Login.aspx");
             
             
        }
    }
}
