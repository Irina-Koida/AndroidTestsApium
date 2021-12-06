using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AndroidTestsApium.POM
{
    public class PageRegistration
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public PageRegistration(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
           
        }       

        By getStartedButton = By.Id("vivino.web.app:id/getstarted_layout");
        By gall = By.Id("com.google.android.gms:id/cancel");
        By emailFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget." +
            "FrameLayout[2]/android.widget.ScrollView/android.widget.RelativeLayout/android.widget." +
            "LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[1]");
        By passwordFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget." +
            "RelativeLayout/android.widget.LinearLayout/android.widget." +
            "LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[2]");
        By nextButton = By.Id("vivino.web.app:id/action_next");
        By firstNameFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget." +
            "LinearLayout/android.widget.RelativeLayout/android.widget.EditText[1]");
        By lastNameFiel = By.XPath("vivino.web.app:id/edtUserSurname");
        By asseptPolicy = By.Id("vivino.web.app:id/new_profile_agree_terms");
        By newProfile = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.TextView");
        By doneButton = By.Id("vivino.web.app:id/action_done");
        By selectStateCountry = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget." +
            "LinearLayout/android.widget.RelativeLayout/android.widget.TextView[5]");
        By selectState = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget." +
            "LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget." +
            "RelativeLayout[4]/android.widget.TextView");
        By forYou = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView");


        public PageRegistration ClickGetStartButton()
        {
            _driver.FindElement(getStartedButton).Click();
            return this;
        }

        public PageRegistration ClosedGooglemail()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(gall).Click();
            return this;
        }

        public PageRegistration InputEmailField(string text)
        {
            _driver.FindElement(emailFiel).Click();
            _driver.FindElement(emailFiel).SendKeys(Helper.RandomEmailUser());
            return this;
        }

        public PageRegistration InputPasswordField(string text)
        {
            _driver.FindElement(passwordFiel).Click();
            _driver.FindElement(passwordFiel).SendKeys(Helper.RandomEmailUser());
            return this;
        }

        public PageRegistration ClickNextButton()
        {
            _driver.FindElement(nextButton).Click();
            return this;
        }

        public PageRegistration InputFirstNameField(string text)
        {
            _driver.FindElement(firstNameFiel).Click();
            _driver.FindElement(firstNameFiel).SendKeys("Dev");
            return this;
        }
        public PageRegistration InputLastNameField(string text)
        {
            _driver.FindElement(lastNameFiel).Click();
            _driver.FindElement(lastNameFiel).SendKeys("Deva");
            return this;
        }

        public PageRegistration ClickAcceptPolicy()
        {
            _driver.FindElement(asseptPolicy).Click();
            return this;
        }

        public string ClickNewProfile() =>
           _driver.FindElement(newProfile).Text;

        public PageRegistration ClickDoneButton()
        {
            _driver.FindElement(doneButton).Click();
            return this;
        }

        public PageRegistration ClickSelectStateCountry()
        {
            _driver.FindElement(selectStateCountry).Click();
            return this;
        }

        public PageRegistration ClickSelectStateButton()
        {
            _driver.FindElement(selectState).Click();
            return this;
        }

        public PageRegistration ClickUserpage()
        {
            _driver.FindElement(forYou).Click();
            return this;
        }
    }
}
