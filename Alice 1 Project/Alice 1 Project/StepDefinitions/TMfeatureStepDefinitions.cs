using Alice_1_Project.Page;
using Alice_1_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Alice_1_Project.StepDefinitions
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.loginsteps(driver);
        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            TMpage TMpageObj = new TMpage();
            TMpageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMpage TMpageObj = new TMpage();
            string newCode = TMpageObj.GetCode(driver); 
            string newDescription = TMpageObj.GetDescription(driver);   
            string newPrice = TMpageObj.GetPrice(driver);


            Assert.That(newCode == "August2022", "Actual code and expected code do not match");
            Assert.That(newDescription == "August2022", "Actual description and expected description do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match");

        }

        [When(@"I update '([^']*)','([^']*)' and '([^']*)' on an exiting time and material record")]
        public void WhenIUpdateAndOnAnExitingTimeAndMaterialRecord(string description, string code, string price)
        {
            TMpage TMpageObj = new TMpage();
            TMpageObj.EditTM(driver, description, code, price);
        }

        [Then(@"The time and material record should have updated '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheTimeAndMaterialRecordShouldHaveUpdatedAnd(string description, string code, string price)
        {
            TMpage TMpageObj = new TMpage();
            string editedDescription = TMpageObj.GetEditedDescription(driver);
            string editedPrice = TMpageObj.GetEditedPrice(driver);
            string editedCode = TMpageObj.GetEditedCode(driver);

            // Assertion
            Assert.That(editedCode == code, "Actual Code and expected code do not match.");
            Assert.That(editedDescription == description, "Actual Description and expected description do not match.");
            Assert.That(editedPrice == price, "Actual Price and expected price do not match.");
        }
    }
}
