using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    public  class LoginPage
    {




        private readonly IWebDriver _driver;


        public LoginPage(IWebDriver driver)
        {

            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }



        [FindsBy(How = How.Id , Using = "UserName")]
        protected IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        protected IWebElement PasswordTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[1]/div[4]/button")]
        protected IWebElement LoginButton { get; set; }



        public void LoginAs(string username , string password)
        {


            UserNameTextBox.SendKeys(username);

            PasswordTextBox.SendKeys(password);

            LoginButton.Click();
            



        }

        











    }
}





