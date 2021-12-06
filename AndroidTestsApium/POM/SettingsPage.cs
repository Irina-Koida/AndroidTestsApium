using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AndroidTestsApium.POM
{
    class SettingsPage
    {

        private readonly AppiumDriver<AndroidElement> _driver;

        public SettingsPage(AppiumDriver<AndroidElement> appiumDriver)
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
        By chooseSelectCountry = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget." +
            "FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget." +
            "FrameLayout/android.widget.ListView/android.widget.CheckedTextView[11]");
        By selectLanguage = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget." +
            "FrameLayout[2]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget." +
            "LinearLayout[6]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout");
        By chooseItalianoLanguage = By.XPath("/hierarchy/android.widget." +
            "FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget." +
            "FrameLayout/android.widget.ListView/android.widget.CheckedTextView[4]");
        By chooseTextSettings = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget." +
            "FrameLayout[1]/android.view.ViewGroup/android.widget.TextView");

        public SettingsPage ClickAppStartsButton()
        {
            _driver.FindElement(appStarts).Click();
            return this;
        }

        public SettingsPage ChooseMyProfile()
        {
            _driver.FindElement(chooseAppStartsMyProfile).Click();
            return this;
        }

        public SettingsPage ClickBackButton()
        {
            _driver.FindElement(backStartpage).Click();
            return this;
        }

        public SettingsPage ChooseMyProfileText(string text)
        {
            _driver.FindElement(myProfileText).Click();
            return this;
        }

        public SettingsPage ChooseCountryState(string text)
        {
            _driver.FindElement(chooseSelectCountry).Click();
            return this;
        }

        public SettingsPage ClickSelectLanguageButton()
        {
            _driver.FindElement(selectLanguage).Click();
            return this;
        }

        public SettingsPage ChooseItalianoLanguage()
        {
            _driver.FindElement(chooseItalianoLanguage).Click();
            return this;
        }

        public SettingsPage ChooseTextSettings(string text)
        {
            _driver.FindElement(chooseTextSettings).Click();
            return this;
        }
    }
}
