using TechTalk.SpecFlow;
using AutomationFramework.Base;
using AutomationFramework.Helpers;

namespace GitHubUIAssignment.Hooks
{
    [Binding]
    class HookInitialize : TestInitializeHook
    {
        [BeforeScenario]
        public void TestStart()
        {
            InitializeSettings();            
        }

        [AfterStep]
        public void Takescreenshot()
        {
            Screenshots.MakeScreenshotAfterStep();
            LogHelpers.Write("Captured screen shot"); 
        }

        [AfterScenario]
        public void TestStop()
        {
            DriverContext.Driver.Quit();
            LogHelpers.Write("Driver object cleared");
        }


    }
}
