using DemoOpenCart.Base;
using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart
{
    public class LoginUITest : AutomationWrapper
    {
        [Test]
        public void ValidateTitleTest()
        {

            string actualtitle = driver.Title;
            Assert.That(actualtitle, Is.EqualTo("Your Store"));
        }

        [Test]
        public void ValidateURLTest()
        {
            string actualURL = driver.Url;

            Assert.That(actualURL, Is.EqualTo("https://demo.opencart.com/"));

        }

        [Test]
        public void ValidatePlaceholderTest()
        {
            string actualfirstnamePlaceholder = driver.FindElement(By.XPath("//input[@placeholder= 'First Name']")).GetAttribute("placeholder");
            string actuallastnamePlaceholder = driver.FindElement(By.XPath("//input[@placeholder= 'Last Name']")).GetAttribute("placeholder");

            string actualemailPlaceholder = driver.FindElement(By.XPath("//input[@placeholder= 'E-Mail']")).GetAttribute("placeholder");
            string actualpasswordPlaceholder = driver.FindElement(By.XPath("//input[@placeholder= 'Password']")).GetAttribute("placeholder");

            Assert.That(actualfirstnamePlaceholder, Is.EqualTo("First Name"));
            Assert.That(actuallastnamePlaceholder, Is.EqualTo("Last Name"));
            Assert.That(actualemailPlaceholder, Is.EqualTo("E-Mail"));
            Assert.That(actualpasswordPlaceholder, Is.EqualTo("Password"));
        }
    }
}
