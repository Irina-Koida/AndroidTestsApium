using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndroidTestsApium.POM
{
    public class Page
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public Page(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }
        By loginBtn = By.XPath("//android.widget.FrameLayout[@content-desc=\"getstarted_layout\"]");
        By loginBыtn = By.Id("//getstarted_layout");//android.widget.FrameLayout/android.view.ViewGroup/android.widget.Button[1]

        public Page Login()
        {
            Thread.Sleep(5000);
            //loginButton.SendKeys("Di");
            _driver.FindElement(loginBtn).Click();
            return this;
        }

        [FindsBy(How = How.Id, Using = "getstarted_layout")] // Вход в аккаунт
        private AndroidElement searchText;

        [FindsBy(How = How.Id, Using = "til_email")] // Вход в аккаунт
        private AndroidElement email;

        public Page Search()
        {
            searchText.Click();
            return this;
        }

        public Page Email(string text)
        {
            email.SendKeys(text);
            return this;
        }
    }
}
