using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class ProfilePageHeaders
    {
        public ProfilePageHeaders(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Mars Logo')]")]
        [CacheLookup]
        public IWebElement marsLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder= 'Search skills']")]
        [CacheLookup]
        public IWebElement searchSkillInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class = 'search link icon']")]
        [CacheLookup]
        public IWebElement searchLinkIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Notification')]")]
        [CacheLookup]
        public IWebElement notificationDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Chat')]")]
        [CacheLookup]
        public IWebElement chatIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class = 'item ui dropdown link']")]
        [CacheLookup]
        public IWebElement profileDropDown { get; set; }

    }
}
