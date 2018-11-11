using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Plivo.SeleniumCore;

namespace Plivo.SeleniumCore.Utilities
{
    public static class WebDriverUtilities
    {
        
        public static object ExpectedConditions { get; private set; }

        public static void WaitUntillElementWith_Id_Present(IWebDriver driver, string id)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 3, 0));
            wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(By.Id(id));
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }



        public static void WaitUntillElementWith_XPath_Present(IWebDriver driver, string xpath)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 3, 0));
            wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(By.XPath(xpath));
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

        }
    }
}

