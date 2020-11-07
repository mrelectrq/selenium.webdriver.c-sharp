using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace EliteShoppyFunctionalityTests
{
    class CAL_179
    {
        private IWebDriver driver;

        private readonly By _SocialMediaButton = By.XPath("//div[@class='footer']/div/div/ul/li/a/div/i[@class='fa fa-facebook']");
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
            var link= driver.FindElement(_SocialMediaButton);

            link.Click();
        }
    }
}
