using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
  public class SendRequestPage
    {


        private IWebDriver _driver;


        public SendRequestPage(IWebDriver driver)

        {

            _driver = driver;
            PageFactory.InitElements(_driver, this);


        }



        [FindsBy(How = How.XPath, Using = "//input[@type='text']")]
        protected IWebElement DuedateTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//textarea[@rows='10'][@data-bind='textinput : RequestMessage']")]
        protected IWebElement DescriptionTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='ui teal button' and contains(., 'Save')]")]
        protected IWebElement SaveButton { get; set; }



        [FindsBy(How = How.Id, Using ="file-upload")]
        protected IWebElement ImageUpload { get; set; }




        public void EnterDueDate()
        {

            DuedateTextBox.SendKeys("10/12/2018");

        }


        public void EnterRequestInfo()
        {

            DescriptionTextBox.SendKeys("Please be advised that we have arranged an open for inspection.the inspection details are below.Date : 05/10/2018");


        }




        public void ClickOnSaveButtton()
        {


            SaveButton.Click();

        }

        public void UploadImage()
        {

            ImageUpload.SendKeys("C:\\Users\\Mayuri\\Desktop\\KeyProject\\RoutineInspectionTemplate.png");


        }


       












    }
}
