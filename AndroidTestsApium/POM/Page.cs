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
        //By asseptPolicy By.Id("vivino.web.app:id/new_profile_agree_terms");
        //By doneButton = By.Id("vivino.web.app:id/action_done");


        [FindsBy(How = How.Id, Using = "getstarted_layout")] 
        private AndroidElement searchText;

        public Page Login()
        {
            _driver.FindElement(getStartedButton).Click();
            return this;
        }
       
        [FindsBy(How = How.Id, Using = "til_email")] 
        private AndroidElement email;

        public Page Email(string text)
        {
            email.SendKeys(text);
            return this;
        }






        //public Page InputEmail(string mail)
        //{
        //    _webDriver.FindElement(_emailUser).SendKeys(mail);
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
        //public Page Email(string text)
        //{
        //    email.SendKeys(text);
        //    return this;
        //}
    }
}
