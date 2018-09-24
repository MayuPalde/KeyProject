using KeyProjectTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class EditRequestSteps
    {


        private readonly IWebDriver _driver;




        public EditRequestSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }



        [Given(@"I have logged in into the application")]
        public void GivenIHaveLoggedInIntoTheApplication()
        {


            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");

            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");




        }

        [Given(@"I navigated to My request page")]
        public void GivenINavigatedToMyRequestPage()
        {
            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();




        }

        [Given(@"I navigated to Edit request Page")]
        public void GivenINavigatedToEditRequestPage()
        {

            MyRequestsPage request = new MyRequestsPage(_driver);

            request.ClickOnEditButton();



        }

        [When(@"I Enter New inspection date in description")]
        public void WhenIEnterNewInspectionDateInDescription()
        {

            System.Threading.Thread.Sleep(2000);

            EditRequestPage edit = new EditRequestPage(_driver);

            edit.EnterNewInfo();



        }

        [When(@"I  Click on Save Button")]
        public void WhenIClickOnSaveButton()
        {
            EditRequestPage edit = new EditRequestPage(_driver);
            edit.ClickOnSaveButton();




        }
        
        [Then(@"I am able to see ""(.*)"" message on the screen")]
        public void ThenIAmAbleToSeeMessageOnTheScreen(string p0)
        {

            System.Threading.Thread.Sleep(2000);
            EditRequestPage edit = new EditRequestPage(_driver);

            edit.takescreenshot();





        }
    }
}
