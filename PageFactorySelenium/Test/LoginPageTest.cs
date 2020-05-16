using OpenQA.Selenium;
using PageFactoryExample.Page;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.IO;
using System.Reflection;


namespace PageFactoryExample.Test
{
    class LoginPageTest
    {
        static IWebDriver driver;
        LoginPage lgp;

        [SetUp]
        public void SetUp()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            lgp = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
        }
        [Test]
        public void LoginTest()
        {
            lgp.Login("deneme123@gmail.com", "deneme123");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
