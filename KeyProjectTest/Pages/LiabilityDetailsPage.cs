using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
   public   class LiabilityDetailsPage
    {



        private IWebDriver _driver;


        public LiabilityDetailsPage(IWebDriver driver)
        {


            _driver = driver;
            PageFactory.InitElements(_driver, this);




        }




        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div[1]/div/a")]
        protected IWebElement AddNewLiabilityIcon { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@class='ui input full width'][@type='text']")]
        protected IWebElement AmountBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='ui teal button' and contains(., 'Next')]")]
        protected IWebElement NextButton { get; set; }



        public void ClickOnAddNewLiabilityButton()
        {


            AddNewLiabilityIcon.Click();


        }


        public void EnterAmount()
        {


            AmountBox.SendKeys("2000");


        }

        public void ClickOnNextButton()
        {


            NextButton.Click();


        }

    }
}


