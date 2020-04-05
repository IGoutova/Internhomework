using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.WebElement
{
    class Web
    {
        public string homepage = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
        private IWebDriver driver;

        readonly By inputfield = By.Id("user-message");
        readonly By button = By.CssSelector("#get-input > button");
        readonly By successMessage = By.Id("display");

        public Web(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void enterMessage(string message)
        {
            driver.FindElement(inputfield).Clear();
            driver.FindElement(inputfield).SendKeys(message);
        }

        public void clickButton()
        {
            driver.FindElement(button).Click();
        }
        public bool isSuccessMessageDisplayed()
        {
            return driver.FindElement(successMessage).Displayed;
        }



    }
}
