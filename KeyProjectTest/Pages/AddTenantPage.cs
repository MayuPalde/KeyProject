using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyProjectTest.Pages
{
    class AddTenantPage
    {


        private readonly IWebDriver _driver;

        public AddTenantPage(IWebDriver driver)
        {
            _driver = driver;

            PageFactory.InitElements(_driver, this);


        }








    }
}
