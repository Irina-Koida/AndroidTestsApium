using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndroidTestsApium.POM
{
    public class Page
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public Page(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        By getStartedButton = By.Id("vivino.web.app:id/getstarted_layout");
        // By emailFiel
        //  By passwordFiel
        //  By nextButton
        //   By firstNameFiel
        //  By lastNameFiel
        // By selectCountryButton
        // By selectStateButton
        //   By selectLanguageButton
        // By doneButton
        // By 

        //[FindsBy(How = How.Id, Using = "vivino.web.app:id/seehowitwork")]
        //private AndroidElement _searchText;

        public Page Login()
        {
            _driver.FindElement(getStartedButton).Click();
            return this;
        }

        [FindsBy(How = How.Id, Using = "getstarted_layout")] // Вход в аккаунт
        private AndroidElement searchText;

        [FindsBy(How = How.Id, Using = "til_email")] // Вход в аккаунт
        private AndroidElement email;

        public Page Search()
        {
            searchText.Click();
            return this;
        }

        public Page Email(string text)
        {
            email.SendKeys(text);
            return this;
        }
    }
}
