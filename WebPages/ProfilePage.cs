using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
     class ProfilePage
    {
        IWebDriver driver;

        public ProfilePage(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(driver, this);
            
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Dashboard']")]
        [CacheLookup]
        public IWebElement dashboardTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Profile']")]
        [CacheLookup]
        public IWebElement profileTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Manage Listings']")]
        [CacheLookup]
        public IWebElement manageListingsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Manage Requests']")]
        [CacheLookup]
        public IWebElement manageRequestsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class = 'ui basic green button']")]
        [CacheLookup]
        public IWebElement shareSkillBtn { get; set; }

    }
}
