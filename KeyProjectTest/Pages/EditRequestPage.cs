using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    class EditRequestPage
    {


        private readonly IWebDriver _driver;


        public EditRequestPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }




        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[2]/div[2]/form/div[1]/div/textarea")]
        protected IWebElement DescriptionTestBox { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='main - content']/div/div[2]/div[2]/form/div[2]/div[1]/div")]
        protected IWebElement ImageUploadBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@type='button'][@class='ui basic teal button']")]
        protected IWebElement SaveButton { get; set; }



        public void EnterNewInfo()
        {


            DescriptionTestBox.Clear();

            DescriptionTestBox.SendKeys("Inspection is schedule on 20th Sep  2018");



        }

        public void ClickOnSaveButton()
        {

            SaveButton.Click();


        }

        public void takescreenshot()
        {


            Screenshot screen = ((ITakesScreenshot)_driver).GetScreenshot();

            screen.SaveAsFile(@"C:\Users\Mayuri\Desktop\Visual studio Program\Key_Seperate_Module\KeyProject\Screenshot\EditRequest\EditRequest.jpg");


        }















    }
}
