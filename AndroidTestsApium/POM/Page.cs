using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        [FindsBy(How = How.Id, Using = "vivino.web.app:id/seehowitwork")]
        private AndroidElement _searchText;
        public Page Searsh(string text)
        {
            _searchText.SendKeys(text);
            return this;
        }
    }
}
