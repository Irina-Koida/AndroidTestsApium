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

        By appStarts = By.Id("");

        public StartPageChange ClickAppStartsButton()
        {
            _driver.FindElement(appStarts).Click();
            return this;
        }

    }
}
