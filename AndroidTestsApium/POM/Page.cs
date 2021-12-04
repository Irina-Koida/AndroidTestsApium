using AndroidTestsApium.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    public class Page
    {
        // AppiumDriver wait = new AppiumDriver(TimeSpan.FromSeconds(15));
        //AppiumDriver wait = new AppiumDriver(driver, TimeSpan.FromSeconds(20));
        //AndroidElement elevent = wait.Until(SeleniumExtras
        //    .WaitHelpers
        //    .ExpectedConditions
        //    .ElementIsVisible(By.Id("com.google.android.gms:id/cancel")));

        private readonly AndroidElement _element;

        private readonly AppiumDriver<AndroidElement> _driver;

        public Page(AppiumDriver<AndroidElement> appiumDriver, AndroidElement element)
        {
            _driver = appiumDriver;
            _element = element;         
        }

        

        By getStartedButton = By.Id("vivino.web.app:id/getstarted_layout");
        By gall = By.Id("com.google.android.gms:id/cancel");
        By emailFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[1]");
        By passwordFiel = By.XPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout[2] / android.widget.ScrollView / android.widget.RelativeLayout / android.widget.LinearLayout / android.widget.LinearLayout[1] / android.view.ViewGroup / android.widget.LinearLayout[2]");
        By nextButton = By.Id("vivino.web.app:id/action_next");
        By firstNameFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.EditText[1]");
        By lastNameFiel = By.XPath("vivino.web.app:id/edtUserSurname");
        By asseptPolicy = By.Id("vivino.web.app:id/new_profile_agree_terms");
        By newProfile = By.XPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout[1] / android.view.ViewGroup / android.widget.TextView");
        By doneButton = By.Id("vivino.web.app:id/action_done");


        //[FindsBy(How = How.Id, Using = "getstarted_layout")] 
        //private AndroidElement searchText;
        //[FindsBy(How = How.Id, Using = "til_email")]
        //private AndroidElement email;

        public Page Login()
        {
            _driver.FindElement(getStartedButton).Click();
            return this;
        }

        public Page Gall()
        {
           // gall = wait.Time(Until.ExplisitWait.ExpectedConditions.FindElement.ElementExist(By.Id("com.google.android.gms:id/cancel"));
            _driver.FindElement(gall).Click();
            return this;
        }

        public Page Email(string text)
        {
            _driver.FindElement(emailFiel).Click();
            return this;
            _driver.FindElement(emailFiel).SendKeys(Helper.RandomEmailUser());
            return this;
        }

        public Page Password(string text)
        {
            _driver.FindElement(passwordFiel).Click();
            return this;
            _driver.FindElement(passwordFiel).SendKeys(Helper.RandomEmailUser());
            return this;
        }

        public Page Next()
        {
            _driver.FindElement(nextButton).Click();
            return this;
        }

        public Page FirstName(string text)
        {
            _driver.FindElement(firstNameFiel).Click();
            return this;
            _driver.FindElement(firstNameFiel).SendKeys("Dev");
            return this;
        }
        public Page LastName(string text)
        {
            _driver.FindElement(lastNameFiel).Click();
            return this;
            _driver.FindElement(lastNameFiel).SendKeys("Deva");
            return this;
        }

        public Page Accept()
        {
            _driver.FindElement(asseptPolicy).Click();
            return this;
        }

        public string ClickNewProfile() =>
           _driver.FindElement(newProfile).Text;
    }
}
