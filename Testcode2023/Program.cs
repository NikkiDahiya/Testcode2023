
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open webrowser

IWebDriver driver = new ChromeDriver();

driver.Manage().Window.Maximize();

// lunch Turmp up portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);


//Indetify the user text box and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// Indentify the the password test box and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Indentify the log in button and click on checkon it
IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoginButton.Click();
Thread.Sleep(5000);

//Check if the user is successfully login
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (hellohari.Text == "hellohari!")
{
    Console.WriteLine("loggedin successful");

}
else
    Console.WriteLine("Failed login");

// Navigate to time and material page
IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
adminstrationDropdown.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
tmOption.Click();
Thread.Sleep(1000);

//click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();
Thread.Sleep(1000);

//Select Time option from the Typecode droupdown list
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typeCodeDropdown.Click();
Thread.Sleep(1000);
IWebElement timeOption = driver.FindElement(By.Id("TypeCode_option_selected"));
timeOption.Click();

//Input code into Code  textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Testcode2023");
Thread.Sleep(1000);

//Input description into Description textbox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("Testcode2023");
Thread.Sleep(1000);

//Input Price per unit into price per unit textbox
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("240");
Thread.Sleep(1000);

//Click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click(); 
Thread.Sleep(3000);

//Check if the new record has been created
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();
Thread.Sleep(5000);

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[10]/td[1]"));
if(newCode.Text == "Testcode2023")
{
    Console.WriteLine("New time record created successfully");

}
else
{
    Console.WriteLine("New recond has not been created");
}



