using RestSharp;
using TechTalk.SpecFlow;
using PULLRequestAPIsTestAssignment.Context;

namespace PULLRequestAPIsTestAssignment.Hooks
{
    [Binding]
    class TestInitialize
    {
        private Settings _settings;
        public TestInitialize(Settings settings)
        {
            _settings = settings;
        }

        [BeforeScenario]
        public void TestSetup()
        {
            _settings.BaseUrl = new System.Uri("https://api.github.com/repos/");
            _settings.RestClient.BaseUrl = _settings.BaseUrl;
        }

    }
}
