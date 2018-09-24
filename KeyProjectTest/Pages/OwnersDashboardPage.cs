using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    class OwnersDashboardPage
    {


        private readonly IWebDriver _driver;

        
        public OwnersDashboardPage(IWebDriver driver)
        {
           

             _driver = driver;

              PageFactory.InitElements(_driver, this);

        }
        
        

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        protected IWebElement SkipButton { get; set; }




        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        protected IWebElement OwnersLink { get; set; }



        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners/Property/MyRequests']")]
        protected IWebElement MyRequestLink { get; set; }


        public void ClickOnSkip()
        {

            SkipButton.Click();

        }
        public void ClickOnOwner()
        {


        // _Wait.Until(condition: ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/div[2]/div[1]")));


           OwnersLink.Click();

        }


        public void ClickOnMyRequestLink()
        {

            MyRequestLink.Click();


        }

        


    }
}
