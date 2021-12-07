using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AndroidTestsApium.POM
{
    class DarkTheme
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public DarkTheme(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        By burgerMenu = By.XPath("//android.widget.ImageView[@content-desc='More options']");
        By settings = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget." +
            "ListView/android.widget.LinearLayout[1]/android.widget.LinearLayout");
        By darkMode = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout/android." +
            "widget.LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget." +
            "LinearLayout[8]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout");
        By selectDarkMode = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget." +
            "FrameLayout/android.widget.ListView/android.widget.CheckedTextView[2]");
        By assertDarkMode = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget." +
            "LinearLayout[3]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.TextView[2]");
       
        public DarkTheme ClickButtonBurgerMenu()
        {
            _driver.FindElement(burgerMenu).Click();
            return this;
        }

        public DarkTheme ClickButtonSettings()
        {
            _driver.FindElement(settings).Click();
            return this;
        }

        public DarkTheme ClickButtonDarkMode()
        {
           // MoveTo()HelperSwipe.
            _driver.FindElement(darkMode).Click();sdsv ghghghd
            return this;
        }

        public DarkTheme ClickParametrDarkMode()
        {
            _driver.FindElement(selectDarkMode).Click();
            return this;
        }

        public DarkTheme AssertDarkMode(string dark)
        {
            _driver.FindElement(assertDarkMode).Click();
            return this;
        }
    }
}
