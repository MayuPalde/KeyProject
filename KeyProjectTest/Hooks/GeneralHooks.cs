
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace KeyProjectTest.Hooks
{
    [TechTalk.SpecFlow.Binding]
   public  class GeneralHooks

    {


        private static ExtentTest feature;
        private static ExtentTest scenario;
        private static ExtentReports Extent = new ExtentReports();

        private IWebDriver _driver;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Mayuri\Desktop\Visual studio Program\Key_Seperate_Module\KeyProject\TestResults\ExtentReport.html");

            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            Extent = new ExtentReports();
            Extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TeardownReport()
        {
            Extent.Flush();

        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
           
            feature = Extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);



        }
        [AfterStep]
        public static void InsertReportingSteps()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

        }



        [BeforeScenario]
        public void RunBeforeScenario()
        {


            _driver = new ChromeDriver();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            _driver.Manage().Window.Maximize();

            ScenarioContext.Current.Add("currentDriver", _driver);

           scenario = feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);




        }


      [AfterScenario]
      public void RunAfterScenario()
        {


           _driver.Quit();

        }









    }
}
