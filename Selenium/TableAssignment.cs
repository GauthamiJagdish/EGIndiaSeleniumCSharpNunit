using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class TableAssignment
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

            // xpath of the html web table

            IWebElement table = driver.FindElement(By.XPath("(//table[@id = 'product'])[1]"));

            // fetch the all rows of the table

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("(//table[@id = 'product'])[1]/tbody/tr[8]")));

            //int rowcount = trrow.Count();

            //Console.WriteLine(rowcount);

            // fecth the no of columns

            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("(//table[@id = 'product'])[1]/tbody/tr[8]/td")));

            //int colcount = tdcol.Count();

            //Console.WriteLine(colcount);

            // cell data

            IWebElement celldata = driver.FindElement(By.XPath("(//table[@id = 'product'])[1]/tbody/tr[8]/td[2]"));

            string text = celldata.Text;

            Console.WriteLine(text);

            Assert.AreEqual("QA Expert Course :Software Testing + Bugzilla + SQL + Agile", text);
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
