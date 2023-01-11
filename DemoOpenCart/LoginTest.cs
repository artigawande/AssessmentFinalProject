using DemoOpenCart.Base;
using DemoOpenCart.Pages;
using DemoOpenCart.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart
{
    public class LoginTest : AutomationWrapper
    {
        
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData1))]
        public void ValidLoginTest(string username, string password, string LoginTitle, string LoginSubTitle)
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();

            //driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys(username);
            //driver.FindElement(By.Id("input-password")).SendKeys(password);
            //driver.FindElement(By.XPath("//button[text()='Login']")).Click();

            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterUserName(username);
            loginpage.EnterPassword(password);
            loginpage.ClickOnLogin();

            string Loginpage1 = driver.FindElement(By.XPath("//h2[text()='Returning Customer']")).Text;
            Loginpage1.ToUpper();

            Assert.That(Loginpage1, Is.EqualTo(LoginTitle));
            Console.WriteLine(Loginpage1);

            string Loginpage2 = driver.FindElement(By.XPath("//strong[text()='I am a returning customer']")).Text;
            Loginpage1.ToUpper();

            Assert.That(Loginpage2, Is.EqualTo(LoginSubTitle));
            Console.WriteLine(Loginpage2);


        }

        [Test, TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData1))]
        public void InvalidLoginTest(string username, string password)
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();

            //driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys(username);
            //driver.FindElement(By.Id("input-password")).SendKeys(password);
            //driver.FindElement(By.XPath("//button[text()='Login']")).Click();

            InvalidLoginPage invalid = new InvalidLoginPage(driver);
            invalid.EnterUserName(username);
            invalid.EnterPassword(password);
            invalid.ClickOnLogin();

            

        }
    }
}
