using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
   public  class DeleteRequestPage
    {

        private readonly IWebDriver _driver;


        public DeleteRequestPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }




        [FindsBy(How = How.XPath, Using = "//button[@type='button'][@class='ui teal basic button']")]
        protected IWebElement ConfirmButton { get; set; }

        public void ClickOnConfirm()
        {

            ConfirmButton.Click();

        }

        public void takescreenshot()
        {


           Screenshot screen = ((ITakesScreenshot)_driver).GetScreenshot();

            screen.SaveAsFile(@"C:\Users\Mayuri\Desktop\Visual studio Program\Key_Seperate_Module\KeyProject\Screenshot\Delete Request\DeleteRequest.jpg");


        }





    }
}
