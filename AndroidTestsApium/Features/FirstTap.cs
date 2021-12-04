using AndroidTestsApium.POM;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using System;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public sealed class ContinueVithoutAccauntVivino
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private Page _page;
        public ContinueVithoutAccauntVivino(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _page = new Page(_driver);
        }

        [When(@"Tap the ""(.*)"" button")]
        public void GivenTheFirstNumberIs()
        {
            _page.Login();
        }
    }
}
