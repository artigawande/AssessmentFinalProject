using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart.Pages
{
    public class InvalidRegisterPage
    {
        private By _firstnameLocator = By.XPath("//input[@placeholder= 'First Name']");
        private By _lastLocator = By.XPath("//input[@placeholder= 'Last Name']");
        private By _emailLocator = By.XPath("//input[@placeholder= 'E-Mail']");
        private By _passwordLocator = By.Id("input-password");




        private IWebDriver driver;
        public InvalidRegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(_firstnameLocator).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            driver.FindElement(_lastLocator).SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(_emailLocator).SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }


    }
}
