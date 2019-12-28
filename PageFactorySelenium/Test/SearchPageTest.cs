using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageFactoryExample.Page;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace PageFactoryExample.Test
{
    class SearchPageTest
    {
        static IWebDriver driver;
        SearchPage sp;
        

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            sp = new SearchPage(driver);
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
        }
        [Test]
        public void SearchTest()
        {
            sp.Search("samsung");
            sp.Filter();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
