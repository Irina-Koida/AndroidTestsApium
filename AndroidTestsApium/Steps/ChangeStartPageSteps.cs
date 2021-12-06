using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class ChangeStartPageSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private StartPageChange _startPage;

        public ChangeStartPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _startPage = new StartPageChange(_driver);
        }

        [When(@"Find the App starts")]
        public void WhenFindTheAppStarts()
        {
            _startPage.ClickAppStartsButton();
        }
        
        [When(@"Select page, what  you want to see like start page")]
        public void WhenSelectPageWhatYouWantToSeeLikeStartPage()
        {
            _startPage.ChooseMyProfile();
        }

        [When(@"Tap the button back")]
        public void WhenTapTheButtonBack()
        {
            _startPage.ClickBackButton();
        }


        [Then(@"The start page changed")]
        public void ThenTheStartPageChanged(string text)
        {
            Assert.AreEqual(actual: _myProfileText.ChooseMyProfileText(text), expected: text);
        }
    }
}
