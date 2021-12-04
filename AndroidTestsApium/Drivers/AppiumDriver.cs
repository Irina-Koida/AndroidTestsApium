using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace AndroidTestsApium.Drivers
{
    class AppiumDriver
    {
        private AppiumDriver<AndroidElement> _driver;
        public AppiumDriver<AndroidElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();

            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android SDK");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "Appium");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\Kostiantin\\Desktop\\TestsAPK\\vivino.web.app_8.20.10_8201099.apk");
            driverOptions.AddAdditionalCapability("appWaitActivity", "com.vivino.activities.OOTB");

            var appiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1")
                .UsingAnyFreePort().Build(); //запускаем сервер

            if (!appiumService.IsRunning)
            {
                appiumService.Start();
            }

            _driver = new AndroidDriver<AndroidElement>(appiumService, driverOptions, TimeSpan.FromSeconds(100));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
    }
}
