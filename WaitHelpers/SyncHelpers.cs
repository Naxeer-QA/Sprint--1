using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_Onboarding.WaitHelpers
{

    class SyncHelpers
    {
        public static void waitUntilVisible(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("")));
        }

        public static void waitUntilSelected(IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeSelected(By.XPath("")));
        }

        public static void waitUntilClickable(IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("")));
        }
    }
}
