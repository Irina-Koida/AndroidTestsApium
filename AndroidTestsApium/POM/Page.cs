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
        By emailFiel = By.Id("vivino.web.app:id/til_email");
        By passwordFiel = By.Id("vivino.web.app:id/til_password");
        By nextButton = By.Id("vivino.web.app:id/action_next");
        By firstNameFiel = By.Id("vivino.web.app:id/edtUserName");
        By lastNameFiel = By.Id("vivino.web.app:id/edtUserSurname");
        //By selectCountryButton = By.Id("vivino.web.app:id/txtCountryValue");
        //By selectCountry = By.xPath("/hierarchy/android.widget.FrameLayout/android.widget.

        //LinearLayout / android.widget.FrameLayout / android.widget.FrameLayout / android.widget.
        //FrameLayout / androidx.appcompat.widget.LinearLayoutCompat / android.widget.
        //FrameLayout / android.widget.ListView / android.widget.RelativeLayout[13] / android.widget.TextView");

        //By selectStateButton = By.Id("vivino.web.app:id/til_password");
        ////By selectLanguageButton = By.Id("vivino.web.app:id/til_password");
        //By doneButton = By.Id("vivino.web.app:id/action_done");
        //By asseptPolicy By.Id("vivino.web.app:id/new_profile_agree_terms");


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

        //public Page Email(string text)
        //{
        //    email.SendKeys(text);
        //    return this;
        //}
        //public Page Email(string text)
        //{
        //    email.SendKeys(text);
        //    return this;
        //}
        //public Page Email(string text)
        //{
        //    email.SendKeys(text);
        //    return this;
        //}
        //public Page Email(string text)
        //{
        //    email.SendKeys(text);
        //    return this;
        //}
    }
}
