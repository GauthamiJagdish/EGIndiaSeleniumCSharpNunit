using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace NUnitSeleniumC_training.Selenium
{
    internal class DynamicWebElements
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.cavai.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            //contains text
            //span[contains(text(),'Menu')]
            //a[contains(text(),'Privacy Policy')]

            //multiple elements clubbing
            //img[@class='ThreeColumns_column__icon__JOFe6' and @xpath='1']


            //starts-with
            //a[starts-with(text(),'Terms of use')]

            //ends-with

            //indexing
            //(//p[@class='ThreeColumns_column__text__pCGH7'])[1]
            //(//p[@class='ThreeColumns_column__text__pCGH7'])[2]
            //(//p[@class='ThreeColumns_column__text__pCGH7'])[3]







        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}

