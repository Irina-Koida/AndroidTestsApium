using System;
using AndroidTestsApium.POM;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{


        [Binding]
    public class RegistrarionSteps
    {

        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private Page _page;

        public RegistrarionSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _page = new Page(_driver);
        }

        [When(@"Tap the Get started button")]
        public void WhenTapTheGetStartedButton()
        {
            _page.Login();
        }

        [When(@"Enter '(.*)' email")]
        public void WhenEnterYourEmail(string text)
        {
            _page.Email(text);
        }

        [When(@"Create '(.*)' password")]
        public void WhenCreateAPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Tap Next")]
        public void WhenTapNext()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Enter your '(.*)' name")]
        public void WhenEnterYourFirstAndLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Enter your '(.*)' last name")]
        public void WhenEnterYourLastName(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Accept the Terms of Use and the Privacy Policy")]
        public void WhenAcceptTheTermsOfUseAndThePrivacyPolicy()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Tap ""(.*)"" in the upper right corner")]
        public void WhenTapInTheUpperRightCorner(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Open next page with registration")]
        public void ThenOpenNextPageWithRegistration()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page with you profile opened")]
        public void ThenThePageWithYouProfileOpened()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
