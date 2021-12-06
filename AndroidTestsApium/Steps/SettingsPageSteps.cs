using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class SettingsPageSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private SettingsPage _settingPage;

        public SettingsPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _settingPage = new SettingsPage(_driver);
        }

        [When(@"Find the App start")]
        public void WhenFindTheAppStarts()
        {
            _settingPage.ClickAppStartsButton();
        }

        [When(@"Select page, what you want to see like start page")]
        public void WhenSelectPageWhatYouWantToSeeLikeStartPage()
        {
            _settingPage.ChooseMyProfile();
        }

        [When(@"Tap to the button back")]
        public void WhenTapTheButtonBack()
        {
            _settingPage.ClickBackButton();
        }
        
        [Then(@"The start page '(.*)'")]
        public void ThenTheStartPageChanged(string text)
        {
            Assert.AreEqual(actual: _settingPage.ChooseMyProfileText(text), expected: text);
        }

        [Then(@"Country changed '(.*)'")]
        public void ThenCountryChanged(string text)
        {
            Assert.AreEqual(actual: _settingPage.ChooseCountryState(text), expected: text);
        }

        [When(@"Tap to choose the language")]
        public void WhenTapToChooseTheLanguage()
        {
            _settingPage.ClickSelectLanguageButton();
        }

        [When(@"Select language")]
        public void WhenSelectLanguage()
        {
            _settingPage.ChooseItalianoLanguage();
        }

        [Then(@"Check that the settings are steel '(.*)'")]
        public void ThenCheckThatTheSettingsAreSteel(string text)
        {
            Assert.AreEqual(actual: _settingPage.ChooseTextSettings(text), expected: text);
        }
    }
}
