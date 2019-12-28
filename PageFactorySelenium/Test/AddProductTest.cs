using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageFactoryExample.Page;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace PageFactoryExample.Test
{
    class AddProductTest
    {
        static IWebDriver driver;
        SearchPage sp;
        AddProduct ap;


        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            sp = new SearchPage(driver);
            ap = new AddProduct(driver);
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
        }
        [Test]
        public void AddTest()
        {
            sp.Search("samsung");
            sp.Filter();
            ap.Add();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
