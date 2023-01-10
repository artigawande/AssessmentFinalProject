using DemoOpenCart.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart
{
    public class ForgotPassword1 : AutomationWrapper
    {
        [Test]

        public void ForgotPasswordTest()
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();

            driver.FindElement(By.XPath("//a[text()='Forgotten Password']")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys("aarya@123.com");

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();


        }
    }
}
