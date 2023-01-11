using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart.Pages
{
    public class ForgotPasswordPage
    {

        private By _ForgotLocator = By.XPath("//a[text()='Forgotten Password']");
        private By _emailLocator = By.XPath("//input[@placeholder='E-Mail Address']");
        private By _continueLocator = By.XPath("//button[@type='submit']");


        private IWebDriver driver;
        public ForgotPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnForgotPassword()
        {
            driver.FindElement(_ForgotLocator).Click();
        }

        public void EnterEmailAddress(string email)
        {
            driver.FindElement(_emailLocator).SendKeys(email);
        }

        public void ClickONContinue()
        {
            driver.FindElement(_continueLocator).Click();
        }
    }
}
