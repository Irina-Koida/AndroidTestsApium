using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace AndroidTestsApium.Helpers
{
    class HelperSwipe
    {
        public static void Scroll(int fromX, int fromY, int toX, int toY, AppiumDriver<AndroidElement> _driver)//pressX, bottomY, pressX, topY
        {
            TouchAction touchAction = new TouchAction(_driver);
            touchAction.LongPress(fromX, fromY).MoveTo(toX, toY).Release().Perform();
        }
    }
}
