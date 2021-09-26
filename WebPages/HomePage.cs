using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class HomePage
    {
        IWebDriver driver;
        //Constructor created to initialize below web element objects
        public HomePage(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@type = 'text']")]
        public IWebElement SearchInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()= 'Search']")]
        public IWebElement SearchBtn { get; set; }
    }

}
