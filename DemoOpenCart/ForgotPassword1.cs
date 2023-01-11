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
    public class ForgotPassword1 : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ForgotTestData))]

        public void ForgotPasswordTest(string email)
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();

            //driver.FindElement(By.XPath("//a[text()='Forgotten Password']")).Click();
            //driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys(email);

            // driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            ForgotPasswordPage forgot = new ForgotPasswordPage(driver);
            forgot.ClickOnForgotPassword();
            forgot.EnterEmailAddress(email);
            forgot.ClickONContinue();


        }
    }
}
