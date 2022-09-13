using Alice_1_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_1_Project.Page
{
    public class HomePage
    {
        

        public void GoToTMPage(IWebDriver driver)
        {
            //Click on Administartion and then click on Time and Materials option
            IWebElement AdministrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropdown.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);
            IWebElement Tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            Tmoption.Click();
            Thread.Sleep(2000);
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            //Navigate to Employee Page
        }
    }
}
