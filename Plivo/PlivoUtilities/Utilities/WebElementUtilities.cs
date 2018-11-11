using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plivo.SeleniumCore.Utilities
{
    public static class WebElementUtilities
    {
        public static bool checkIfElementExists(this IWebDriver driverInstance, string Xpathlocator)
        {
            var ElementFound = true;
            try
            {
                var elementToBeFound = driverInstance.FindElement(By.Id(Xpathlocator));
            }
            catch (NoSuchElementException)
            {
                ElementFound = false;
            }
            return ElementFound;
        }
    }
}
