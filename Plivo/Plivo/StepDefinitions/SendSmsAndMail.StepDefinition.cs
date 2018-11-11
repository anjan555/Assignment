using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using PlivoPages.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Plivo.StepDefinitions
{
    [Binding]
    public sealed class SendSmsAndMail
    {
        private LandingPage _LandingPage;
        private CanvasPage _CanvasPage;
        public SendSmsAndMail()
        {
            _LandingPage = new LandingPage();
            _CanvasPage = new CanvasPage();
        }

        [Given(@"I have a valid url to launch the application\.")]
        public void GivenIHaveAValidUrlToLaunchTheApplication_()
        {
           var IscorrectPage = _LandingPage.VerifyLandingPage();

            if(!IscorrectPage)
            {
                Assert.Fail("This is not the intended page");
            }
        }

        [Then(@"I will create an App\.")]
        public void ThenIWillCreateAnApp_()
        {
            _LandingPage.CreateApp();
        }

        [Then(@"I select Get started to start building an App\.")]
        public void ThenISelectGetStartedToStartBuildingAnApp_()
        {
            _LandingPage.StartCreatingApp();
        }

        [Then(@"I will create new page by giving the name ""(.*)""\.")]
        public void ThenIWillCreateNewPageByGivingTheName_(string AppName)
        {
            _LandingPage.AddNewPage(AppName);
        }

        [Then(@"I Select Messaging Menu\.")]
        public void ThenISelectMessagingMenu_()
        {
            _LandingPage.SelectMessagingMenu();
        }

        [Then(@"I drag drop the ""(.*)"" component")]
        public void ThenIDragDropTheComponent(string ToDrop)
        {
            _LandingPage.DragDropComponent(ToDrop);
        }


        private class SmsDetails
        {
            public string PhoneNumber { get; set; }
            public string Message { get; set; }
        }

        [Then(@"I enter the following details to the SMS Component")]
        public void ThenIEnterTheFollowingDetailsToTheSMSComponent(Table Sms_table)
        {
            var SmsTabledetails = Sms_table.CreateSet<SmsDetails>();

            foreach (SmsDetails details in SmsTabledetails)
            {
                _CanvasPage.FillSmsDetails(details.PhoneNumber, details.Message);
            }
            
        }

        [Then(@"I connect the components start and SMS\.")]
        public void ThenIConnectTheComponentsStartAndSMS_()
        {
            _CanvasPage.ConnectNodes();
        }

        [Then(@"I Adjust space on Canvas\.")]
        public void ThenIAdjustSpaceOnCanvas_()
        {
            _CanvasPage.AdjustComponent();
        }


        private class MailDetails
        {
            public string SmtpHost { get; set; }
            public string port { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public string Subject { get; set; }
            public string cc { get; set; }
            public string Message { get; set; }
           
        }

        [Then(@"I enter the following details to the Mail Component")]
        public void ThenIEnterTheFollowingDetailsToTheMailComponent(Table Mail_Table)
        {
            var maildetails = Mail_Table.CreateSet<MailDetails>();

            foreach (MailDetails mail in maildetails)
            {
              _CanvasPage.FillMailDetails(mail.SmtpHost, mail.port, mail.UserName, mail.Password, mail.From, mail.To, mail.Subject, mail.cc, mail.Message);
            }
            
        }

        [Then(@"I connect Sms and Email components\.")]
        public void ThenIConnectSmsAndEmailComponents_()
        {
            _CanvasPage.ConnectSmsAndMailComponent();
        }

        [Then(@"I select basic menu\.")]
        public void ThenISelectBasicMenu_()
        {
            _LandingPage.SelectBasicMenu();
        }

        [Then(@"I adjust exit apps on canvas\.")]
        public void ThenIAdjustExitAppsOnCanvas_()
        {
            _CanvasPage.AdjustSpaceOncanvas();
        }

        [Then(@"I connect it with Mail and SMS components\.")]
        public void ThenIConnectItWithMailAndSMSComponents_()
        {
            _CanvasPage.ConectExitAppWithMailAndSmsComponent();
            Thread.Sleep(1000);
        }


    }
}
