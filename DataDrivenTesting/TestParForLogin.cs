/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.DataDrivenTesting
{
    internal class TestParForLogin
    {
        public IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }


        [Test]
        [TestCase("abc.com", "ghhjj")]
        [TestCase("ghh.com", "fghhj")]
        [TestCase("mkk.com", "ddffg")]
        public void LoginTest(string username, string password)
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    IWebElement usernameField = driver.FindElement(By.XPath("//input[@name='username']"));
                    IWebElement passwordField = driver.FindElement(By.XPath("//input[placeholder='Password']"));
                    IWebElement loginButton = driver.FindElement(By.XPath("button[type='submit']"));

                    usernameField.Clear();
                    usernameField.SendKeys(username);
                    passwordField.Clear();
                    passwordField.SendKeys(password);
                    loginButton.Click();

                    Console.WriteLine($"Attempt {i + 1}: {username} : {password}");
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine("Element not found: " + e.Message);
                }
            }
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}*/
