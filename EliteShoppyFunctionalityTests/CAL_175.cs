﻿using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;



namespace EliteShoppyFunctionalityTests
{
    class CAL_175
    {
        private IWebDriver driver;
        private readonly By _signUpButton = By.XPath("//a[text()=' Sign In ']");
        private readonly By _inputButtonName = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Name']");
        private readonly By _inputButtonEmail = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/div/input[@name='Email']");
        private readonly By _inputButtonSignIn = By.XPath("//div[@id='myModal']/div/div/div[@class='modal-body modal-body-sub_agile']/div/form/input");

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

            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();
            var login = driver.FindElement(_inputButtonName);

            Thread.Sleep(400);
            login.Click();
            Thread.Sleep(400);
            login.SendKeys("Alexandru");

            var email = driver.FindElement(_inputButtonEmail);
            var signinbutton = driver.FindElement(_inputButtonSignIn);
            email.Click();
            email.SendKeys("altio.alexandru@gmail.com");
            signinbutton.Click();



        }
    }
}
