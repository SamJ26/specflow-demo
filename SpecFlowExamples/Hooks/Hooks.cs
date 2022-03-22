// Uncomment this line to use hooks
#define USE_HOOKS

#if USE_HOOKS

using TechTalk.SpecFlow.Infrastructure;

namespace SpecFlowExamples.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ISpecFlowOutputHelper outputHelper;

        // Using constructor dependency injection to receive ISpecFlowOutputHelper service
        public Hooks(ISpecFlowOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        // This method must be statis!!
        [BeforeTestRun]
        public static void BeforeTestRunLogic() { /* Code */ }

        // This method must be static!!
        [BeforeFeature]
        public static void BeforeFeatureLogic(FeatureContext featureContext)
        {
            var info = featureContext.FeatureInfo;
        }

        [BeforeScenario]
        public void BeforeScenarioLogic(ScenarioContext scenarioContext)
        {
            var info = scenarioContext.ScenarioInfo;
        }

        [BeforeStep]
        public void BeforeStepLogic() { /* Code */ }

        [AfterStep]
        public void AfterStepLogic() { /* Code */ }

        [AfterScenario]
        public void AfterScenarioLogic(ScenarioContext scenarioContext)
        {
            var into = scenarioContext.ScenarioInfo;
        }

        // This method must be static!!
        [AfterFeature]
        public static void AfterFeatureLogic(FeatureContext featureContext)
        {
            var info = featureContext.FeatureInfo;
        }

        // This method must be static!!
        [AfterTestRun]
        public static void AfterTestRunLogic() { /* Code */ }
    }
}
#endif
