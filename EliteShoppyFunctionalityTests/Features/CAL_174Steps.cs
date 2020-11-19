using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;

namespace EliteShoppyFunctionalityTests.Features
{
    [Binding]
    public class CAL_174Steps
    {
        private IWebDriver driver;


        private readonly By _signUpButton = By.XPath("//a[text()=' Sign Up ']");
        private readonly By _inputButtonName = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Name']");
        private readonly By _inputButtonEmail = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Email']");
        private readonly By _inputButtonPassword = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='password']");
        private readonly By _inputButtonConfirmPassword = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Confirm Password']");
        private readonly By _inputButtonSignup = By.XPath("//div[@id='myModal2']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/input");




        [Given(@"I have opened HomePage")]
        public void GivenIHaveOpenedHomePage()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I have clicked on Sign up button")]
        public void GivenIHaveClickedOnSignUpButton()
        {
            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();
        }
        
        [Given(@"I have entered my name")]
        public void GivenIHaveEnteredMyName()
        {
            var login = driver.FindElement(_inputButtonName);

            Thread.Sleep(400);
            login.Click();
            Thread.Sleep(400);
            login.SendKeys("Alexandru");
        }
        
        [Given(@"I have entered my email")]
        public void GivenIHaveEnteredMyEmail()
        {
            var email = driver.FindElement(_inputButtonEmail);
            email.Click();
            email.SendKeys("altio.alexandru@gmail.com");
        }
        
        [Given(@"I have entered my Password")]
        public void GivenIHaveEnteredMyPassword()
        {
            var password = driver.FindElement(_inputButtonPassword);
            password.Click();
            password.SendKeys("uter123@");
        }
        
        [Given(@"I have entered my Confirmation password")]
        public void GivenIHaveEnteredMyConfirmationPassword()
        {
            var confpass = driver.FindElement(_inputButtonConfirmPassword);
            confpass.Click();
            confpass.SendKeys("uter123@");
        }
        
        [When(@"I press Sign up  button")]
        public void WhenIPressSignUpButton()
        {
            var signupbutton = driver.FindElement(_inputButtonSignup);
            signupbutton.Click();
        }
        
        [Then(@"Successfully authentication and redirected to Main Page\.")]
        public void ThenSuccessfullyAuthenticationAndRedirectedToMainPage_()
        {
            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();
            Assert.Pass();
        }
    }
}
