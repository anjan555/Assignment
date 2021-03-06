﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Plivo.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SendSmsAndMail", Description="\tThis featue is for configuring SMS and mail components.", SourceFile="Features\\SendSmsAndMail.feature", SourceLine=0)]
    public partial class SendSmsAndMailFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SendSmsAndMail.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SendSmsAndMail", "\tThis featue is for configuring SMS and mail components.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify that SMS and Mail apps are connected to eachother.", new string[] {
                "UI",
                "Sanity"}, SourceLine=6)]
        public virtual void VerifyThatSMSAndMailAppsAreConnectedToEachother_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that SMS and Mail apps are connected to eachother.", null, new string[] {
                        "UI",
                        "Sanity"});
#line 7
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
    testRunner.Given("I have a valid url to launch the application.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
     testRunner.Then("I will create an App.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
      testRunner.And("I select Get started to start building an App.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
     testRunner.Then("I will create new page by giving the name \"TestApp\".", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
  testRunner.Then("I Select Messaging Menu.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
      testRunner.And("I drag drop the \"Send an SMS\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PhoneNumber",
                        "Message"});
            table1.AddRow(new string[] {
                        "123456789",
                        "Hello Plivo"});
#line 15
     testRunner.Then("I enter the following details to the SMS Component", ((string)(null)), table1, "Then ");
#line 18
      testRunner.And("I connect the components start and SMS.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
     testRunner.Then("I drag drop the \"Send an Email\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
   testRunner.And("I Adjust space on Canvas.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SmtpHost",
                        "Port",
                        "UserName",
                        "Password",
                        "From",
                        "To",
                        "Subject",
                        "cc",
                        "Message"});
            table2.AddRow(new string[] {
                        "http:/gmail.com",
                        "645",
                        "anjan555@gmail.com",
                        "abc@123",
                        "anjan555@gmail.com",
                        "xyz@gmail.com",
                        "Plivo!!",
                        "anjan@gmail.com",
                        "Plivo"});
#line 21
  testRunner.Then("I enter the following details to the Mail Component", ((string)(null)), table2, "Then ");
#line 24
     testRunner.Then("I connect Sms and Email components.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
  testRunner.Then("I select basic menu.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
   testRunner.And("I drag drop the \"Hang Up or Exit\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
   testRunner.And("I drag drop the \"Hang Up or Exit\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
   testRunner.And("I drag drop the \"Hang Up or Exit\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
     testRunner.Then("I adjust exit apps on canvas.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
     testRunner.Then("I connect it with Mail and SMS components.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
   testRunner.And("I Verify that all thecomponents are on canvas.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Sms and Mail Components", new string[] {
                "UI",
                "Sanity"}, SourceLine=33)]
        public virtual void AddSmsAndMailComponents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Sms and Mail Components", null, new string[] {
                        "UI",
                        "Sanity"});
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given("I have a valid url to launch the application.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
     testRunner.Then("I will create an App.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
      testRunner.And("I select Get started to start building an App.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
     testRunner.Then("I will create new page by giving the name \"TestApp\".", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
  testRunner.Then("I Select Messaging Menu.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
      testRunner.And("I drag drop the \"Send an SMS\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "PhoneNumber",
                        "Message"});
            table3.AddRow(new string[] {
                        "123456789",
                        "Hello Plivo"});
#line 42
     testRunner.Then("I enter the following details to the SMS Component", ((string)(null)), table3, "Then ");
#line 45
      testRunner.And("I connect the components start and SMS.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
     testRunner.Then("I drag drop the \"Send an Email\" component", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
   testRunner.And("I Adjust space on Canvas.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
