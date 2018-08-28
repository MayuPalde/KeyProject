using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KeyProjectTest.Pages
{
    public class ListRentalPropertyPage
    {



        private IWebDriver _driver;


        public ListRentalPropertyPage(IWebDriver driver)

        {

            _driver = driver;
            PageFactory.InitElements(_driver, this);


        }



        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@data-bind='textInput : Title']")]
        protected IWebElement TitleTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@data-bind='textInput : MovingCost']")]
        protected IWebElement MovingCostTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@data-bind='textInput : TargetRent']")]
        protected IWebElement   TargetRentTextBox { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@name='AvailableDate'][@type='text']")]
        protected IWebElement AvailableDateTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@data-bind='textInput : OccupantCount']")]
        protected IWebElement OccupantsCountTextBox { get; set; }



        [FindsBy(How = How.XPath, Using = "//textarea[@rows='5'][@data-bind='textInput : RentalDescription']")]
        protected IWebElement  DescriptionTextBox { get; set; }


        [FindsBy(How = How.Id, Using = "file-upload")]
        protected IWebElement ChooseFileButton { get; set; }



        [FindsBy(How = How.XPath, Using = " //button[@class='teal ui button' and contains(., 'Save')]")]
        protected IWebElement SaveButton { get; set; }

       


        public void EnterPropertyTitle()
        {

            TitleTextBox.SendKeys("450 / Week");

        }

        public void EnterMovingCost()
        {
            MovingCostTextBox.SendKeys("4000");

        }
        public void EnterTargetRent()
        {
            TargetRentTextBox.SendKeys("400");

        }


        public void EnterAvailableDate()
        {

            AvailableDateTextBox.SendKeys("09/10/2018");

        }
        public void EnterOccupantsCount()
        {
            OccupantsCountTextBox.SendKeys("4");

        }

        public void EnterPropertyDescription()
        {

            DescriptionTextBox.SendKeys("This spacious two bedroom apartment that has been renovated offers a designer kitchen & bathroom low maintenance timber floors, along with a balcony, single lock up garage and is within walking distance to local schools, shops & transport. ");

        }


        public void UploadFileAction()
        {


            ChooseFileButton.SendKeys("C:\\Users\\Mayuri\\Desktop\\KeyProject\\image.jpeg");

           // String FilePath = "C:\\Users\\Mayuri\\Desktop\\image";

            // ChooseFileButton.SendKeys(FilePath);

        }

        public void ClickOnSaveButton()
        {

            SaveButton.Click();
        }












       



























    }
}
