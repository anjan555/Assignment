using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Plivo.SeleniumCore;
using TechTalk.SpecFlow;
using Plivo.SeleniumCore.Utilities;
using Plivo.SeleniumCore.Helpers;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace Plivo
{
    [Binding]
    class TestInitialization
    {

        private string _browser;
        
        
        private static string _url;
        private string _scenarioTitle;

        private static ExtentTest featureName;
        private static ExtentTest scenarioName;
        private static ExtentReports extent;
        private static KlovReporter klov;


        [BeforeTestRun]

        public static void InitializeReport()
        {
            var ReportFolderPath = Helper.CreateFolder("ExtentReports");
            var htmlreporter = new ExtentHtmlReporter(ReportFolderPath+@"\ExtentReport.html");
            htmlreporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();

            #region Klov reporting 
            // For Kolov report - Historical data uncomment the following lines.

            //klov = new KlovReporter();
            //klov.InitMongoDbConnection("localhost", 27017);
            //klov.ProjectName="Plivo";
            //klov.KlovUrl = "http://localhost";
            //klov.ReportName = "PlivoExecution" + DateTime.Now.ToString("yyyyMMddhhmmss");

            //extent.AttachReporter(htmlreporter,klov);
            #endregion
            extent.AttachReporter(htmlreporter);

        }

        [AfterTestRun]
        public static void ExtentFlush()
        {
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [BeforeScenario]

        public void Initialize()
        {
            _browser = ConfigurationManager.AppSettings["Browser"];
            _url = ConfigurationManager.AppSettings["Url"];
            
            Driver.SelectBrowser(_browser,_url);
            scenarioName = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            _scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
        }

        [AfterStep]
        
        public void InserReportSteps()
        {
            
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }

            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "When")
                    scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "Then")
                    scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "And")
                    scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);

            }
        }
      
        [AfterScenario]
        public void CloseBrowser()
        {
            try
            {
                if (ScenarioContext.Current.TestError != null || ExceptionHandler.CurrentException != null)
                {
                    WebDriverUtilities.CaptureScreenShot(_scenarioTitle);
                }
            }
            catch (Exception e)
            {
                WebDriverUtilities.CaptureScreenShot(_scenarioTitle);
            }

            Driver.CloseBrowser();
        }
    }
}

