using KeyProjectTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class DetailsOfAcceptedAndDeclinedRequestSteps
    {





        private readonly IWebDriver _driver;




        public DetailsOfAcceptedAndDeclinedRequestSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }


        [Given(@"I log in into the application")]
        public void GivenILogInIntoTheApplication()
        {


            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");

            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");



        }

        [Given(@"I navigate to ""(.*)"" page")]
        public void GivenINavigateToPage(string p0)
        {

            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();



        }
        
        [Given(@"I clicked on Acccepted link")]
        public void GivenIClickedOnAccceptedLink()
        {
            MyRequestsPage accepted = new MyRequestsPage(_driver);

            accepted.ClickOnAcceptedrequestLink();
        }

        
        [Given(@"I clicked on Declined link")]
        public void GivenIClickedOnDeclinedLink()
        {
            MyRequestsPage declined = new MyRequestsPage(_driver);

            declined.ClickOnDeclinedRequestLink();

        }
        
        [When(@"I click on Details button")]
        public void WhenIClickOnDetailsButton()
        {

            AcceptedRequestPage p = new AcceptedRequestPage(_driver);

            p.ClickOnDetailsButton();



            DeclinedRequestPage d = new DeclinedRequestPage(_driver);

            d.ClickOnDetailsButton();
          

        }
        
        [Then(@"I am able to see Details of accepted request")]
        public void ThenIAmAbleToSeeDetailsOfAcceptedRequest()
        {


            String ActualUrl = _driver.Url;

            String expectedUrl = "http://new-keys.azurewebsites.net/PropertyOwners/Property/MyRequests?RequestStatus=Accepted";

            Assert.IsTrue(ActualUrl.Contains(expectedUrl));

            Console.WriteLine("Url Matched");


        }
        
        [Then(@"I am able to see Details of declined request")]
        public void ThenIAmAbleToSeeDetailsOfDeclinedRequest()
        {


            String ActualUrl = _driver.Url;

            String expectedUrl = "http://new-keys.azurewebsites.net/PropertyOwners/Property/MyRequests?RequestStatus=Declined";

            Assert.IsTrue(ActualUrl.Contains(expectedUrl));

            Console.WriteLine("Url Matched");




        }
    }
}
