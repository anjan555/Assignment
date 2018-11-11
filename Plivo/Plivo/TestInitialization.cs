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

namespace Plivo
{
    [Binding]
    class TestInitialization
    {

        private string _browser;
        private IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;
        private string _dayFolderName;
        private static string _url;

        [BeforeScenario]

        public void Initialize()
        {
            _browser = ConfigurationManager.AppSettings["Browser"];
            _url = ConfigurationManager.AppSettings["Url"];

            Driver.SelectBrowser(_browser,_url);
          
        }

       
        [AfterScenario]
        public void CloseBrowser()
        {
            try
            {
                if (_scenarioContext.TestError != null || ExceptionHandler.CurrentException != null)
                {
                    _dayFolderName = "PlivoTestResult" + DateTime.Now.ToString("d").Replace("/", "");
                    var errorDirectoryName = _scenarioContext["Results"] + _dayFolderName;
                    var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                    Directory.CreateDirectory(errorDirectoryName);
                    screenshot.SaveAsFile(errorDirectoryName + "/" + _scenarioContext.ScenarioInfo.Title + ".Png", ScreenshotImageFormat.Png);
                }
            }
            catch (Exception)
            {
                //ignore
            }

            Driver.CloseBrowser();
        }
    }
}

