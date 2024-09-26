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
    internal class BrowserCommands
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();


        }

        [Test]
        public void testcase1()
        {

            // launch the chrome browser
            driver.Navigate().GoToUrl("https://www.orangehrm.com/");

            // get the title of the page

            string title = driver.Title;
            Console.WriteLine(title);

            //get the current url

            string currenturl = driver.Url;
            Console.WriteLine(currenturl);

            //fetch the page source of the html page

            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);


        }

        [TearDown]
        public void tearDownbrowser()
        {
            //will close the current browser session(recommended)
            driver.Close();

            // will close all the browser sessions of the browser
            //driver.Quit();
        }
    }
}
