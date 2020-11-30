using AutomationFramework.Base;
using GitHubUIAssignment.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;
using GitHubUIAssignment.Context;
using AutomationFramework.Helpers;

namespace GitHubUIAssignment.Steps
{
    [Binding]
    class NoDifferenceSteps:BaseStep
    {
        private readonly Page Browser;
        public NoDifferenceSteps(Page _page)
        {
            Browser = _page;
        }

        [Given(@"I have navigated to HarbourbridgeRepo")]
        public void GivenIHaveNavigatedToHarbourbridgeRepo()
        {
            NaviateSite("sympli-coding-challenge/QA-CC-V1-HarbourBridge");
            Browser.CurrentPage = GetInstance<NoDifferencePage>();
        }

        [Given(@"I see landed in the correct repo page")]
        public void GivenISeeLandedInTheCorrectRepoPage()
        {
            Assert.IsTrue(Browser.CurrentPage.As<NoDifferencePage>().IsRightApp);
            LogHelpers.Write("Opened the correct Repo");
        }

        [Then(@"I try to create a new pull request")]
        public void ThenITryToCreateANewPullRequest()
        {
            Browser.CurrentPage.As<NoDifferencePage>().NavigateToPullRequest();
        }

        [Then(@"I select source branch")]
        public void ThenISelectSourceBranch()
        {
            Browser.CurrentPage.As<NoDifferencePage>().CreateNewPullRequest();
        }

        [Then(@"Pull request option should not be there\.")]
        public void ThenPullRequestOptionShouldNotBeThere_()
        {
            Assert.IsTrue(Browser.CurrentPage.As<NoDifferencePage>().ShouldNotMerge());
        }

    }
}
