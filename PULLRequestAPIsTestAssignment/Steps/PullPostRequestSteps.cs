using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;
using PULLRequestAPIsTestAssignment.Context;

namespace PULLRequestAPIsTestAssignment.Steps
{
    [Binding]
    class PullPostRequestSteps
    {
        Settings _settings;
        public PullPostRequestSteps(Settings settings)
        {
            _settings = settings;
        }

        [Given(@"I have configured the API with necessary parameters")]
        public void GivenIHaveConfiguredTheAPIWithNecessaryParameters()
        {
            _settings.Request = new RestRequest("{owner}/{repo}/pulls", Method.POST);
            _settings.Request.AddJsonBody(new {head ="developer", @base="master" });
        }

        [Given(@"provided values for all required parameters")]
        public void GivenProvidedValuesForAllRequiredParameters()
        {
            _settings.Request.AddUrlSegment("owner", "sympli-coding-challenge");
            _settings.Request.AddUrlSegment("repo", "QA-CC-V1-OperaHouse");
        }

        [When(@"I invoke the API with required data")]
        public void WhenIInvokeTheAPIWithRequiredData()
        {
            //AS THE TEST INSTRUCTED NOT TO CREATE A PULL REQUEST, NOT INVOKED THE METHOD.
           // _settings.Response = _settings.RestClient.Execute(_settings.Request);
        }

        [Then(@"it should create a pull request")]
        public void ThenItShouldCreateAPullRequest()
        {
            //Assert.IsTrue(_settings.Response.StatusCode.ToString() == "OK");
        }



    }
}
