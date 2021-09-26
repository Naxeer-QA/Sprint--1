using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class LoginModule
    {
        IWebDriver driver;
        public LoginModule(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
            
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Sign In')]")]
        [CacheLookup]

        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        [CacheLookup]
        public IWebElement emailInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        [CacheLookup]
        public IWebElement passwordInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'rememberDetails']")]
        [CacheLookup]
        public IWebElement rememberMe { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text() = 'Login']")]
        [CacheLookup]
        public IWebElement loginBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Forgot your password?')]")]
        [CacheLookup]
        public IWebElement forgotPasswordLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Join')]")]
        [CacheLookup]
        public IWebElement joinBtnFromSignInModule { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()= 'Sign Out']")]
        [CacheLookup]
        public IWebElement SignOutBtn { get; set; }

        internal void LoginSuccess()
        {
            Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Sprint1\MarsQA_Onboarding\MarsQA_Onboarding\TestData\TestData.xlsx", "LoginModule");
            //WaitHelpers.SyncHelpers.waitUntilClickable(driver, SignIn);
            System.Threading.Thread.Sleep(3000);
            SignIn.Click();
            emailInputField.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "emailID"));
            emailInputField.Click();
            passwordInputField.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "password"));
            passwordInputField.Click();
            loginBtn.Click();
        }

        internal void Logout()
        {
            SignOutBtn.Click();
            System.Threading.Thread.Sleep(3000);
        }
    }

}
    


