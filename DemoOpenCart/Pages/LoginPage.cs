using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart.Pages
{
    public class LoginPage
    {
        private By _usernameLocator = By.XPath("//input[@placeholder='E-Mail Address']");
        private By _passwordLocator = By.Id("input-password");
        private By _loginLocator = By.XPath("//button[text()='Login']");

        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterUserName(string username)
        {
            driver.FindElement(_usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(_loginLocator).Click();
        }
     
        
    }
}

