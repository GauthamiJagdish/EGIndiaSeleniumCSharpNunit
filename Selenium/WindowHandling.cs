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
    internal class WindowHandling
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

            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            // fetch the handle of the parent page

            string currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            // click on the link to open the new window

            IWebElement Open = driver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            Open.Click();

            // fetch the window handles of all windows there will be two windows opened

            IList<string> windowHandles = new List<string>(driver.WindowHandles);

            // the control is moved to child window

            driver.SwitchTo().Window(windowHandles[1]);

            string title = driver.Title;

            Console.WriteLine(title);

            Assert.AreEqual("Simple Page", title);

            // closing of the child window

            driver.Close();

            Thread.Sleep(3000);

            driver.SwitchTo().Window(windowHandles[0]);


            string title1 = driver.Title;

            Console.WriteLine(title1);

            Assert.AreEqual("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow", title1);




        }

        [TearDown]
        public void tearDownbrowser()
        {

             driver.Close();

        }
    }
}



