using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace NUnitSeleniumC_training.Selenium
{
    internal class LaunchFirefox
    {
        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();


        }

        [Test]
        public void testcase1()
        {

            // launch the chrome browser
            driver.Navigate().GoToUrl("https://www.orangehrm.com/");
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
