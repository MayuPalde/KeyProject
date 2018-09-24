using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
   public  class RequestDetailsPage
    {

        private readonly IWebDriver _driver;


        public RequestDetailsPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }



        [FindsBy(How = How.LinkText, Using = "Back To Previous")]
        protected IWebElement BackToPrevious { get; set; }


        public void ClickOnBackToPreviousLink()
        {


            BackToPrevious.Click();

        }









    }
}
