using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class DarkThemeSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private DarkTheme _darkTheme;

        public DarkThemeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _darkTheme = new DarkTheme(_driver);
        }

        [When(@"Tap in the upper right corner of the Kebab Menu")]
        public void WhenTapInTheUpperRightCornerOfThe()
        {
            _darkTheme.ClickButtonBurgerMenu();
        }
        
        [When(@"From the offered list of options, select Settings")]
        public void WhenFromTheOfferedListOfOptionsSelect()
        {
            _darkTheme.ClickButtonSettings();
        }
        
       /* [When(@"Swipe down")]
        public void WhenSwipeDown()
        {
            _darkThemet.Pending();
        }*/
        
        [When(@"Find the Dark Mode field")]
        public void WhenFindTheField()
        {
            _darkTheme.ClickButtonDarkMode();
        }
        
        [When(@"Select Always in Dark Mode")]
        public void WhenSelect()
        {
            _darkTheme.ClickParametrDarkMode();
        }

        [Then(@"The start page is displayed with a '(.*)' theme")]
        public void ThenTheStartPageIsDisplayedWithADarkTheme(string dark)
        {
            Assert.AreEqual(actual: _darkTheme.AssertDarkMode(dark), expected: dark);
        }
    }
}
