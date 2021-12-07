using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;

namespace AndroidTestsApium.Helpers
{
    class HelperSwipe
    {
        public static void Scroll(int fromX, int fromY, int toX, int toY, AppiumDriver<AndroidElement> _driver)
        {
            TouchAction touchAction = new TouchAction(_driver);
            touchAction.LongPress(fromX, fromY).MoveTo(toX, toY).Release().Perform();
        }

        public static void Waiter(AppiumDriver<AndroidElement> _driver)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
    }
}
