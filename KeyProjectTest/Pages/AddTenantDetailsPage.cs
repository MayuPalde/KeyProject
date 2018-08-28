using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    public class AddTenantDetailsPage
    {


        private IWebDriver _driver;


        public AddTenantDetailsPage(IWebDriver driver)
        {

            _driver = driver;
            PageFactory.InitElements(_driver, this);


        }



        [FindsBy(How = How.XPath, Using = "//input[@name='Email'][@type='text']")]
        protected IWebElement TenantEmailTextBox { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@text='First Name'][@type='text']")]
        protected IWebElement FirstNameTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@text='Last Name'][@type='text']")]
        protected IWebElement LastNameTextBox { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@name='StartDate'][@placeholder='Rent Start Date']")]
        protected IWebElement RentStartDate { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@name='EndDate'][@placeholder='Rent End Date']")]
        protected IWebElement RentEndDate { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//input[@name='RentAmount'][@type='text']")]
        protected IWebElement RentAmountTextBox { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Payment Start Date'][@type='text']")]
        protected IWebElement PaymentStartDate { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[]")]
        protected IWebElement PaymentDueDate { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@type='button'][@value='Next'] ")]
        protected IWebElement ButtonNext { get; set; }




        public void EnterEmailId()
        {

            TenantEmailTextBox.SendKeys("abc@gmail.com");

        }

       


        public void EnterFirstName()
        {
            FirstNameTextBox.SendKeys("Radha");

        }

        public void EnterLastName()
        {
            LastNameTextBox.SendKeys("Patil");

        }

        public void EnterStartDate()
        {


            RentStartDate.SendKeys("01/08/2018");

        }


        public void EnterEnddate()
        {

           

            RentEndDate.SendKeys("01/12/2018");


        }

        public void RentAmount()
        {


            RentAmountTextBox.SendKeys("400");

        }


        public void EnterpaymentStartDate()
        {

            PaymentStartDate.SendKeys("05/09/2018");
        }


        public void EnterPaymentDueDate()
        {

            PaymentDueDate.SendKeys("2");

        }


        public void ClickOnNext()
        {

            ButtonNext.Click();

        }







    }
}





































    
