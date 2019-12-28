using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using static PageFactoryExample.Constants.ConstantMainPage;

namespace PageFactoryExample.Page
{
    public class LoginPage : Base.BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void Login(string username, string password)
        {
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            Click(POPUP);
            HoverElement(LOGINHOVER);
            Click(LOGINBUTTON);
           // Thread.Sleep(TimeSpan.FromSeconds(3));
            KeySend(USERNAME, username);
            KeySend(PASSWORD, password);
            Click(POPUPLOGIN);
           // Thread.Sleep(TimeSpan.FromSeconds(5));

        }
    }
}