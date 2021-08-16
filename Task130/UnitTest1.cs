using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace Task130
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        
        [SetUp]
        public void Setup()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q"));
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}