using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_1_Project.Page
{
    public class Loginpage
    {
        public void loginsteps(IWebDriver driver)
        {

            // Launch Turnup Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);

            // Identify Username Textbox and enter username
            IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
            UsernameTextbox.SendKeys("hari");
            Thread.Sleep(2000);

            // Identify Password textbox and enter password
            IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
            PasswordTextbox.SendKeys("123123");
            Thread.Sleep(2000);

            // Identify Login Button and click on it
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
