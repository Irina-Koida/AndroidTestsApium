using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AndroidTestsApium.POM
{
    class StartPageChange
    {

        private readonly AppiumDriver<AndroidElement> _driver;

        public StartPageChange(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        By appStarts = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget." +
            "FrameLayout[2]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[6]/android.widget." +
            "LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout");
        By chooseAppStartsMyProfile = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget." +
            "FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget." +
            "FrameLayout/android.widget.ListView/android.widget.CheckedTextView[5]");
        By backStartpage = By.XPath("//android.widget.ImageButton[@content-desc='Navigate up']");
        By myProfileText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView");

        public StartPageChange ClickAppStartsButton()
        {
            _driver.FindElement(appStarts).Click();
            return this;
        }

        public StartPageChange ChooseMyProfile()
        {
            _driver.FindElement(chooseAppStartsMyProfile).Click();
            return this;
        }

        public StartPageChange ClickBackButton()
        {
            _driver.FindElement(backStartpage).Click();
            return this;
        }

        public StartPageChange ChooseMyProfileText(string text)
        {
            _driver.FindElement(myProfileText).Click();
            return this;
        }

    }
}
