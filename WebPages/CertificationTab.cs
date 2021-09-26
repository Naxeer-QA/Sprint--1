using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class CertificationTab
    {
        IWebDriver driver;
        public CertificationTab(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-tab = 'fourth'][text() = 'Certifications']")]
        [CacheLookup]
        public IWebElement certificationTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab='fourth']//table//div[text()='Add New']")]
        [CacheLookup]
        public IWebElement addNewBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'certification-award capitalize']")]
        [CacheLookup]
        public IWebElement addCertificateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'received-from capitalize']")]
        [CacheLookup]
        public IWebElement awardedFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'ui fluid dropdown'][@name = 'certificationYear']")]
        [CacheLookup]
        public IWebElement awardedYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'fourth']//input[(@type='button')][@value = 'Add']")]
        [CacheLookup]

        public IWebElement addAward { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'fourth']//input[(@type='button')][@value = 'Cancel']")]
        [CacheLookup]
        public IWebElement cancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'fourth']//i[@class = 'outline write icon']")]
        [CacheLookup]
        public IWebElement editIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'fourth']//i[@class = 'remove icon']")]
        [CacheLookup]
        public IWebElement removeIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'certification-award capitalize']")]
        [CacheLookup]
        public IWebElement editCertificateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'received-from capitalize']")]
        [CacheLookup]
        public IWebElement editAwardedFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'ui fluid dropdown'][@name = 'certificationYear']")]
        [CacheLookup]
        public IWebElement editAwardedYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'fourth']//input[(@type='button')][@value = 'Update']")]
        [CacheLookup]

        public IWebElement updateAward { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'fourth']//input[(@type='button')][@value = 'Cancel']")]
        [CacheLookup]

        public IWebElement cancelUpdate { get; set; }

        public void AddCertification()
        {
            certificationTab.Click();
            //Actions action = new Actions(driver);
            //action.SendKeys(Keys.PageDown);
            addNewBtn.Click();
            addCertificateInput.SendKeys("ISTQB");
            awardedFrom.SendKeys("MindQ");
            SelectElement sElement = new SelectElement(awardedYear);
            sElement.SelectByIndex(4);
            addAward.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void EditCertificate()
        {
            editIcon.Click();
            editCertificateInput.Clear();
            editCertificateInput.SendKeys("Selenium");
            editAwardedFrom.Clear();
            editAwardedFrom.SendKeys("MindQ");
            editAwardedYear.Click();
            SelectElement se = new SelectElement(editAwardedYear);
            se.SelectByIndex(5);
            updateAward.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void DeleteCertificate()
        {
            removeIcon.Click();
        }

    }
}
