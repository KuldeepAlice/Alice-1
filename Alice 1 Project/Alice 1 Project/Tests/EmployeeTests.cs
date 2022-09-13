using Alice_1_Project.Page;
using Alice_1_Project.Utilities;
using NUnit.Framework;
using System.ComponentModel;

namespace Alice_1_Project.Tests
{
    [Parallelizable]
    [TestFixture]
     public class EmployeeTests: CommonDriver
    {
        HomePage homepageObj = new HomePage();
        EmployeePage employeepageObj = new EmployeePage();
     

        [Test]
     
        public void CreateEM()
        {
            Thread.Sleep(2000);
            homepageObj.GoToEmployeePage(driver);
            employeepageObj.CreateEM(driver);
        }

        [Test]
        public void EditEM()
        {
            homepageObj.GoToEmployeePage(driver);
            employeepageObj.EditEM(driver);
        }

        [Test]
        public void DeleteEM()
        {
            homepageObj.GoToEmployeePage(driver);
            employeepageObj.DeleteEM(driver);
        }
    }
}
