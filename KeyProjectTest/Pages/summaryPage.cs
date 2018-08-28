using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    public  class SummaryPage
    {


        private IWebDriver _driver;


        public SummaryPage(IWebDriver driver)
        {

            _driver = driver;
            PageFactory.InitElements(_driver, this);


        }



        [FindsBy(How = How.XPath, Using = "//button[@class='ui teal button' and contains(., 'Submit')]")]
        protected IWebElement SubmitButton { get; set; }


        public void ClickOnSubmitButton()
        {

            SubmitButton.Click();

        }






    }
}














