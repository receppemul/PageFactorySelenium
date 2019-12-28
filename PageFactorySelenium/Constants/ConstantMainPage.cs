using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageFactoryExample.Constants
{
    static class ConstantMainPage
    {
        public static By POPUP = By.ClassName("fancybox-close");
        public static By LOGINHOVER = By.ClassName("login-register-button-container");
        public static By LOGINBUTTON = By.CssSelector(".login-panel-container .login");
        public static By USERNAME = By.Id("email");
        public static By PASSWORD = By.Id("password");
        public static By POPUPLOGIN=By.ClassName("login-submit");
        public static By SEARCHINPUT = By.Id("AutoCompleteBox");
        public static By SEARCHBUTTUON = By.ClassName("autocomplete-submit-button");
        public static By FILTERGENDER = By.LinkText("Erkek");
        public static By FILTEROS = By.LinkText("Android");
        public static By FILTERDISTRIBUTOR = By.LinkText("Resmi Distribütör Garantili");
        public static By PRODUCT1 = By.CssSelector("span[title='Galaxy Watch Active2 44mm Aluminyum Mat Siyah']");
        public static By PRODUCT2 = By.CssSelector("span[title='Galaxy Watch Active2 44mm Paslanmaz Çelik Siyah']");
        public static By PRODUCT3 = By.CssSelector("span[title='Galaxy Watch Active2 44mm Paslanmaz Çelik Altın']");
        public static By ADDBASKET = By.ClassName("add-to-bs");



    }
}