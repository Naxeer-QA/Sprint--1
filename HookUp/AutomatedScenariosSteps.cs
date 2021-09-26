using MarsQA_Onboarding.WebPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsQA_Onboarding.HookUp
{
    [Binding]
    public class AutomatedScenariosSteps
    {
        IWebDriver driver = new ChromeDriver();
        //IWebDriver driver;

        [Given(@"the new seller signs up and logs in to the website")]
        public void GivenTheNewSellerSignsUpAndLogsInToTheWebsite()
        {
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://localhost:5000/");
            Program program = new Program(driver);
            program.BeforeEachTest();
            program.SignUpSuccess();
            program.LogInSuccess();
        }
        
        [Given(@"the seller is logged in to the website")]
        public void GivenTheSellerIsLoggedInToTheWebsite()
        {
            Program program = new Program(driver);
            program.BeforeEachTest();
            program.LogInSuccess();
        }
        
        [When(@"the seller adds the description")]
        public void WhenTheSellerAddTheDescription()
        {
            DescriptionTab desc = new DescriptionTab(driver);
            desc.AddDescription();
            System.Threading.Thread.Sleep(5000);
        }
        
        [When(@"the seller adds language details")]
        public void WhenTheSellerAddsTheLanguageDetails()
        {
            LanguageTab langtab = new LanguageTab(driver);
            langtab.AddLanguage();
        }
        
        [When(@"the seller adds the skills")]
        public void WhenTheSellerAddsTheSkills()
        {
            SkillsTab skilltab = new SkillsTab(driver);
            skilltab.AddSkills();
            System.Threading.Thread.Sleep(4000);
        }
        
        [When(@"the seller adds the education details")]
        public void WhenTheSellerAddsTheEducationDetails()
        {
            EducationTab eduTab = new EducationTab(driver);
            eduTab.AddEducation();
        }
        
        [When(@"the seller adds the certification details")]
        public void WhenTheSellerAddsTheCertificationDetails()
        {
            CertificationTab certTab = new CertificationTab(driver);
            certTab.AddCertification();

        }
        
        [When(@"the seller edits the description")]
        public void WhenTheSellerEditsTheDescription()
        {
            DescriptionTab descriptiontab = new DescriptionTab(driver);
            descriptiontab.EditDescription();
        }
        
        [When(@"the seller edits the language")]
        public void WhenTheSellerEditsTheLanguage()
        {
            LanguageTab languagetab = new LanguageTab(driver);
            //languagetab.AddLanguage();
            languagetab.EditLanguage();
            languagetab.DeleteLanguage();
        }
        
        [When(@"the seller edits skills")]
        public void WhenTheSellerEditsSkills()
        {
            SkillsTab skilltab = new SkillsTab(driver);
            //skilltab.AddSkills();
            skilltab.EditSkills();
            skilltab.DeleteSkills();
        }
        
        [When(@"the seller edits education details")]
        public void WhenTheSellerEditsEducationDetails()
        {
            EducationTab educationtab = new EducationTab(driver);
            //educationtab.AddEducation();
            educationtab.EditEducation();
            educationtab.DeleteEducation();
        }
        
        [When(@"the seller edits the certification details")]
        public void WhenTheSellerEditsTheCertificationDetails()
        {
            CertificationTab ct = new CertificationTab(driver);
            //ct.AddCertification();
            ct.EditCertificate();
            ct.DeleteCertificate();
        }
        
        [Then(@"the profile page is shown")]
        public void ThenTheProfilePageIsShown()
        {
            ProfilePage profilepage = new ProfilePage(driver);
            profilepage.profileTab.Click();
            Program program = new Program(driver);
            program.LogOff();
            program.AfterEachTest();
        }
        
        [Then(@"the added details are shown in the description box")]
        public void ThenTheAddedDetailsAreShownInTheDescriptionBox()
        {
            //Need to automate the verification of toast message
            DescriptionTab descTab = new DescriptionTab(driver);
        }
        
        [Then(@"the added details are shown in the language tab")]
        public void ThenTheAddedDetailsAreShownInTheLanguageTab()
        {
            //Need to automate the verification of toast message
            //String expectedMsg = "English has been added to your languages";
            //String actualMsg = driver.FindElement(By.ClassName("")).GetAttribute("innerHTML");
            //Console.WriteLine(actualMsg);
            //Assert.AreEqual(expectedMsg, actualMsg);
            LanguageTab langTab = new LanguageTab(driver);
            
        }
        
        [Then(@"the added details are shown in the skills tab")]
        public void ThenTheAddedDetailsAreShownInTheSkillsTab()
        {
            //Need to automate the verification of toast message
            SkillsTab skilltab = new SkillsTab(driver);
            
        }

        [Then(@"the added details are shown in the education tab")]
        public void ThenTheAddedDetailsAreShownInTheEducationTab()
        {
            //Need to automate the verification of toast message
            EducationTab educationtab = new EducationTab(driver);
        }
        
        [Then(@"the added details are shown in the certification tab")]
        public void ThenTheAddedDetailsAreShownInTheCertificationTab()
        {
            //Need to automate the verification of toast message
            CertificationTab certificationtab = new CertificationTab(driver);
            Program pro = new Program(driver);
            pro.LogOff();
            pro.AfterEachTest();
        }

        [Then(@"the edited details are shown")]
        public void ThenTheEditedDetailsAreShown()
        {
            DescriptionTab dt = new DescriptionTab(driver);
        }
        
        [Then(@"the edited language is shown")]
        public void ThenTheEditedLanguageIsShown()
        {
            //Need to automate the verification of toast message
            LanguageTab languagetab = new LanguageTab(driver);
        }

        [Then(@"the edited skills are shown")]
        public void ThenTheEditedSkillsAreShown()
        {
            //Need to automate the verification of toast message
            SkillsTab skilltab = new SkillsTab(driver);
        }

        [Then(@"the education details edited successfully")]
        public void ThenTheEducationDetailsEditedSuccessfully()
        {
            EducationTab educationtab = new EducationTab(driver);
        }
        
        [Then(@"the certification details edited successfully")]
        public void ThenTheCertificationDetailsEditedSuccessfully()
        {
            CertificationTab certificationtab = new CertificationTab(driver);
            Program program = new Program(driver);
            program.LogOff();
            program.AfterEachTest();
        }
    }
}
