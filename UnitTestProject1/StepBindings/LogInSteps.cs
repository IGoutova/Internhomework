using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using UnitTestProject1.WebElements;

namespace UnitTestProject1
{
    [Binding]
     public class LoginSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to \.\.\.\. homepage")]
        public void GivenINavigateToWebScrapperHomepage()
        {
            LogInPage logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(logInPage.homepage);

            driver.Manage().Window.Maximize();
        }

        [When(@"I enter ""(.*)"" in the username field")]
        public void WhenIEnterInTheUsernameField(string userName)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.enterUserName(userName);
        }

        [When(@"I enter ""(.*)"" in the password field")]
        public void WhenIEnterInThePasswordField(string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.enterPassword(password);
        }

        [When(@"I click on Log in button")]
        public void WhenIClickOnLogInButton()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.clickLogInButton();
        }
        
        [Then(@"I should see welcome message")]
        public void ThenIShouldSeeWelcomeMessage()
        {
            LogInPage logInPage = new LogInPage(driver);
            Assert.IsTrue(logInPage.isWelcomeMessageDisplayed());

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
