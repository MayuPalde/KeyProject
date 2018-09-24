using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    class DeclinedRequestPage
    {



        private readonly IWebDriver _driver;


        public DeclinedRequestPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }


        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[4]/button[2]")]
        protected IWebElement DetailsButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[4]/button[3]")]
        protected IWebElement DeleteButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[3]/div[2]/div[2]/button[1]")]
        protected IWebElement  ConfirmButton { get; set; }


        [FindsBy(How = How.LinkText, Using = "Back To Previous")]
        protected IWebElement BackToPreviousLink { get; set; }






        public void ClickOnDetailsButton()
        {
            DetailsButton.Click();
            BackToPreviousLink.Click();

        }

        public void ClickOnDeleteButton()
        {
            DeleteButton.Click();

        }

        public void ClickOnConfirmButton()
        {
            ConfirmButton.Click();
          

        }





    }
}
