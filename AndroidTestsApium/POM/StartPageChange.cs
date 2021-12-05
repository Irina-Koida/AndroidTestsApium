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

        By getStartedButton = By.Id("vivino.web.app:id/getstarted_layout");

        public StartPageChange ClickGetStartButton()
        {
            _driver.FindElement(getStartedButton).Click();
            return this;
        }

    }
}
