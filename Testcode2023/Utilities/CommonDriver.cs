using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Testcode2023.Pages;

namespace Testcode2023.Utilities // Correct code
{
    public class CommonDriver
    {
        public  IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
