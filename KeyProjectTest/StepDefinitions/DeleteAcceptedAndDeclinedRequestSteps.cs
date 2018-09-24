using KeyProjectTest.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class DeleteAcceptedAndDeclinedRequestSteps
    {


        private readonly IWebDriver _driver;




        public DeleteAcceptedAndDeclinedRequestSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }
        [Given(@"I  have logged in into the application")]
        public void GivenIHaveLoggedInIntoTheApplication()
        {
            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");

            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");


        }

        [Given(@"I navigated to ""(.*)"" page")]
        public void GivenINavigatedToPage(string p0)
        {

            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();


        }

        [Given(@"I clicked on Accepted link")]
        public void GivenIClickedOnAcceptedLink()
        {

            MyRequestsPage acceptedLink = new MyRequestsPage(_driver);

            acceptedLink.ClickOnAcceptedrequestLink();

        }

        [Given(@"I clicked on  Declined link")]
        public void GivenIClickedOnDeclinedLink()
        {
            MyRequestsPage declinedrequest = new MyRequestsPage(_driver);

            declinedrequest.ClickOnDeclinedRequestLink();


        }

        [When(@"I click on Delete button and Confirm my Delete request on accpted request page")]
        public void WhenIClickOnDeleteButtonAndConfirmMyDeleteRequestOnAccptedRequestPage()
        {
            AcceptedRequestPage p1 = new AcceptedRequestPage(_driver);

            p1.ClickOnDeleteButton();

            System.Threading.Thread.Sleep(2000);

            p1.ClickOnConfirmButton();

        }
        
        [When(@"I click on Delete button and confirm my delete request on declined request page")]
        public void WhenIClickOnDeleteButtonAndConfirmMyDeleteRequestOnDeclinedRequestPage()
        {

            DeclinedRequestPage p2 = new DeclinedRequestPage(_driver);

            p2.ClickOnDeleteButton();
            p2.ClickOnConfirmButton();



        }

        [Then(@"I  am able to see ""(.*)"" message on the screen")]
        public void ThenIAmAbleToSeeMessageOnTheScreen(string p0)
        {

            var atualUser = _driver.FindElement(By.LinkText("Dashboard")).Text;

            var expectedUser = "Dashboard";

            Assert.IsTrue(atualUser.Contains(expectedUser));





        }
    }
}
