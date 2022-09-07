using Alice_1_Project.Page;
using Alice_1_Project.Utilities;
using NUnit.Framework;

namespace Alice_1_Project.Tests
{
    [Parallelizable]
    [TestFixture]
     public class Employee_Tests: CommonDriver
    {

        [Test]
        public void CreateEM()
        {
            EmployeePage employeepageObj = new EmployeePage();
            employeepageObj.CreateEM(driver);
        }

        [Test]
        public void EditEM()
        {
            EmployeePage employeepageObj = new EmployeePage();
            employeepageObj.EditEM(driver);
        }

        [Test]
        public void DeleteEM()
        {
            EmployeePage employeepageObj = new EmployeePage();
            employeepageObj.DeleteEM(driver);
        }
    }
}
