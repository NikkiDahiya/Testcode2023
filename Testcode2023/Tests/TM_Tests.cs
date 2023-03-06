using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testcode2023.Pages;
using Testcode2023.Utilities;

namespace Testcode2023.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    
    {
        [SetUp]
        public void LoginSteps()
        {

            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginAction(driver);

            //Home page object initialization and definition
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }

        [Test, Order(1)]
        public void CreateTMTest()

        {

            //TM page object initialization and definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);

        }

        [Test, Order(2)]
        public void EditTMTest()
        {
            //Edit TM
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTM(driver);
        }

        [Test, Order(3)]
        public void DeleteTMTest()
        {

            //DElete TM
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}

