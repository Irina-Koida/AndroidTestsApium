using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace AndroidTestsApium.POM
{
    class WithoutRegistering
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Actions _action;

        public WithoutRegistering(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _action = new Actions(_driver);
        }

        private readonly By _buttonNext = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget" +
            ".LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.RelativeLayout/androidx.viewpager.widget.ViewPager/android.widget." +
            "LinearLayout/android.widget.LinearLayout/android.widget.TextView[2]");
        private readonly By _buttonTryUsOut = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget" +
            ".LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android." +
            "widget.FrameLayout/android.view.ViewGroup/android.widget.Button[3]");
        private readonly By _buttonContinueWithoutAccount = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.RelativeLayout/" +
            "androidx.viewpager.widget.ViewPager/android.widget.LinearLayout/android.widget.LinearLayout/" +
            "android.widget.Button[2]");
        private readonly By _openProfile = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.view." +
            "ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android." +
            "view.ViewGroup/android.widget.TextView[2]");

        public void TapATryUsOut(string tryUsOut) =>
          _action.MoveToElement(_driver.FindElement(_buttonTryUsOut)).Click().Perform();

        public void TapNext(string next) =>
         _action.MoveToElement(_driver.FindElement(_buttonNext)).Click().Perform();

        public void TapContiueWithoutAccount(string contiueWithoutAccount) =>
        _action.MoveToElement(_driver.FindElement(_buttonContinueWithoutAccount)).Click().Perform();

        public string OpenProfilePage() =>
            _driver.FindElement(_openProfile).Text;
    }
}
