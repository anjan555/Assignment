using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Plivo.SeleniumCore;
using Plivo.SeleniumCore.Utilities;
using OpenQA.Selenium.Support.PageObjects;

namespace PlivoPages.Pages
{
    public class LandingPage
    {        
        private IWebDriver _driver;
        public LandingPage() => _driver = Driver.driver;

        #region //xpath strings
        private string _startApp = "//div[@id='intro-dialog-cont']//button[contains(text(),'started!')]";
        private string _NewPageXpath = "//input[@name='name' and @type='text' and @class='indented submitonenter']";
        private string _smsnode = "//div[@id='tabs-2']//div[@class='mod-rail mod-north']/div[@class='syn-receptor ui-droppable syn-receptor-north ui-draggable syn-receptor-draggable']";
        #endregion

        #region //Page Elements
        private IWebElement btn => _driver.FindElement(By.Name(""));
        private IWebElement CreateAppBtn => _driver.FindElement(By.Id("link-create"));
        private IWebElement StartAppBtn => _driver.FindElement(By.XPath(_startApp));
        private IWebElement AddNewPageBtn => _driver.FindElement(By.Id("add-page"));
        private IWebElement NewPageTxt => _driver.FindElement(By.XPath("//input[@name='name' and @type='text' and @class='indented submitonenter']"));
        private IWebElement CreateNewAppBtn => _driver.FindElement(By.XPath("//div/span[text()='New Page']/../..//div/button[text()='Create']"));
        private IWebElement MessagingMenu => _driver.FindElement(By.XPath("//a[contains(text(),'Messaging')]"));
        private IWebElement BasicMenu => _driver.FindElement(By.XPath("//a[contains(text(),'Basic')]"));
        #endregion

        #region //Page Actions
        public bool VerifyLandingPage()
        {
            return WebElementUtilities.checkIfElementExists(_driver, "link-create");
        }

        public void CreateApp()
        {
            CreateAppBtn.Click();
            WebDriverUtilities.WaitUntillElementWith_XPath_Present(_driver, _startApp);
        }

        public void StartCreatingApp()
        {
            StartAppBtn.Click();
        }

        public void AddNewPage(string Appname)
        {
            AddNewPageBtn.Click();
            WebDriverUtilities.WaitUntillElementWith_XPath_Present(_driver, _NewPageXpath);
            NewPageTxt.SendKeys(Appname);
            CreateNewAppBtn.Click();
        }

        public void SelectMessagingMenu()
        {
            MessagingMenu.Click();
        }

        public void SelectBasicMenu()
        {
            BasicMenu.Click();
        }
        public void DragDropComponent(string ToDrop)
        {
            
            SelectComponentfromMenu(ToDrop);
            WebDriverUtilities.WaitUntillElementWith_XPath_Present(_driver, _smsnode);
        }

        private void SelectComponentfromMenu(string ToDrop)
        {
            var allelements = Driver.driver.FindElements(By.XPath("//li"));

            foreach (var item in allelements)
            {
                if (item.Text.Contains(ToDrop))
                {

                    item.FindElement(By.TagName("a")).Click();
                    break;
                }

            }
        }
        #endregion
    }
}
