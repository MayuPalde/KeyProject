using KeyProjectTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class SendRequestSteps
    {


        private readonly IWebDriver _driver;

        public SendRequestSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }

        [Given(@"I Log in into the Application")]
        public void GivenILogInIntoTheApplication()
        {

            _driver.Navigate().GoToUrl("http://dev.property.community/Account/Login?ReturnUrl=%2fPropertyOwners");


            LoginPage login = new LoginPage(_driver);

            login.LoginAs("apachedemo123@gmail.com", "Owner@123");

        }
        
        [Given(@"I navigate to General Request Page")]
        public void GivenINavigateToGeneralRequestPage()
        {


            MyPropertiesPage property = new MyPropertiesPage(_driver);

            property.ClickOnOwner();
            property.ClickOnProperties();
            property.ClickOnSendRequestButton();

        }

        [Given(@"I fill all the information regarding routine inspection request")]
        public void GivenIFillAllTheInformationRegardingRoutineInspectionRequest()
        {

            SendRequestPage request = new SendRequestPage(_driver);

             request.EnterDueDate();

            request.EnterRequestInfo();

            request.UploadImage();


        }
        
        [When(@"I click on Save Button")]
        public void WhenIClickOnSaveButton()
        {
            SendRequestPage request = new SendRequestPage(_driver);

            request.ClickOnSaveButtton();

        }


        [Then(@"Request should be successfully send to the respective tenant")]
        public void ThenRequestShouldBeSuccessfullySendToTheRespectiveTenant()
        {


            var atualUser = _driver.FindElement(By.LinkText("Dashboard")).Text;

            var expectedUser = "Dashboard";

            Assert.IsTrue(atualUser.Contains(expectedUser));






        }
    }
}
