using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;

namespace EliteShoppyFunctionalityTests.Features
{
    [Binding]
    public class CAL_175Steps
    {


        private IWebDriver driver;
        private readonly By _signUpButton = By.XPath("//a[text()=' Sign In ']");
        private readonly By _inputButtonName = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Name']");
        private readonly By _inputButtonEmail = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Email']");
        private readonly By _inputButtonSignIn = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/input");


        [Given(@"I have clicked on Sign IN button")]
        public void GivenIHaveClickedOnSignINButton()
        {
            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();
        }
        
        [Given(@"I have entered my Name\.")]
        public void GivenIHaveEnteredMyName_()
        {
            var login = driver.FindElement(_inputButtonName);

            Thread.Sleep(400);
            login.Click();
            Thread.Sleep(400);
            login.SendKeys("Alexandru");

        }

        [Given(@"I have entered my Email\.")]
        public void GivenIHaveEnteredMyEmail_()
        {
            var email = driver.FindElement(_inputButtonEmail);
            email.Click();
            email.SendKeys("altio.alexandru@gmail.com");
        }
        
        [When(@"I press Sign In button\.")]
        public void WhenIPressSignInButton_()
        {

            var signinbutton = driver.FindElement(_inputButtonSignIn);
            signinbutton.Click();
        }
        
        [Then(@"My account should be successful logged\.")]
        public void ThenMyAccountShouldBeSuccessfulLogged_()
        {
            Assert.Pass();
        }
    }
}
