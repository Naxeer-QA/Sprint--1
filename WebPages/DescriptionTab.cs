using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsQA_Onboarding.WebPages
{
    class DescriptionTab
    {
        IWebDriver driver;
        public DescriptionTab(IWebDriver d)
        {
            driver = d;
            PageFactory.InitElements(d, this);
        }

        [FindsBy(How = How.XPath, Using = "//i[@class = 'outline write icon']")]
        [CacheLookup]
        public IWebElement descriptionEditBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@name = 'value']")]
        [CacheLookup]
        public IWebElement descTextArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class = 'ui teal button'][@type = 'button']")]
        [CacheLookup]
        public IWebElement descSaveBtn { get; set; }

        public void AddDescription()
        {
            Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Sprint1\MarsQA_Onboarding\MarsQA_Onboarding\TestData\TestData.xlsx", "Description");
            descriptionEditBtn.Click();
            System.Threading.Thread.Sleep(3000);
            if (descTextArea != null)
            {
                descTextArea.Clear();
            }
            descTextArea.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "AddDescription"));
            System.Threading.Thread.Sleep(5000);
            descSaveBtn.Click();
            System.Threading.Thread.Sleep(5000);
        }
        public void EditDescription()
        {
            Utilities.ExcelLibHelpers.PopulateInCollection(@"D:\Internship\Sprint1\MarsQA_Onboarding\MarsQA_Onboarding\TestData\TestData.xlsx", "Description");
            descriptionEditBtn.Click();
            System.Threading.Thread.Sleep(3000);
            if (descTextArea != null)
            {
                descTextArea.Clear();
            }
            descTextArea.SendKeys(Utilities.ExcelLibHelpers.ReadData(2, "EditDescription"));
            System.Threading.Thread.Sleep(5000);
            descSaveBtn.Click();
            System.Threading.Thread.Sleep(5000);
        }

    }

}
