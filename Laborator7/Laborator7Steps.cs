using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Laborator7
{
    [Binding]
    public class Laborator7Steps
    {

        private IWebDriver driver;


        string USERNAME = "mrelectrq1";
        string AUTOMATE_KEY = "p9dtqgAD5fFMz7n9Mpvm";

        [Given(@"Open Googhle Chrome")]
        public void GivenOpenGooghleChrome()
        {
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "80");
            caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "Test2");



           // driver = new ChromeDriver();
             driver = new RemoteWebDriver( new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps);
            driver.Navigate().GoToUrl("https://www.google.md/");
            driver.Manage().Window.Maximize();



        }
        
        [When(@"Give input value")]
        public void WhenGiveInputValue()
        {
            IWebElement element = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            element.Click();
            element.SendKeys("++++++");

        }
        
        [Then(@"I check if results exists")]
        public void ThenICheckIfResultsExists()
        {
            var results = driver.FindElements(By.XPath("//li[@class='sbct']"));


            Assert.True(results[1] == null);
            driver.Quit();

        }
    }
}
