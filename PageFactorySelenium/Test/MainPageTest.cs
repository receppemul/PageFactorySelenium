using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageFactoryExample.Page;
using System.IO;
using System.Reflection;

namespace PageFactoryExample.Test
{
    class MainPageTest
    {
        static IWebDriver driver;
        LoginPage lp;
        SearchPage sp;
        AddProduct ap;


        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            lp = new LoginPage(driver);
            sp = new SearchPage(driver);
            ap = new AddProduct(driver);
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
        }
        [Test]
        public void AddTest()
        {
            lp.Login("test@gmail.com","test.");
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
