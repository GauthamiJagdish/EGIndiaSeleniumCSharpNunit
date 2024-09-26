using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumC_training.Selenium
{
    internal class FacebookAssignment
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

            driver.Navigate().GoToUrl("https://www.facebook.com/login.php/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            IWebElement emailField = driver.FindElement(By.Id("email"));

            // Convert the email to uppercase and send it to the email field
            string email = "abc@example.com";
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys(email)
                .Perform();
            Thread.Sleep(2000);
            
            //emailField.SendKeys(email.ToUpper());




            // Find the login button and click it
            IWebElement loginButton = driver.FindElement(By.Name("login"));
            loginButton.Click();
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
    
