using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public sealed class ContinueVithoutAccauntVivino
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;

        public ContinueVithoutAccauntVivino(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            

            _scenarioContext.Pending();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           

            _scenarioContext.Pending();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           

            _scenarioContext.Pending();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
         

            _scenarioContext.Pending();
        }
    }
}
