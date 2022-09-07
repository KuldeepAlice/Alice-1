using Alice_1_Project.Page;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Alice_1_Project.Utilities;

namespace Alice_1_Project.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
       
        //home page initialization and definition
        HomePage homepageObj = new HomePage();
        TMpage TMpageObj = new TMpage();
        
        [Test, Order(1)]
        public void CreateTMTests()
        {
            //TM page initialization and definition
            homepageObj.GoToTMPage(driver);
            TMpageObj.CreateTM(driver);
        }
        [Test,Order(2)]
        public void EditTMTests()
        {

            //Edit Tm
            homepageObj.GoToTMPage(driver);
            TMpageObj.EditTM(driver);
        }

        [Test, Order(3)]
        public void DeleteTMTests()
        {

            //Delete TM
            homepageObj.GoToTMPage(driver);

            TMpageObj.DeleteTM(driver);
        }
    }
}
