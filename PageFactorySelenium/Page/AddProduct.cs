using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static PageFactoryExample.Constants.ConstantMainPage;
namespace PageFactoryExample.Page
{
    public class AddProduct : Base.BasePage

    {
        public AddProduct(IWebDriver webdriver) : base(webdriver)
        {

        }
        public void Add()
        {
            Click(PRODUCT1);
            Click(ADDBASKET);
            Back();
            Click(PRODUCT2);
            Click(ADDBASKET);
            Back();
            Click(PRODUCT3);
            Click(ADDBASKET);

            Thread.Sleep(TimeSpan.FromSeconds(10));

        }
    }
}
