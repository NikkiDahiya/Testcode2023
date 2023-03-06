using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testcode2023.Pages
{
    public class LoginPage
    {
            public void LoginAction(IWebDriver driver)
            {
                //Open Chrome browser

                driver.Manage().Window.Maximize();

                // Launch turnup portal
                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
                Thread.Sleep(1000);

              try
              {
                //Identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
              }
              catch(Exception ex)
              {
                Assert.Fail("TurnUp portal home page did not launch", ex.Message);
              }

                //Identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                //identify login button and click on it
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
                loginButton.Click();
                Thread.Sleep(1500);


            }
        
    }  
 }
