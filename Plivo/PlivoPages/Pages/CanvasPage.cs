using System;
using System.Collections.Generic;
using System.Text;
using Plivo.SeleniumCore;
using Plivo.SeleniumCore.Utilities;
using OpenQA.Selenium;
using System.Threading;

namespace PlivoPages.Pages
{
    public class CanvasPage
    {
        private IWebDriver _driver;
        public CanvasPage() => _driver = Driver.driver;

        #region //Xpath Strings
        private string _StartNodeXpath = "//div[@id='tabs-2']//div[@class='mod-rail mod-south']/div[@class='syn-node ui-draggable syn-node-active']";
        private string _SmsNodeXpath = "//div[@id='tabs-2']//div[@class='mod-rail mod-north']/div[@class='syn-receptor ui-droppable syn-receptor-north ui-draggable syn-receptor-draggable']";
        private string _mailComponentXpath = "//div[@class='module-title' and contains(text(),'Send an Email')]";
        private string _SmsNotSentEastNode = "//div[text()='Send an SMS']/../../../..//div[text()='Not sent']/../div[2]";
        private string _MailNorthNode = "//div[@class='module-title' and contains(text(),'Send an Email')]/../../../../div[@class='mod-rail mod-north']/div[1]";
        #endregion

        #region //Page Elements
        public IWebElement StartNode => _driver.FindElement(By.XPath("//div[@id='tabs-2']//div[@class='mod-rail mod-south']/div[@class='syn-node ui-draggable syn-node-active']"));
        public IWebElement SmsNode => _driver.FindElement(By.XPath("//div[@id='tabs-2']//div[@class='mod-rail mod-north']/div[@class='syn-receptor ui-droppable syn-receptor-north ui-draggable syn-receptor-draggable']"));
        public IWebElement PhoneNumberTxt => _driver.FindElement(By.XPath("//textarea[@name='phone_constant']"));
        public IList<IWebElement> MessageTxt => _driver.FindElements(By.XPath("//div[contains(text(),'Phone number:')]/../../..//textarea[@name='message_phrase[]']"));

        public IWebElement Smtptxt => _driver.FindElement(By.XPath("//input[@name='smtp_url']"));
        public IWebElement PortTxt => _driver.FindElement(By.XPath("//input[@name='port']"));
        public IWebElement UserNameTxt => _driver.FindElement(By.XPath("//div[@class='panel-subsection']/div[contains(text(),'Username')]/..//input[@name='username']"));
        public IWebElement PasswordTxt => _driver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement ToTxt => _driver.FindElement(By.XPath("//textarea[@name='to_constant']"));
        public IWebElement FromTxt => _driver.FindElement(By.XPath("//textarea[@name='from_constant']"));
        public IWebElement SubjectTxt => _driver.FindElement(By.XPath("//textarea[@name='subject_constant']"));
        public IWebElement CcTxt => _driver.FindElement(By.XPath("//textarea[@name='cc_constant']"));
        public IList<IWebElement> MailMessageTxt => _driver.FindElements(By.XPath("//div[contains(text(),'Cc:')]/../../..//textarea[@name='message_phrase[]']"));
        public IList<IWebElement> ExitAppList => _driver.FindElements(By.XPath("//div[@class='module-title' and contains(text(),'Exit')]"));
        public IList<IWebElement> ExitAppNodesList => _driver.FindElements(By.XPath("//div[text()='Exit App']/../../../..//div[@class='syn-receptor ui-droppable syn-receptor-north ui-draggable syn-receptor-draggable']"));
        public IWebElement SmsSentNode => _driver.FindElement(By.XPath("//div[text()='Send an SMS']/../../../..//div[text()='Sent']/../div[1]"));
        public IWebElement EmailSent => _driver.FindElement(By.XPath("//div[text()='Send an Email']/../../../..//div[text()='Sent']/../div[1]"));
        public IWebElement EmailnotSent => _driver.FindElement(By.XPath("//div[text()='Send an Email']/../../../..//div[text()='Not sent']/../div[2]"));
        public IWebElement SmsComponent => _driver.FindElement(By.XPath("//div[contains(text(),'Send an SMS')]"));
        public IWebElement MailComponent => _driver.FindElement(By.XPath("//div[contains(text(),'Send an Email')]"));
        #endregion

        #region //Page Actions
        public void FillSmsDetails(string PhoneNumber,string Message)
        {
            PhoneNumberTxt.SendKeys(PhoneNumber);
            MessageTxt[0].SendKeys(Message);
        }

        public void ConnectNodes()
        {
            WebdriverActionUtilities.DragAndDrop(_driver, _StartNodeXpath, _SmsNodeXpath);
        }

        public void AdjustComponent()
        {
            WebDriverUtilities.WaitUntillElementWith_XPath_Present(_driver, _mailComponentXpath);
            Thread.Sleep(500);
            WebdriverActionUtilities.DragDropWithOffset(_driver, _mailComponentXpath, 250, 100);
        }

        public void FillMailDetails(string smtp,string port, string username, string Password, string to, string from, string subject, string Cc,string msg)
        {
            Smtptxt.SendKeys(smtp);
            PortTxt.SendKeys(port);
            UserNameTxt.SendKeys(username);
            PasswordTxt.SendKeys(Password);
            ToTxt.SendKeys(to);
            FromTxt.SendKeys(from);
            SubjectTxt.SendKeys(subject);
            CcTxt.SendKeys(Cc);
            MailMessageTxt[0].SendKeys(msg);


        }

        public void ConnectSmsAndMailComponent()
        {
            WebDriverUtilities.WaitUntillElementWith_XPath_Present(_driver, _SmsNotSentEastNode);
            WebDriverUtilities.WaitUntillElementWith_XPath_Present(_driver, _mailComponentXpath);

            WebdriverActionUtilities.DragAndDrop(_driver, _SmsNotSentEastNode, _MailNorthNode);
        }

        public void AdjustSpaceOncanvas()
        {
            Thread.Sleep(2000);
            WebdriverActionUtilities.DragDropWithOffset(_driver, ExitAppList[0],-250,150);
            
            WebdriverActionUtilities.DragDropWithOffset(_driver, ExitAppList[1],-150,250);
            
            WebdriverActionUtilities.DragDropWithOffset(_driver, ExitAppList[2],425,275);

        }

        public void ConectExitAppWithMailAndSmsComponent()
        {
            Thread.Sleep(1000);
            WebdriverActionUtilities.DragAndDrop(_driver, SmsSentNode, ExitAppNodesList[0]);
            WebdriverActionUtilities.DragAndDrop(_driver, EmailnotSent, ExitAppNodesList[1]);
            WebdriverActionUtilities.DragAndDrop(_driver, EmailSent, ExitAppNodesList[2]);
        }

        public bool IsSmsComponentVisible()
        {
            return WebElementUtilities.checkIfElementExists(_driver,SmsComponent);
        }

        public bool IsMailComponentVisible()
        {
            return WebElementUtilities.checkIfElementExists(_driver, MailComponent);
        }
        #endregion
    }
}
