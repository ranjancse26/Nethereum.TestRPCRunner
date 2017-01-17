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
namespace SpecsSample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "needsTestRPC")]
    public partial class ContractMultiplication2Feature : Xunit.IClassFixture<ContractMultiplication2Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContractMultiplication2.feature"
#line hidden
        
        public ContractMultiplication2Feature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ContractMultiplication2", "\tIn order to avoid silly mistakes\r\n\tAs a ethereum user\r\n\tI want to multiply a num" +
                    "ber", ProgrammingLanguage.CSharp, new string[] {
                        "needsTestRPC"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(ContractMultiplication2Feature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Multiplication by 7")]
        [Xunit.TraitAttribute("FeatureTitle", "ContractMultiplication2")]
        [Xunit.TraitAttribute("Description", "Multiplication by 7")]
        public virtual void MultiplicationBy7()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiplication by 7", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I have deployed a multiplication contract with multipler of 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I call multiply using 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the multiplication result should be 49", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "ContractMultiplication2")]
        [Xunit.TraitAttribute("Description", "Multiplication")]
        [Xunit.InlineDataAttribute("7", "7", "49", new string[0])]
        [Xunit.InlineDataAttribute("7", "8", "56", new string[0])]
        [Xunit.InlineDataAttribute("3", "3", "9", new string[0])]
        public virtual void Multiplication(string initialMultiplier, string multiplier, string multiplicationResult, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiplication", exampleTags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given(string.Format("I have deployed a multiplication contract with multipler of {0}", initialMultiplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When(string.Format("I call multiply using {0}", multiplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then(string.Format("the multiplication result should be {0}", multiplicationResult), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ContractMultiplication2Feature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ContractMultiplication2Feature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
