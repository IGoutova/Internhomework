using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Homework.WebElement;

namespace Homework
{
    [Binding]
    public class InputField : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to seleniumeasy website")]
        public void GivenINavigateToSeleniumeasyWebsite()
        {
            Web web = new Web(driver);
            driver.Navigate().GoToUrl(web.homepage);

            driver.Manage().Window.Maximize();
        }
        
        [When(@"I enter '(.*)' in input text field")]
        public void WhenIEnterInInputTextField(string message)
        {
            Web web = new Web(driver);
            web.enterMessage(message);
        }
        
        [When(@"I click Show message button")]
        public void WhenIClickShowMessageButton()
        {
            Web web = new Web(driver);
            web.clickButton();
        }
        
        [Then(@"I should see successful message ""(.*)""")]
        public void ThenIShouldSeeSuccessfulMessage(string message)
        {
            Web web = new Web(driver);
            Assert.IsTrue(web.isSuccessMessageDisplayed());
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
