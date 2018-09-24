using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using KeyProjectTest.Pages;
using OpenQA.Selenium.Support.UI;
using System;

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


            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");
      
            
        }


        
        [When(@"I login with Username and Password on the Login Page")]
        public void WhenILoginWithUsernameAndPasswordOnTheLoginPage()
        {


            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");

            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();

            



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


































