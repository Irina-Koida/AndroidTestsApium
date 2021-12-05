﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class Notifications
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly WithoutRegistering _withoutRegistering;

        public Notifications(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _withoutRegistering = new WithoutRegistering(_driver);
        }

        private readonly By _buttonNotification = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/androidx.appcompat.widget." +
            "LinearLayoutCompat/android.widget.FrameLayout/android.widget.RelativeLayout");
        private readonly By _seeText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.TextView[1]");

        public void TapABell(string button)
        {
            _withoutRegistering.TapATryUsOut(button);
            _withoutRegistering.TapNext(button);
            _withoutRegistering.TapContiueWithoutAccount(button);
            _withoutRegistering.OpenProfilePage();
            _driver.FindElement(_buttonNotification).Click();
        }

        public string InfoText(string info) =>
          _driver.FindElement(_seeText).Text;
    }
}
