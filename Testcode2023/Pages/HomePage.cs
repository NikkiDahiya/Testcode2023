using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testcode2023.Utilities;

namespace Testcode2023.Pages   
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //Navigate to Time and Material page
            IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropdown.Click();

            Thread.Sleep(5000);
            //Wait.WaitToBeClickable( driver,"Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",10);
            
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();
            Thread.Sleep(2000);


        }
        public void GoToEmployeePage(IWebDriver driver)
        {

        }
    }
}  

