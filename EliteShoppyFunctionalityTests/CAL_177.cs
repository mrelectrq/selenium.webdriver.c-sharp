using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace EliteShoppyFunctionalityTests
{
    class CAL_177
    {

        private readonly By _ContactButton = By.XPath("//a[text()='Contact' and @class]");
        private readonly By _InputNameButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Name']");
        private readonly By _InputEmailButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Email']");
        private readonly By _InputSubjectButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/input[@name='Subject']");
        private readonly By _InputMessageButton = By.XPath("//div[@class='col-md-6 contact-form']/form/div/textarea[@name='Message']");
        private readonly By _InputSendButton = By.XPath("//div[@class='col-md-6 contact-form']/form/input");
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://loving-hermann-e2094b.netlify.app/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            var contact = driver.FindElement(_ContactButton);
            contact.Click();
            Thread.Sleep(400);
            var nameInput = driver.FindElement(_InputNameButton);
            nameInput.Click();
            nameInput.SendKeys("Alexandru");

            var emailInput = driver.FindElement(_InputEmailButton);
            emailInput.Click();
            emailInput.SendKeys("altio.alexandru@gmail.com");

            var subjectInput = driver.FindElement(_InputSubjectButton);
            subjectInput.Click();
            subjectInput.SendKeys("testSubject1");

            var messageInput = driver.FindElement(_InputMessageButton);
            messageInput.Click();
            messageInput.SendKeys("testMessage1");

            var sendButton = driver.FindElement(_InputSendButton);
            sendButton.Click();

        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

