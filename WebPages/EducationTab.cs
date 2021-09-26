using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class EducationTab
    {
        IWebDriver driver;
        public EducationTab(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-tab = 'third'][text() = 'Education']")]
        [CacheLookup]
        public IWebElement educationTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab='third']//table//div[text()='Add New']")]
        [CacheLookup]
        public IWebElement addNewBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'College/University Name']")]
        [CacheLookup]
        public IWebElement addCollegeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'ui dropdown'][@name = 'country']")]
        [CacheLookup]
        public IWebElement countryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'ui dropdown'][@name = 'title']")]
        [CacheLookup]
        public IWebElement titleDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Degree'][@name = 'degree']")]
        [CacheLookup]
        public IWebElement degreeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@class = 'ui dropdown'][@name = 'yearOfGraduation']")]
        [CacheLookup]
        public IWebElement graduationYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//input[(@type='button')][@value = 'Add']")]
        [CacheLookup]

        public IWebElement addEducation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//input[(@type='button')][@value = 'Cancel']")]
        [CacheLookup]
        public IWebElement cancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//span[@class = 'button']/i[@class = 'outline write icon']")]
        [CacheLookup]
        public IWebElement editIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//span[@class = 'button']/i[@class = 'remove icon']")]
        [CacheLookup]
        public IWebElement removeIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//input[@name = 'instituteName']")]
        public IWebElement editCollegeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//select[@name = 'country']")]
        public IWebElement editCountryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//select[@name = 'title']")]
        public IWebElement editTitleDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//input[@name = 'degree']")]

        public IWebElement editDegreeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//select[@name = 'yearOfGraduation']")]

        public IWebElement editGraduationYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//input[@value='Update']")]
        public IWebElement updateEducation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-tab = 'third']//input[@value='Cancel']")]

        public IWebElement cancelUpdate { get; set; }

        public void AddEducation()
        {
            educationTab.Click();
            //Actions action = new Actions(driver);
            //action.SendKeys(Keys.PageDown);
            addNewBtn.Click();
            addCollegeInput.SendKeys("Auckland Institute of studies");
            SelectElement oSelect = new SelectElement(countryDropdown);
            oSelect.SelectByValue("India");
            SelectElement sElement = new SelectElement(titleDropdown);
            sElement.SelectByValue("Associate");
            degreeInput.SendKeys("GDIT");
            SelectElement selement = new SelectElement(graduationYear);
            selement.SelectByValue("2018");
            addEducation.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void EditEducation()
        {
            editIcon.Click();
            editCollegeInput.Clear();
            editCollegeInput.SendKeys("AIS");
            editCountryDropdown.Click();
            SelectElement se = new SelectElement(editCountryDropdown);
            se.SelectByText("New Zealand");
            SelectElement SE = new SelectElement(editTitleDropdown);
            SE.SelectByIndex(8);
            editDegreeInput.SendKeys("Software Development");
            SelectElement sElement = new SelectElement(editGraduationYear);
            sElement.SelectByValue("2018");
            updateEducation.Click();
            System.Threading.Thread.Sleep(3000);
        }

        public void DeleteEducation()
        {
            removeIcon.Click();
        }
    }
}
