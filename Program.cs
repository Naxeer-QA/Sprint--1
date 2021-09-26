using MarsQA_Onboarding.WebPages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MarsQA_Onboarding
{
    class Program
    {
        IWebDriver driver;
        
        String baseUrl = "http://localhost:5000/";
        public Program(IWebDriver driver)
        {
            this.driver = driver;
        }
        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]
        public void BeforeEachTest()
        {
            //driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl(baseUrl);
        }

        [Test]
        public void LogInSuccess()
        {
            LoginModule login = new LoginModule(driver);
            login.LoginSuccess();
            System.Threading.Thread.Sleep(3000);
        }

        [Test]
        public void LogOff()
        {
            LoginModule login = new LoginModule(driver);
            login.Logout();
        }

        [Test]
        public void SignUpSuccess()
        {
            RegistrationModule register = new RegistrationModule(driver);
            register.JoinSuccessfull();
            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void SignUpNLogIn(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");

            RegistrationModule registration = new RegistrationModule(driver);
            registration.JoinSuccessfull();
            System.Threading.Thread.Sleep(5000);

            LoginModule loginmodule = new LoginModule(driver);
            loginmodule.LoginSuccess();
            System.Threading.Thread.Sleep(4000);
            loginmodule.Logout();
        }
        [OneTimeTearDown]
        public void AfterEachTest()
        {
            System.Threading.Thread.Sleep(3000);
            driver.Close();
        }
    }
}
