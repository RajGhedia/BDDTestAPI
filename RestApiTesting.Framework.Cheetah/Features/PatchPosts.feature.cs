// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RestApiTesting.Framework.Cheetah.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PatchPostsFeature : Xunit.IClassFixture<PatchPostsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PatchPosts.feature"
#line hidden
        
        public PatchPostsFeature(PatchPostsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PatchPosts", "As a non-authenticated user,\r\nI want the ability to patch a post.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
  #line 6
    testRunner.Given("I have a client \"client1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="A non-authenticated user successfully patchs a post")]
        [Xunit.TraitAttribute("FeatureTitle", "PatchPosts")]
        [Xunit.TraitAttribute("Description", "A non-authenticated user successfully patchs a post")]
        [Xunit.TraitAttribute("Category", "AcceptanceCriteria")]
        public virtual void ANon_AuthenticatedUserSuccessfullyPatchsAPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-authenticated user successfully patchs a post", null, new string[] {
                        "AcceptanceCriteria"});
#line 9
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line 10
    testRunner.Given("I have a string \"patched body\" named \"body1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "body",
                        "body1"});
#line 11
      testRunner.And("I have a model \"patchPostsModel1\" with the following values:", ((string)(null)), table5, "And ");
#line 14
      testRunner.And("I have an int \"1\" named \"one\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
      testRunner.And("I have a string \"sunt aut facere repellat provident occaecati excepturi optio rep" +
                    "rehenderit\" named \"titleActual\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
     testRunner.When("I send a \"Patch\" request to \"/posts/1\" with model \"patchPostsModel1\" using client" +
                    " \"client1\" and get the response \"patchPostsResponse1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
      testRunner.And("I get the content \"patchPostsResponse1Body\" of the response \"patchPostsResponse1\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
     testRunner.Then("the response \"patchPostsResponse1\" should have the status code \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "userId",
                        "one"});
            table6.AddRow(new string[] {
                        "id",
                        "one"});
            table6.AddRow(new string[] {
                        "title",
                        "titleActual"});
            table6.AddRow(new string[] {
                        "body",
                        "body1"});
#line 19
      testRunner.And("the model \"patchPostsResponse1Body\" should match the following values:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="A non-authenticated user attempts to patch a post with nonexistent id")]
        [Xunit.TraitAttribute("FeatureTitle", "PatchPosts")]
        [Xunit.TraitAttribute("Description", "A non-authenticated user attempts to patch a post with nonexistent id")]
        [Xunit.TraitAttribute("Category", "NegativePath")]
        public virtual void ANon_AuthenticatedUserAttemptsToPatchAPostWithNonexistentId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-authenticated user attempts to patch a post with nonexistent id", null, new string[] {
                        "NegativePath"});
#line 27
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line 28
    testRunner.Given("I have a string \"patched body\" named \"body1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "body",
                        "body1"});
#line 29
      testRunner.And("I have a model \"patchPostsModel1\" with the following values:", ((string)(null)), table7, "And ");
#line 32
     testRunner.When("I send a \"Patch\" request to \"/posts/101\" with model \"patchPostsModel1\" using clie" +
                    "nt \"client1\" and get the response \"patchPostsResponse1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
      testRunner.And("I get the content \"patchPostsResponse1Body\" of the response \"patchPostsResponse1\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
     testRunner.Then("the response \"patchPostsResponse1\" should have the status code \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "body",
                        "body1"});
#line 35
      testRunner.And("the model \"patchPostsResponse1Body\" should match the following values:", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PatchPostsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PatchPostsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion