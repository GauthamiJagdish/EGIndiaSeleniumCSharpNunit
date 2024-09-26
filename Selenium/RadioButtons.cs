using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class RadioButtons
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

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            // store the list of 
            IReadOnlyList<IWebElement> RadioButtons = driver.FindElements(By.XPath("//input[@type = 'checkbox']"));

            foreach (IWebElement e in RadioButtons)
            {
                // fetches the text of the element
                Console.WriteLine(e.Text);
                // clicks on the  one by one

                Thread.Sleep(1000);
                e.Click();
            }
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
