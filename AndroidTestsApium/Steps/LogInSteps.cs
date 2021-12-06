using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class LogInSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private LogInPage _loginInPage;

        public LogInSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _loginInPage = new LogInPage(_driver);
        }

        [When(@"Tap I have account button")]
        public void WhenTapIHaveAccountButton()
        {
            _loginInPage.ClickHaveAccountButton();
        }

        [When(@"Input '(.*)' email")]
        public void WhenInput(string text)
        {
            _loginInPage.InputEmailField(text);
        }

        [When(@"Input '(.*)' password")]
        public void WhenInputPassword(string text)
        {
            _loginInPage.InputPasswordField(text);
        }

        [When(@"Tap logIn button")]
        public void WhenTapLogInButton()
        {
            _loginInPage.ClickLogInButton();
        }
        
        [When(@"Closed save password window")]
        public void WhenClosedSavePasswordWindow()
        {
            _loginInPage.ClosedSavePassword();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string text)
        {
            Assert.AreEqual(actual: _loginInPage.ChooseForYouTitle(text), expected: text);
        }
    }
}
