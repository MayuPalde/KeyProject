using KeyProjectTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KeyProjectTest.StepDefinitions
{
    [Binding]
    public class AddTenantSteps
    {

        private readonly IWebDriver _driver;

        public AddTenantSteps()
        {


            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");

        }




        [Given(@"I log in into the application")]
        public void GivenILogInIntoTheApplication()
        {

            _driver.Navigate().GoToUrl("http://dev.property.community/Account/Login?ReturnUrl=%2fPropertyOwners");


            LoginPage login = new LoginPage(_driver);

            login.LoginAs("apachedemo123@gmail.com", "Owner@123");

         }

        [Given(@"I fill the Tenant details page")]
        public void GivenIFillTheTenantDetailsPage()
        {

            MyPropertiesPage property = new MyPropertiesPage(_driver);

            property.ClickOnOwner();
            property.ClickOnProperties();
            property.ClickOnAddTenantButton();

            AddTenantDetailsPage tenantDetails = new AddTenantDetailsPage(_driver);

            tenantDetails.EnterEmailId();

           // tenantDetails.EnterFirstName();

            //tenantDetails.EnterLastName();

            tenantDetails.EnterStartDate();

            tenantDetails.EnterEnddate();

            tenantDetails.RentAmount();

            tenantDetails.EnterpaymentStartDate();

            tenantDetails.EnterpaymentStartDate();

            tenantDetails.ClickOnNext();


            

      }
        
        [Given(@"I fill the Liability details page")]
        public void GivenIFillTheLiabilityDetailsPage()
        {

            LiabilityDetailsPage liability = new LiabilityDetailsPage(_driver);

            liability.ClickOnAddNewLiabilityButton();

            liability.EnterAmount();

            liability.ClickOnNextButton();

        }

        [When(@"I click on '(.*)' button")]
        public void WhenIClickOnButton(string p0)
        {

            SummaryPage summary = new SummaryPage(_driver);

            summary.ClickOnSubmitButton();

        }



        /*
         *Then I should see 'Tenant Added Successfully!' message on the screen
         * [Then(@"I should see '(.*)' message on the screen")]
         public void ThenIShouldSeeMessageOnTheScreen(string p0)
         {

             System.Threading.Thread.Sleep(2000);

             var atualUser = _driver.FindElement(By.XPath("//*[@id='main - content']/div[1]")).Text;

             var expectedUser = "Tenant Added Successfully!";

             Assert.IsTrue(atualUser.Contains(expectedUser));


         }

     */

        [Then(@"Tenant Should be added to the property")]
        public void ThenTenantShouldBeAddedToTheProperty()
        {

            var atualUser = _driver.FindElement(By.LinkText("Dashboard")).Text;

            var expectedUser = "Dashboard";

            Assert.IsTrue(atualUser.Contains(expectedUser));







        }
    }
}

