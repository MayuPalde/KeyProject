using KeyProjectTest.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class AddNewRequestSteps
    {


        private readonly IWebDriver _driver;




        public AddNewRequestSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }




        [Given(@"I have logged in into the Application")]
        public void GivenIHaveLoggedInIntoTheApplication()
        {

            _driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");

            LoginPage login = new LoginPage(_driver);

            login.LoginAs("vincent.nguyen@mvpstudio.co.nz", "ntmv2682");




        }

        [Given(@"I navigated to My Request page")]
        public void GivenINavigatedToMyRequestPage()
        {

            OwnersDashboardPage dashboard = new OwnersDashboardPage(_driver);

            dashboard.ClickOnSkip();

            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnOwner();


            System.Threading.Thread.Sleep(2000);

            dashboard.ClickOnMyRequestLink();




        }

        [Given(@"I Clicked on Add New Request")]
        public void GivenIClickedOnAddNewRequest()
        {


            AddNewRequestPage request = new AddNewRequestPage(_driver);

            request.ClickOnAddNewRequest();


        }
        
        [Given(@"I filled all the inforamtion on My request page")]
        public void GivenIFilledAllTheInforamtionOnMyRequestPage()
        {

            AddNewRequestPage request = new AddNewRequestPage(_driver);

            request.SelectProperty();

            request.SelectDate();

            request.EnterDescription();



        }

        [When(@"I clicked on Save button")]
        public void WhenIClickedOnSaveButton()
        {

            AddNewRequestPage request = new AddNewRequestPage(_driver);

            request.ClickOnSaveButton();





        }

        [Then(@"I can see ""(.*)"" message on the screen")]
        public void ThenICanSeeMessageOnTheScreen(string p0)
        {
           

            System.Threading.Thread.Sleep(2000);

            AddNewRequestPage request = new AddNewRequestPage(_driver);


           request.takescreenshot();

        }









    }
}
