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

        private readonly By _buttonNext = By.Id("vivino.web.app:id/next");
        private readonly By _buttonTryUsOut = By.Id("vivino.web.app:id/txtTryUsOut");
        private readonly By _buttonContinueWithoutAccount = By.Id("vivino.web.app:id/continue_without_account");
        private readonly By _openProfile = By.Id("vivino.web.app:id/title");

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
