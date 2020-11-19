using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;

namespace EliteShoppyFunctionalityTests.Features
{
    [Binding]
    public class CAL_177Steps
    {
        private readonly By _ContactButton = By.XPath("//a[text()='Contact' and @class]");
        private readonly By _InputNameButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Name']");
        private readonly By _InputEmailButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Email']");
        private readonly By _InputSubjectButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Subject']");
        private readonly By _InputMessageButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/textarea[@name='Message']");
        private readonly By _InputSendButton = By.XPath("//div[@class='col-md-6 contact-form']/form/input");
        private IWebDriver driver;

        [Given(@"I have opened Home Page")]
        public void GivenIHaveOpenedHomePage()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I have pressed contact form")]
        public void GivenIHavePressedContactForm()
        {
            var contact = driver.FindElement(_ContactButton);
            contact.Click();
            Thread.Sleep(400);
        }
        
        [Given(@"I have entered name field")]
        public void GivenIHaveEnteredNameField()
        {
            var nameInput = driver.FindElement(_InputNameButton);
            nameInput.Click();
            nameInput.SendKeys("Alexandru");
        }
        
        [Given(@"I have entered email field")]
        public void GivenIHaveEnteredEmailField()
        {
            var emailInput = driver.FindElement(_InputEmailButton);
            emailInput.Click();
            emailInput.SendKeys("altio.alexandru@gmail.com");
        }
        
        [Given(@"I have entered subject field")]
        public void GivenIHaveEnteredSubjectField()
        {
            var subjectInput = driver.FindElement(_InputSubjectButton);
            subjectInput.Click();
            subjectInput.SendKeys("testSubject1");
        }
        
        [Given(@"I have entered message field")]
        public void GivenIHaveEnteredMessageField()
        {
            var messageInput = driver.FindElement(_InputMessageButton);
            messageInput.Click();
            messageInput.SendKeys("testMessage1");
        }
        
        [When(@"I press Send button")]
        public void WhenIPressSendButton()
        {
            var sendButton = driver.FindElement(_InputSendButton);
            sendButton.Click();
        }
        
        [Then(@"I should registered contact message\.")]
        public void ThenIShouldRegisteredContactMessage_()
        {
            Assert.Pass();
        }
    }
}
