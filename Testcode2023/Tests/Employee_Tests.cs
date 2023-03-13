using NUnit.Framework;
using OpenQA.Selenium.Chrome;
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
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        [SetUp]
        public void loginSteps()
        {

            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginAction(driver);

            //Home page object initialization and definition
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToEmployeePage(driver);

        }

           [Test, Order(1)]
           public void CreateEmployeeTest()
            {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
            }
           [Test, Order(2)]
           public void EditEmployeeTest()
           {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
           }
           [Test, Order(3)]
           public void DeleteEmployeeTest()
           {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
           }
           [TearDown]
           public void closingsteps()
           {
            driver.Quit();
           }

           
           
           
    } 

}
