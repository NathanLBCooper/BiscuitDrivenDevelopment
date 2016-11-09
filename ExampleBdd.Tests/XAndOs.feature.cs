﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ExampleBdd.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("XAndOs")]
    public partial class XAndOsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "XAndOs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "XAndOs", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("X wins a simple game of noughts and crosses")]
        public virtual void XWinsASimpleGameOfNoughtsAndCrosses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("X wins a simple game of noughts and crosses", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        "..",
                        ".."});
            table1.AddRow(new string[] {
                        "X",
                        "O",
                        "O"});
            table1.AddRow(new string[] {
                        ".",
                        "X",
                        "O"});
            table1.AddRow(new string[] {
                        ".",
                        ".",
                        "X"});
#line 4
 testRunner.When("The board looks like this:", ((string)(null)), table1, "When ");
#line 9
 testRunner.Then("Player X has won", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("O wins a simple game of noughts and crosses")]
        public virtual void OWinsASimpleGameOfNoughtsAndCrosses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("O wins a simple game of noughts and crosses", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        "..",
                        ".."});
            table2.AddRow(new string[] {
                        "X",
                        "O",
                        "O"});
            table2.AddRow(new string[] {
                        "X",
                        "O",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        "O",
                        "X"});
#line 12
 testRunner.When("The board looks like this:", ((string)(null)), table2, "When ");
#line 17
 testRunner.Then("Player O has won", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tests that reveals how rubbish my implementation is")]
        public virtual void TestsThatRevealsHowRubbishMyImplementationIs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tests that reveals how rubbish my implementation is", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        "..",
                        ".."});
            table3.AddRow(new string[] {
                        "X",
                        "O",
                        "X"});
            table3.AddRow(new string[] {
                        ".",
                        "O",
                        "."});
            table3.AddRow(new string[] {
                        "X",
                        "O",
                        "X"});
#line 20
 testRunner.When("The board looks like this:", ((string)(null)), table3, "When ");
#line 25
 testRunner.Then("Player O has won", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion