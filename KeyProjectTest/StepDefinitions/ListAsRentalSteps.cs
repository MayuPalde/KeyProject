using KeyProjectTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class ListAsRentalSteps
    {


        private readonly IWebDriver _driver;

        public ListAsRentalSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }

        [Given(@"I Log in into the application")]
        public void GivenILogInIntoTheApplication()
        {
            _driver.Navigate().GoToUrl("http://dev.property.community/Account/Login?ReturnUrl=%2fPropertyOwners");


            LoginPage login = new LoginPage(_driver);

            login.LoginAs("apachedemo123@gmail.com", "Owner@123");

          }



        [Given(@"I navigate to List rental property page")]
        public void GivenINavigateToListRentalPropertyPage()
        {


            MyPropertiesPage property = new MyPropertiesPage(_driver);

            property.ClickOnOwner();
            property.ClickOnProperties();
            property.ClickOnListAsRentalButton();



        }


        [Given(@"I fill all the details of List Rental Property page")]
        public void GivenIFillAllTheDetailsOfListRentalPropertyPage()
        {


            ListRentalPropertyPage rental = new ListRentalPropertyPage(_driver);

            rental.EnterPropertyTitle();

            rental.EnterMovingCost();

            rental.EnterTargetRent();

            rental.EnterAvailableDate();

            rental.EnterOccupantsCount();

            rental.EnterPropertyDescription();

            rental.UploadFileAction();
            

          }
        
        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {

            ListRentalPropertyPage rental = new ListRentalPropertyPage(_driver);

            rental.ClickOnSaveButton();


        }

        [Then(@"I should navigate to Rental Listing And Tenant Application page")]
        public void ThenIShouldNavigateToRentalListingAndTenantApplicationPage()
        {

            var actualTitle = _driver.Title;

            var expectedtitle = "Properties";

            Assert.IsTrue(actualTitle.Contains(expectedtitle));



        }




        /*
         *	And  I can see my propeerty added as a Rental Propert
         * 
         * [Then(@"I can see my propeerty added as a Rental Property")]
          public void ThenICanSeeMyPropeertyAddedAsARentalProperty()
          {






          }

      */
    }
}
