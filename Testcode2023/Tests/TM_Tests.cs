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
    [Parallelizable]
    public class TM_Tests : CommonDriver
    
    {
        // Page objects initialization
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();


        [Test, Order(1)]
        
        public void CreateTMTest()

        {

            //TM page object initialization and definition
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);

        }

        [Test, Order(2)]
        public void EditTM()
        {
            //Edit TM
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTM(driver, "description");
        }

        [Test, Order(3)]
        public void DeleteTM()
        {

            //DElete TM
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);
        }
    }
}

