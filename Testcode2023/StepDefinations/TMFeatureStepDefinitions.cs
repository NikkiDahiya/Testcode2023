using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Testcode2023.Pages;
using Testcode2023.Utilities;

namespace Testcode2023.StepDefinations
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homepPageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            // Login page object initialization and definition
            loginPageObj.LoginAction(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homepPageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tmPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "Testcode2023", "Actual code and expected code do not match.");
            Assert.That(newDescription == "Soni", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$340.00", "Actual price and expected price do not match.");

        }

        [When(@"I update '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description)
        {
            tmPageObj.EditTM(driver, description);
        }

        [Then(@"The record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description)
        {
            throw new PendingStepException();
        }
    }
}
