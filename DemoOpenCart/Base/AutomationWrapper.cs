using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart.Base
{
    public class AutomationWrapper
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {
            
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://demo.opencart.com/";
        }

        [TearDown]

        public void AfterMethod()
        {
            //browser close
           // driver.Quit();

        }
    }
}
