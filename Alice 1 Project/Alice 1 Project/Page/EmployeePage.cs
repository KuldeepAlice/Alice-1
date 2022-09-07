using NUnit.Framework;
using OpenQA.Selenium;

namespace Alice_1_Project.Page
{
    public class EmployeePage
    {
        public void CreateEM(IWebDriver driver)
        {
            //Create New Employee
            IWebElement CreateButton = driver.FindElement(By.XPath("/html/body/div[4]/p/a"));
            CreateButton.Click();
            Thread.Sleep(1600);

            //Enter Employee Name
            IWebElement EmployeeName = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[1]/label"));
            EmployeeName.SendKeys("Alice");

            //Enter Username
            IWebElement EmployeeUsername = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[2]/label"));
            EmployeeUsername.SendKeys("Alice234");

            //Click on save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
        }
        public void EditEM(IWebDriver driver)
        {
            //Gotolastpagebutton and find record created
            IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            GoToLastPageButton.Click();

            IWebElement FindCreatedRecord = driver.FindElement(By.XPath(""));
            if (FindCreatedRecord.Text == "Alice") 
            {
                //Click on edit Button
                IWebElement EditButton = driver.FindElement(By.XPath(""));
                EditButton.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record not Created");
            }

                //Edit Record
                IWebElement EditEmployeeName = driver.FindElement(By.XPath(""));
                EditEmployeeName.Clear();
                EditEmployeeName.SendKeys("Alice1");

                //Edit Username
                IWebElement EditEmployeeUsername = driver.FindElement(By.XPath(""));
                EditEmployeeUsername.Clear();
                EditEmployeeUsername.SendKeys("Alice567");

                //Click on save button
                IWebElement EditSaveButton = driver.FindElement(By.XPath(""));
                EditSaveButton.Click();

            
        }
        public void DeleteEM(IWebDriver driver)
        {
                //GoToLastPage where Edited Record Created
                IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                GoToLastPageButton.Click();
                //Click on Delete Button
                IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[Last()]/td[3]/a[2]"));
                DeleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();

        }
    }
}
