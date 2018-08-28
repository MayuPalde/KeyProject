using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using KeyProjectTest.Pages;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        private readonly  IWebDriver _driver;

        public LoginSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");                
                
        }


        [Given(@"I Navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            
            _driver.Navigate().GoToUrl("http://dev.property.community/Account/Login?ReturnUrl=%2fPropertyOwners");
            
        }


        
        [When(@"I login with Username and Password on the Login Page")]
        public void WhenILoginWithUsernameAndPasswordOnTheLoginPage()
        {


            LoginPage login = new LoginPage(_driver);

            login.LoginAs("apachedemo123@gmail.com" , "Owner@123");




        }



        
        [Then(@"Owners dashboard page should be seen on the screen")]
        public void ThenOwnersDashboardPageShouldBeSeenOnTheScreen()
        {



            var atualUser = _driver.FindElement(By.LinkText("Dashboard")).Text;
               
            var expectedUser = "Dashboard";

            Assert.IsTrue(atualUser.Contains(expectedUser));


          

        }
    }
}


































