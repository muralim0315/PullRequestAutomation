using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;
using PULLRequestAPIsTestAssignment.Context;

namespace PULLRequestAPIsTestAssignment.Context
{
    [Binding]
    class PULLSteps
    {
        Settings _settings;
        public PULLSteps(Settings settings)
        {
            _settings = settings;
        }



        [Given(@"I have configured the API with necessary details")]
        public void GivenIHaveConfiguredTheAPIWithNecessaryDetails()
        {
            _settings.Request = new RestRequest("{owner}/{repo}/pulls/{pull_number}/commits", Method.GET);
          
        }

        [Given(@"provided all required inputs")]
        public void GivenProvidedAllRequiredInputs()
        {
            _settings.Request.AddUrlSegment("owner", "sympli-coding-challenge");
            _settings.Request.AddUrlSegment("repo", "QA-CC-V1-Campbelltown");
            _settings.Request.AddUrlSegment("pull_number", 1);
        }

        [When(@"I invoke the API with all the input parameters")]
        public void WhenIInvokeTheAPIWithAllTheInputParameters()
        {
           _settings.Response = _settings.RestClient.Execute(_settings.Request);
        }

        [Then(@"It should provide all the commits of a particular pull request")]
        public void ThenItShouldProvideAllTheCommitsOfAParticularPullRequest()
        {
            Assert.IsTrue(_settings.Response.StatusCode.ToString() == "OK");
        }


    }
}
