using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class Action
    {
        IWebDriver driver;
        string downloadPath = "C:\\Users\\gauja\\Downloads";

        [SetUp]
        public void StartBrowser()
        {
            // Configure the web driver manager to set up the Firefox capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // Initialize the web driver
            driver = new FirefoxDriver();

            // Launch the Firefox browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {
            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));
            new Actions(driver)
                .ContextClick(TdyDeal)//or DoubleClick
                .Perform();
            Thread.Sleep(1000);


        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}