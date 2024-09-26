/*using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

public class Wait : Base
{
    [Test]
    public void Login()
    {

        // implicit wait  - which is applied to all the elements declared in the script

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        IWebElement username = driver.FindElement(By.XPath("(//input[@placeholder='Username'])[1]"));

        username.SendKeys("Admin");
        IWebElement password = driver.FindElement(By.Name("password"));
        password.SendKeys("admin123");

        // expliclit wait to wait for a partucular element 
        IWebElement login = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        wait.Until(d => login.Displayed);

        login.Click();

        // custom or fluent wait

        WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
        {
            PollingInterval = TimeSpan.FromMilliseconds(300),
        };
        wait1.IgnoreExceptionTypes(typeof(ElementNotInteractableException));

        wait.Until(d => {
            login.SendKeys("Displayed");
            return true;
        });


    }
}*/