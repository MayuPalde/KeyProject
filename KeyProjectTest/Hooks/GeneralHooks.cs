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


        //Global Variable for Extent report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


       




        private IWebDriver _driver;



        [BeforeTestRun]
        public static void InitializeReport()
        {

            //Initialize Extent report before test starts
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Mayuri\Desktop\KeyProject\TestResults\ExtentReport.html");

            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);




        }



        [AfterTestRun]
        public static void TearDownReport()

        {
           
            //Flush report once test completes
            extent.Flush();


        }



        [BeforeFeature]

        public static void BeforeFeature()
        {
           
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

          

        }

         


        [AfterStep]

        public void InsertReportingSteps()
        {



            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();


          // all step definition  cover


            if (ScenarioContext.Current.TestError == null)

            {

                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }

            else if (ScenarioContext.Current.TestError != null)
            {

                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);


            }






        }

        [BeforeScenario]

        public void RunBeforeScenario()
        {


            _driver = new ChromeDriver();

            //Create dynamic scenario name
        



            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            _driver.Manage().Window.Maximize();

            ScenarioContext.Current.Add("currentDriver", _driver);

            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);



        }


      [AfterScenario]
      public void RunAfterScenario()
        {


            _driver.Quit();


        }






    }
}
