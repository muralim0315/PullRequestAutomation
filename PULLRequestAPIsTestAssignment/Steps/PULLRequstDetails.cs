using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;
using PULLRequestAPIsTestAssignment.Context;

namespace PULLRequestAPIsTestAssignment.Steps
{
    [Binding]
    class PULLRequstDetails
    {
        Settings _settings;

        public PULLRequstDetails(Settings settings)
        {
            _settings = settings;
        }

        [Given(@"I have configured the API with respective pull request")]
        public void GivenIHaveConfiguredTheAPIWithRespectivePullRequest()
        {
            
            _settings.Request = new RestRequest("{owner}/{repo}/pulls/{pull_number}", Method.GET);
        }

        [Given(@"I provided all the required details")]
        public void GivenIProvidedAllTheRequiredDetails()
        {
            _settings.Request.AddUrlSegment("owner", "sympli-coding-challenge");
            _settings.Request.AddUrlSegment("repo", "QA-CC-V1-Campbelltown");
            _settings.Request.AddUrlSegment("pull_number", 1);
        }

        [When(@"I invoke the API with all the  parameters")]
        public void WhenIInvokeTheAPIWithAllTheParameters()
        {
            _settings.Response = _settings.RestClient.Execute(_settings.Request);
        }

        [Then(@"I should see all the pull request details")]
        public void ThenIShouldSeeAllThePullRequestDetails()
        {
            Assert.IsTrue(_settings.Response.StatusCode.ToString() == "OK");
        }

    }
}
