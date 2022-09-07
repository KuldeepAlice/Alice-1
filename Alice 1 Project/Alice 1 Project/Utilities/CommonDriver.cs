using Alice_1_Project.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alice_1_Project.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;


        [SetUp]
        public void LoginActions()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page initialization and definition
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.loginsteps(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}