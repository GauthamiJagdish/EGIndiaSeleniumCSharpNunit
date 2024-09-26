using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class Frames
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

            driver.Navigate().GoToUrl("https://");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            //select the frame using xpath of the frame
            driver.SwitchTo().Frame(Frame1);

            //select the frame using index
            driver.SwitchTo().Frame(1);

            //select the frame using ID or name
            driver.SwitchTo().Frame("Frameone");


            //click the radio button new york
            IWebElement radioButton = driver.FindElement(By.XPath("//span[@class='ui-checkboxradio-icons']"));
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
   
