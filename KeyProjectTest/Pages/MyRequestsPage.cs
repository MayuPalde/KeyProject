using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    public class MyRequestsPage
    {



        private readonly IWebDriver _driver;


        public MyRequestsPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }
        //button[@type, 'submit' and text()='New']
        //button[@class='ui teal button' and contains(., 'Save')]


        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage]/div[2]/div/div[2]/a")]
        protected IWebElement AddNewRequestButton { get; set; }




        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[4]/button[1]")]
        protected IWebElement EditButton { get; set; }




        [FindsBy(How = How.XPath, Using = "//button[@class='ui teal mini basic button']")]
        protected IWebElement DeatilsButton { get; set; }



        [FindsBy(How = How.XPath, Using = "//button[@class='ui basic mini orange button']")]
        protected IWebElement DeleteButton { get; set; }


        [FindsBy(How = How.LinkText, Using = "Accepted")]
        protected IWebElement AcceptedRequestLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Declined")]
        protected IWebElement DeclinedRequestLink { get; set; }



        public void ClickOnAddNewrequest()
        {


            AddNewRequestButton.Click();

        }

        public void ClickOnEditButton()
        {
            EditButton.Click();
        }

        public void ClickOnDetailsButton()
        {
            DeatilsButton.Click();


        }

        public void ClickOnDeleteButton()
        {

            DeleteButton.Click();

        }


        public void ClickOnAcceptedrequestLink()
        {
            AcceptedRequestLink.Click();

        }

        public void ClickOnDeclinedRequestLink()
        {


            DeclinedRequestLink.Click();
        }











    }
}
