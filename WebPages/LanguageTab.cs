using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class LanguageTab
    {
        IWebDriver driver;
        public LanguageTab(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab='first']//table//div[text()='Add New']")]
        [CacheLookup]
        public IWebElement addNewBtn { get; set; }

        //Language Tab related web element object identifications
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Add Language']")]
        [CacheLookup]
        public IWebElement addLanguageInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'ui dropdown'][@name = 'level']")]
        [CacheLookup]
        public IWebElement selectLanguageLevel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'ui teal button']")]
        [CacheLookup]
        public IWebElement addLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class = 'ui button'][@value = 'Cancel']")]
        [CacheLookup]
        public IWebElement cancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class = 'ui fixed table']//i[@class = 'outline write icon']")]
        [CacheLookup]
        public IWebElement editIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class = 'ui fixed table']//i[@class = 'remove icon']")]
        [CacheLookup]
        public IWebElement removeIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//input[@name = 'name']")]
        public IWebElement editLanguageInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//select[@name = 'level']")]
        public IWebElement editProficiencyLevel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//span/input[@value = 'Update']")]
        public IWebElement updateLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//span/input[@value = 'Cancel']")]

        public IWebElement cancelUpdate { get; set; }

        public void AddLanguage()
        {
            addNewBtn.Click();
            addLanguageInput.SendKeys("English");
            selectLanguageLevel.Click();
            SelectElement level = new SelectElement(selectLanguageLevel);
            level.SelectByValue("Native/Bilingual");
            addLanguage.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void EditLanguage()
        {
            editIcon.Click();
            editLanguageInput.Clear();
            editLanguageInput.SendKeys("Persian");
            editProficiencyLevel.Click();
            SelectElement level = new SelectElement(editProficiencyLevel);
            level.SelectByValue("Fluent");
            updateLanguage.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void DeleteLanguage()
        {
            removeIcon.Click();
        }
    }
    
}
