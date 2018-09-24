using KeyProjectTest.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class SeeDetailsFeatureSteps
    {

        private readonly IWebDriver _driver;




        public SeeDetailsFeatureSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }

        [Given(@"I  logged  into the application")]
        public void GivenILoggedIntoTheApplication()
        {


            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");

            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");




        }

        [Given(@"I navigated to MyRequest page")]
        public void GivenINavigatedToMyRequestPage()
        {
            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();




        }
        
        [Given(@"I navigated to Request Detials page")]
        public void GivenINavigatedToRequestDetialsPage()
        {
            MyRequestsPage request = new MyRequestsPage(_driver);

            request.ClickOnDetailsButton();



        }

        [When(@"I click on Back To Previous link")]
        public void WhenIClickOnBackToPreviousLink()
        {


            RequestDetailsPage details = new RequestDetailsPage(_driver);

            details.ClickOnBackToPreviousLink();



        }

        [Then(@"I am able to navigate to My request page")]
        public void ThenIAmAbleToNavigateToMyRequestPage()
        {

            var atualUser = _driver.FindElement(By.LinkText("Dashboard")).Text;

            var expectedUser = "Dashboard";

            Assert.IsTrue(atualUser.Contains(expectedUser));







        }

    }
}
