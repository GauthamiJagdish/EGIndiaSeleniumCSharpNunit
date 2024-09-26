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
    internal class Login
    {
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.orangehrm.com/");
            
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            //find the element using By class locator
            IWebElement Username = driver.FindElement(By.Name("username"));
            //inputting text using send keys
            Username.SendKeys("Admin");


            //find the element using By class locator
            IWebElement Password = driver.FindElement(By.Name("password"));
            //inputting text using send keys
            Password.SendKeys("admin123");

            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}

