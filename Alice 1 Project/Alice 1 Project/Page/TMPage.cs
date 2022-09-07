using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_1_Project.Page
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //Click on Create New
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNewButton.Click();
            Thread.Sleep(2000);

            //Select Time Option from Typecode Dropdown
            IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/label"));
            TypecodeDropdown.Click();
            IWebElement TimeOption = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[1]"));
            TimeOption.Click();
            Thread.Sleep(2000);

            //Input Code
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("August2022");
            Thread.Sleep(2000);

            //Input Description
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("August2022");
            Thread.Sleep(2000);

            //Input PricePerUnit
            IWebElement PriceInputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceInputTag.Click();
            IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
            PriceTextbox.SendKeys("12");
            Thread.Sleep(2000);

            //Click on Save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(3000);


        }
        public void EditTM(IWebDriver driver)
        {
            //Create EDit TM page

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "August2022")
            {
                // Click on the Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited.");
            }
            // Click on "Code" from Textbox and set the code
            IWebElement EditcodeTextBox = driver.FindElement(By.Id("Code"));
            EditcodeTextBox.Clear();
            EditcodeTextBox.SendKeys("Edited");


            // Click on "Description" from Textbox and set the description
            IWebElement EditdescriptionTextBox = driver.FindElement(By.Id("Description"));
            EditdescriptionTextBox.Clear();
            EditdescriptionTextBox.SendKeys("Edited");


            // Click on "Price per unit" textbox and clear the price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            priceTag.Click();


            IWebElement EditpricePerUnit= driver.FindElement(By.Id("Price"));
            EditpricePerUnit.Clear();


            priceTag.Click();


            // IWebElement pricePerUnit2 = testDriver.FindElement(By.Id("Price"));
            EditpricePerUnit.SendKeys("150.00");
            Thread.Sleep(2000);

            // Click on "Save" button
            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(3000);

        }
        public  void DeleteTM(IWebDriver driver)
        {

            // Assert that Time record has been edited.
            //GoToLastPage where Edited Record Created
            IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPageButton.Click();

            //Click On the delete button

            // Click on the Delete Button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();

        }
    }
}
