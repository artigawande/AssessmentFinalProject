using DemoOpenCart.Base;
using DemoOpenCart.Pages;
using DemoOpenCart.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace DemoOpenCart
{
    public class RegisterTest : AutomationWrapper
    {

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidRegisterData))]
        //[Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ExcelValidData))]

        public void ValidateRegisterTest(string firstName, string lastName, string Email, string password)
        {
            
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Register']")).Click();

            //driver.FindElement(By.XPath("//input[@placeholder= 'First Name']")).SendKeys(firstName);
            //driver.FindElement(By.XPath("//input[@placeholder= 'Last Name']")).SendKeys(lastName);
            //driver.FindElement(By.XPath("//input[@placeholder= 'E-Mail']")).SendKeys(Email);
            //driver.FindElement(By.Id("input-password")).SendKeys(password);

            RegisterPage ValidRegister = new RegisterPage(driver);
            ValidRegister.EnterFirstName(firstName);
            ValidRegister.EnterLastName(lastName);
            ValidRegister.EnterEmail(Email);
            ValidRegister.EnterPassword(password);

            driver.ExecuteJavaScript("document.querySelector('[type=\"checkbox\"]').click();\r\n\r\n");
            driver.ExecuteJavaScript("document.querySelector('[type=\"submit\"]').click();");

            
            
            //Actions act = new Actions(driver);
            //act.MoveToElement(driver.FindElement(By.Name("agree"))).Perform();
            //driver.FindElement(By.Name("agree")).Click();

            // Thread.Sleep(1000);


            
            /*DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            //wait.Timeout= TimeSpan.FromSeconds(5);
            //wait.IgnoreExceptionTypes(typeof(Exception));

            //wait.Until(x=> x.FindElement(By.XPath("//input[@type='checkbox']"))).Click();*/

        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidRegisterData))]
        public void InvalidateRegisterTest(string firstName, string lastName, string Email, string password)
        {

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Register']")).Click();

            //driver.FindElement(By.XPath("//input[@placeholder= 'First Name']")).SendKeys(firstName);
            //driver.FindElement(By.XPath("//input[@placeholder= 'Last Name']")).SendKeys(lastName);
            //driver.FindElement(By.XPath("//input[@placeholder= 'E-Mail']")).SendKeys(Email);
            //driver.FindElement(By.Id("input-password")).SendKeys(password);

            InvalidRegisterPage Invalidregister = new InvalidRegisterPage(driver);
            Invalidregister.EnterFirstName(firstName);
            Invalidregister.EnterLastName(lastName);
            Invalidregister.EnterEmail(Email);
            Invalidregister.EnterPassword(password);

            

            driver.ExecuteJavaScript("document.querySelector('[type=\"checkbox\"]').click();\r\n\r\n");
            driver.ExecuteJavaScript("document.querySelector('[type=\"submit\"]').click();");

            

        }



    }
}