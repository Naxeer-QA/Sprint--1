using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class SkillsTab
    {
        IWebDriver driver;
        public SkillsTab(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-tab = 'second'][text() = 'Skills']")]
        [CacheLookup]
        public IWebElement skillsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//table//div[text()='Add New']")]
        [CacheLookup]
        public IWebElement addNewBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Add Skill']")]
        [CacheLookup]
        public IWebElement addSkillInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//select [@class = 'ui fluid dropdown']")]
        [CacheLookup]
        public IWebElement selectSkillLevel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'second']//span/input[(@type='button')][@value = 'Add']")]
        [CacheLookup]
        public IWebElement addSkill { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'second']//span/input[(@type='button')][@value = 'Cancel']")]
        [CacheLookup]
        public IWebElement cancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'second']//span[@class = 'button']/i[@class = 'outline write icon']")]
        [CacheLookup]
        public IWebElement editIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'second']//span[@class = 'button']/i[@class = 'remove icon']")]
        [CacheLookup]
        public IWebElement removeIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//input[@name = 'name']")]
        public IWebElement editSkillInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//select[@name = 'level']")]
        public IWebElement editProficiencyLevel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//span/input[@value = 'Update']")]
        public IWebElement updateSkill { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'fields']//span/input[@value = 'Cancel']")]

        public IWebElement cancelUpdate { get; set; }
        public void AddSkills()
        {
            skillsTab.Click();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown);
            System.Threading.Thread.Sleep(3000);
            addNewBtn.Click();
            addSkillInput.SendKeys("Automation");
            SelectElement sElement = new SelectElement(selectSkillLevel);
            sElement.SelectByValue("Intermediate");
            addSkill.Click();
            System.Threading.Thread.Sleep(3000);
        }
        public void EditSkills()
        {
            editIcon.Click();
            editSkillInput.Clear();
            editSkillInput.SendKeys("AutomationTesting");
            editProficiencyLevel.Click();
            SelectElement selectelement = new SelectElement(editProficiencyLevel);
            selectelement.SelectByIndex(3);
            updateSkill.Click();
            System.Threading.Thread.Sleep(3000);
        }
        public void DeleteSkills()
        {
            removeIcon.Click();
        }
    }
}
