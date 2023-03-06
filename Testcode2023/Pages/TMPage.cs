using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testcode2023.Utilities;

namespace Testcode2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 5);

            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(1000);

            //Select Time option from the Typecode droupdown list
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //Input code into Code  textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Testcode2023");
            Thread.Sleep(2000);

            //Input description into Description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Soni");
            Thread.Sleep(1000);

            //Input Price per unit into price per unit textbox
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("340");
            Thread.Sleep(1000);

            //Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);



            //Check if the new record has been created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            

            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            


            Assert.That(newCode.Text == "Testcode2023", "Actual code and expected code do not match");
            Assert.That(newDescription.Text == "Soni", "Actual description and expected description do not match");

            // if (newCode.Text == "Testcode2023")
            // {
            Assert.Pass("New time record created successfully");

            //  }
            // else
            // {
            //   Assert.Fail("New recond has not been created");

            // }
        }

        public void EditTM(IWebDriver driver)
        {
            // Click on Edit Button to make changes to type Code
            Thread.Sleep(1000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement recordToBeEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));



            if (recordToBeEdited.Text == "Testcode2023")
            {

                IWebElement LastRecordEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                LastRecordEdit.Click();
            }
            else
            {
                Assert.Fail("Record to be edited not found.");
            }


            //Identify Code Text Box and clear last record
            driver.FindElement(By.XPath("//*[@id=\"Code\"]")).Clear();


            //Identify Code Text Box and Write New Record
            IWebElement CodeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            CodeTextBox.SendKeys("ND");


            //Identify and Click on Save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();


            //Identify and Click on Last Page Button Page
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            Thread.Sleep(1000);
            IWebElement lastEditedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(lastEditedRecord.Text == "ND", "Record hasn't been edited.");

        }

        public void DeleteTM(IWebDriver driver)
        {
            //Identify and Click on Last Page Button Page
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            IWebElement recordToBeDeleted = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (recordToBeDeleted.Text == "ND")
            {
                //Find and click on delete button for last record 
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
                deleteButton.Click();
            }
            else
            {
                Assert.Fail("Record to be deleted not found.");
            }

            IWebElement lastRecordDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            lastRecordDelete.Click();
            Thread.Sleep(2000);

            //Acceptance on Pop up to delete record
            driver.SwitchTo().Alert().Accept();

            Assert.That(lastRecordDelete.Text != "ND", "Record hasn't been deleted");
        }
    }
}







