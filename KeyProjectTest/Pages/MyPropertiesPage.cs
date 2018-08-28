using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    class MyPropertiesPage
    {


        private IWebDriver _driver;


        public MyPropertiesPage(IWebDriver driver)
        {

            _driver = driver;
            PageFactory.InitElements(_driver, this);


        }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        protected IWebElement OwnersLink { get; set; }


        [FindsBy(How = How.LinkText, Using = "Properties")]
        protected IWebElement PropertiesLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Add Tenant")]
        protected IWebElement AddtenantButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "List As Rental")]
        protected IWebElement  ListAsrentalButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Send Request")]
        protected IWebElement SendRequestButton { get; set; }





        public void ClickOnOwner()
        {

            OwnersLink.Click();

        }

        public void ClickOnProperties()
        {

            PropertiesLink.Click();
        }

        public void ClickOnAddTenantButton()
        {

            AddtenantButton.Click();

        }

        public void ClickOnListAsRentalButton()
        {

            ListAsrentalButton.Click();
        }

        public void ClickOnSendRequestButton()
        {

            SendRequestButton.Click();
        }




    }
}

