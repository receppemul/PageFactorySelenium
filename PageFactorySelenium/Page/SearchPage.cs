using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using static PageFactoryExample.Constants.ConstantMainPage;

namespace PageFactoryExample.Page
{
   public class SearchPage: Base.BasePage
    {
        public SearchPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void Search(String text)
        {
            //Thread.Sleep(TimeSpan.FromSeconds(2));    
            Click(POPUP);
            KeySend(SEARCHINPUT, text);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Click(SEARCHBUTTUON);
            
        }
        public void Filter()
        {
            Click(FILTERGENDER);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Click(FILTEROS);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Click(FILTERDISTRIBUTOR);
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }
    }
}
