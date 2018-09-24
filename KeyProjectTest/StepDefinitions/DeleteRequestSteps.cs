using KeyProjectTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class DeleteRequestSteps
    {

        private readonly IWebDriver _driver;




        public DeleteRequestSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }


        [Given(@"I logged in into the application")]
        public void GivenILoggedInIntoTheApplication()
        {

            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");

            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");




        }

        [Given(@"I navigated to Myrequest page")]
        public void GivenINavigatedToMyrequestPage()
        {
            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();









        }

        [Given(@"I navigated to Delete Request page")]
        public void GivenINavigatedToDeleteRequestPage()
        {

            MyRequestsPage request = new MyRequestsPage(_driver);

            request.ClickOnDeleteButton();





        }

        [When(@"I click on Confirm button")]
        public void WhenIClickOnConfirmButton()
        {

            DeleteRequestPage delete = new DeleteRequestPage(_driver);

            delete.ClickOnConfirm();

        }

        [Then(@"I am able see ""(.*)"" message on the screen")]
        public void ThenIAmAbleSeeMessageOnTheScreen(string p0)
        {



            System.Threading.Thread.Sleep(2000);

            DeleteRequestPage delete = new DeleteRequestPage(_driver);

            delete.takescreenshot();


         




        }
    }
}
        

