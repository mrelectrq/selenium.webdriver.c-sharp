using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteShoppyFunctionalityTests
{
    class Lab5
    {
        private IWebDriver driver;

        private readonly By _searchInput = By.XPath("//input[@id='js-search-input']");
        private readonly By _searchButton = By.XPath("//span[text()='Caută']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://999.md/ro/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var link = driver.FindElement(_searchInput);

            link.Click();
            link.SendKeys("computer");

            var search_btn = driver.FindElement(_searchButton);
            search_btn.Click();
        }
    }
}
