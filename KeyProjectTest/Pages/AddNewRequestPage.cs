using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace KeyProjectTest.Pages
{
    public class AddNewRequestPage
    {

        private readonly IWebDriver _driver;


        public AddNewRequestPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }




        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/div[2]/div/div[2]/a")]
        protected IWebElement AddNewRequestButton { get; set; }




         [FindsBy(How = How.CssSelector, Using = "div.ui.fluid.selection.dropdown")]
          protected IWebElement PropertyDropDown { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#main-content > div > form > fieldset > div:nth-child(1) > div.two.fields > div:nth-child(1) > div.ui.fluid.selection.dropdown.active.visible > div.menu.transition.visible > div:nth-child(1)")]
        protected IWebElement PropertyLink { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[1]/div[2]/div[1]/div[3]/input")]
        protected IWebElement DateSelector { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[1]/div[2]/div[2]/div/textarea")]
        protected IWebElement DescriptionTextBox { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#main-content > div > form > fieldset > div.column.text-center > button ")]
        protected IWebElement SaveButton { get; set; }


        public void ClickOnAddNewRequest()
        {

           AddNewRequestButton.Click();

        }

        public void SelectProperty()
        {
           

            Actions actions = new Actions(_driver);
            actions.MoveToElement(PropertyDropDown);
            actions.Click();
            actions.Build().Perform();

            System.Threading.Thread.Sleep(200);

            PropertyLink.Click();

            System.Threading.Thread.Sleep(200);


            // actions.MoveToElement(PropertyLink);
            // actions.Click();
            //  actions.Build().Perform();




            // actions.SendKeys("247A Great North Road Henderson Auckland");






        }


            public void SelectDate()
            {

            System.Threading.Thread.Sleep(2000);
                DateSelector.Clear();
                DateSelector.SendKeys("08/10/2018");


            }

            public void EnterDescription()
            {

                DescriptionTextBox.SendKeys("Inspection is scheduled on 9th sep");
            }


            public void ClickOnSaveButton()
            {

                SaveButton.Click();


            }

        public void takescreenshot()
        {

            ITakesScreenshot screenshotDriver = _driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\Mayuri\Desktop\Visual studio Program\Key_Seperate_Module\KeyProject\Screenshot\Add New Request\NewRequest.jpg"); ;
       
      
        }




        }
}

