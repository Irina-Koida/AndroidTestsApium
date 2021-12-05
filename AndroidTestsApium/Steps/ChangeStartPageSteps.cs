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
        private DarkTheme _darkTheme;

        public ChangeStartPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _darkTheme = new DarkTheme(_driver);
        }

        [When(@"Find the App starts")]
        public void WhenFindTheAppStarts()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Select page, what  you want to see like start page")]
        public void WhenSelectPageWhatYouWantToSeeLikeStartPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The start page changed")]
        public void ThenTheStartPageChanged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
