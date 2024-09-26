using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class NavigatingCommands
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
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
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            driver.Navigate().Back();
            Thread.Sleep(3000);

            driver.Navigate().Forward();
            Thread.Sleep(3000);

            driver.Navigate().Refresh();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}

