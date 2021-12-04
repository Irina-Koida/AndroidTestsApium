using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTestsApium.POM
{
    class SelectAWineWithoutRegistering
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Actions _action;
        private readonly WithoutRegistering _withoutRegistering;

        public SelectAWineWithoutRegistering(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _action = new Actions(_driver);
            _withoutRegistering = new WithoutRegistering(_driver);
        }

        private readonly By _search = By.Id("vivino.web.app:id/wine_explorer_tab");
        private readonly By _selectRed = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/" +
            "androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/" +
            "androidx.recyclerview.widget.RecyclerView / android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.RelativeLayout[1]/android.widget.ImageView[2]");
        private readonly By _redText = By.XPath("hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.TextView");
        private readonly By _countText = By.Id("vivino.web.app:id/subtitle");

        public SelectAWineWithoutRegistering SearchPage(string search)
        {
            _withoutRegistering.TapATryUsOut(search);
            _withoutRegistering.TapNext(search);
            _withoutRegistering.TapContiueWithoutAccount(search);
            _withoutRegistering.OpenProfilePage();
            _action.MoveToElement(_driver.FindElement(_search)).Click().Perform();
            return this;
        }

        public void RedWineSelect(string red) =>
         _action.MoveToElement(_driver.FindElement(_selectRed)).Click().Perform();

        public string RedTextInfo(string redWineText) =>
        _driver.FindElement(_redText).Text;

        public string RedWineCountText(string count) =>
            _driver.FindElement(_countText).Text;
    }
}
