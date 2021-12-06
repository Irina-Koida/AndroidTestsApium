using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AndroidTestsApium.POM
{
    class LogInPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public LogInPage(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        By clickIHaveAAccount = By.Id("vivino.web.app:id/txthaveaccount");
        By emailField = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "ScrollView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget." +
            "LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[1]");
        By passwordField = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "ScrollView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget." +
            "LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[2]");
        By logInButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget" +
            ".LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.view.ViewGroup/androidx.appcompat.widget." +
            "LinearLayoutCompat/android.widget.TextView");
        By notSavePassword = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "LinearLayout/android.widget.LinearLayout[2]/android.widget.Button[1]");
        By forYoutext = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView");

        public LogInPage ClickHaveAccountButton()
        {
            _driver.FindElement(clickIHaveAAccount).Click();
            return this;
        }

        public LogInPage InputEmailField(string text)
        {
            _driver.FindElement(emailField).Click();
            _driver.FindElement(emailField).SendKeys("gogi1234@gmail.com");
            return this;
        }

        public LogInPage InputPasswordField(string text)
        {
            _driver.FindElement(passwordField).Click();
            _driver.FindElement(passwordField).SendKeys("gogi1234))");
            return this;
        }

        public LogInPage ClickLogInButton()
        {
            _driver.FindElement(logInButton).Click();
            return this;
        }

        public LogInPage ClosedSavePassword()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(notSavePassword).Click();
            return this;
        }

        public LogInPage ChooseForYouTitle(string text)
        {
            _driver.FindElement(forYoutext).Click();
            return this;
        }
    }
}
