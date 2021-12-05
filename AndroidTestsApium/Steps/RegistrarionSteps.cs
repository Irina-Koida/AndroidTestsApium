using AndroidTestsApium.POM;
using NUnit.Framework;
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
        private PageRegistration _page;

        public RegistrarionSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _page = new PageRegistration(_driver);
        }

        [When(@"Tap the Get started button")]
        public void WhenTapTheGetStartedButton()
        {
            _page.ClickGetStartButton();
        }

        [When(@"Tap the gall button")]
        public void WhenTapTheGallButton()
        {
            _page.ClosedGooglemail();
        }

        [When(@"Enter '(.*)'")]
        public void WhenEnterYourEmail(string text)
        {
            _page.InputEmailField(text);
        }

        [When(@"Create '(.*)'")]
        public void WhenCreateAPassword(string text)
        {
            _page.InputPasswordField(text);
        }

        [When(@"Tap Next")]
        public void WhenTapNext()
        {
            _page.ClickNextButton();
        }

        [When(@"Enter your '(.*)' name")]
        public void WhenEnterYourFirstAndLastName(string text)
        {
            _page.InputFirstNameField(text);
        }

        [When(@"Enter your '(.*)' last name")]
        public void WhenEnterYourLastName(string text)
        {
            _page.InputLastNameField(text);
        }

        [When(@"Select state country")]
        public void WhenSelectStateCountry()
        {
            _page.ClickSelectStateCountry();
        }

        [When(@"Select state")]
        public void WhenSelectState()
        {
           _page.ClickSelectStateButton();
        }

        [When(@"Accept the Terms of Use and the Privacy Policy")]
        public void WhenAcceptTheTermsOfUseAndThePrivacyPolicy()
        {
            _page.ClickAcceptPolicy();
        }
        [When(@"Tap Done in the upper right corner")]
        public void WhenTapInTheUpperRightCorner()
        {
            _page.ClickDoneButton();
        }

        [Then(@"Open ""(.*)"" page with registration")]
        public void ThenOpenNextPageWithRegistration(string titleText)
        {
            Assert.AreEqual(titleText, _page.ClickNewProfile());
        }

        [Then(@"The ""(.*)"" with you profile opened")]
        public void ThenThePageWithYouProfileOpened(string titleText)
        {
            Assert.AreEqual(titleText, _page.ClickUserpage());
        }
    }
}
