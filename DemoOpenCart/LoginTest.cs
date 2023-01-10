using DemoOpenCart.Base;
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
        public void ValidLoginTest(string username, string password)
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys(username);
            driver.FindElement(By.Id("input-password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();

        }

        [Test, TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData1))]
        public void InvalidLoginTest(string username, string password)
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys(username);
            driver.FindElement(By.Id("input-password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();

        }
    }
}
