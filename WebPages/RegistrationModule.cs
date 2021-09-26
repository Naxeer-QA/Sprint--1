using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    internal class RegistrationModule
    {
        IWebDriver driver;
        public RegistrationModule(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
            
        }

        [FindsBy(How = How.XPath, Using = "//button[contains (text(), 'Join')]")]
        [CacheLookup]
        public IWebElement JoinBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'firstName']")]
        [CacheLookup]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'lastName']")]
        [CacheLookup]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'email']")]
        [CacheLookup]
        public IWebElement emailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'password']")]
        [CacheLookup]
        public IWebElement passwordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'confirmPassword']")]
        [CacheLookup]
        public IWebElement confirmPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'terms']")]
        [CacheLookup]
        public IWebElement termsCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id = 'submit-btn']")]
        [CacheLookup]
        public IWebElement submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), ' Login')]")]
        [CacheLookup]
        public IWebElement loginFromJoinModule { get; set; }

        internal void JoinSuccessfull()
        {
            Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Sprint1\MarsQA_Onboarding\MarsQA_Onboarding\TestData\TestData.xlsx", "JoinModule");
            JoinBtn.Click();
            firstName.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "firstName"));
            lastName.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "lastName"));
            emailField.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "emailID"));
            passwordField.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "password"));
            confirmPasswordField.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "confirmPassword"));
            termsCheckBox.Click();
            submit.Click();
        }
    }
}
