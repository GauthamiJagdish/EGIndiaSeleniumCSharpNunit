using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Security.Cryptography.X509Certificates;

namespace NUnitSeleniumC_training.Selenium
{
    [Allure.NUnit.AllureNUnit]

    internal class ParabankAssignment
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.html");//launch my browser
            driver.Manage().Window.Maximize();
        }
        [Test,Order(0)]
        public void testcase1()
        {
            Thread.Sleep(1000);
            IWebElement Register = driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
            Register.Click();
            Thread.Sleep(1000);

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            FirstName.SendKeys("Gauthami");

            IWebElement LastName = driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            LastName.SendKeys("Jagadish");

            IWebElement Address = driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Address.SendKeys("Kulai");

            IWebElement City = driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            City.SendKeys("Mangalore");

            IWebElement State = driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            State.SendKeys("Karnataka");

            IWebElement ZipCode = driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            ZipCode.SendKeys("575014");

            IWebElement Phone = driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            Phone.SendKeys("9876543210");

            IWebElement SSN = driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            SSN.SendKeys("123456");

            IWebElement Username = driver.FindElement(By.XPath("//input[@id='customer.username']"));
            Username.SendKeys("xyz");

            IWebElement Password = driver.FindElement(By.XPath("//input[@id='customer.password']"));
            Password.SendKeys("Gauthzz123");

            IWebElement Confirm = driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            Confirm.SendKeys("Gauthzz123");

            IWebElement ButtonRegister = driver.FindElement(By.XPath("//input[@value='Register']"));
            ButtonRegister.Click();
            Thread.Sleep(3000);

            driver.Navigate().Back();
            driver.Navigate().Back();
        }

        [Test, Order(1)]

        public void testcase2()
        {

            IWebElement LoginUsername = driver.FindElement(By.XPath("//input[@name='username']"));
            LoginUsername.SendKeys("xyz");

            IWebElement LoginPassword = driver.FindElement(By.XPath("//input[@name='password']"));
            LoginPassword.SendKeys("Gauthzz123");
            Thread.Sleep(1000);

            IWebElement ButtonLogin = driver.FindElement(By.XPath("//input[@value='Log In']"));
            ButtonLogin.Click();
            Thread.Sleep(2000);
        }


        [TearDown]
        public void teardownbrowser()
        {
            driver.Close(); //close ur current browser session
        }
    }
}

