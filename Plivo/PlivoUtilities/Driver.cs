using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.IE;

namespace Plivo.SeleniumCore
{
    public static class Driver
    {
      //  [ThreadStatic]
        public static IWebDriver driver;
          
        private static string _browser;

        private static string _url;

        private static string _dayFolderName;
        
        public static void SelectBrowser(string _browser,string _url)
        {
            
            switch (_browser)
            {
                case "chrome":
                    ChromeOptions option = new ChromeOptions();
                    driver = new ChromeDriver(option);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_url);
        }

        public static void CloseBrowser()
        {
            
            driver.Quit();
        }
    }
}
