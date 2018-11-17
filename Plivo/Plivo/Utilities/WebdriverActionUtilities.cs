using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plivo.SeleniumCore.Utilities
{
    public static class WebdriverActionUtilities
    {
        public static void MouseHover(IWebDriver driver, string actionXpath)
        {
            var act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath(actionXpath)));
            act.Perform();
        }

        public static void DoubleClick(IWebDriver driver, string actionXpath)
        {
            var act = new Actions(driver);
            act.DoubleClick(driver.FindElement(By.XPath(actionXpath)));
            act.Perform();
        }

        public static void DoubleClick(IWebDriver driver, IWebElement actionXpath)
        {
            var act = new Actions(driver);
            act.DoubleClick(actionXpath);
            act.Perform();
        }

        public static void DragAndDrop(IWebDriver driver, string sourcePath, string destinationPath)
        {
            var act = new Actions(driver);
            act.DragAndDrop(driver.FindElement(By.XPath(sourcePath)), driver.FindElement(By.XPath(destinationPath)));
            act.Perform();
        }

        public static void DragAndDrop(IWebDriver driver, IWebElement sourceElement, IWebElement destinationElement)
        {
            var act = new Actions(driver);
            act.DragAndDrop(sourceElement, destinationElement);
            act.Perform();
        }

        public static void DragDropWithOffset(IWebDriver driver, string sourcePath, int offsetX,int offsetY)
        {
            var act = new Actions(driver);
            act.DragAndDropToOffset(driver.FindElement(By.XPath(sourcePath)),offsetX,offsetY);
            act.Perform();
        }

        public static void DragDropWithOffset(IWebDriver driver, IWebElement SourceElement, int offsetX, int offsetY)
        {
            var act = new Actions(driver);
            act.DragAndDropToOffset(SourceElement, offsetX, offsetY);
            act.Perform();
        }
    }
}
