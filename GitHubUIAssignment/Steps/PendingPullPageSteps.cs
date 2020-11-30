using AutomationFramework.Base;
using GitHubUIAssignment.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;
using GitHubUIAssignment.Context;
using AutomationFramework.Helpers;

namespace GitHubUIAssignment.Steps
{
    [Binding]
    class PendingPullPageSteps : BaseStep
    {
        private readonly Page Browser;
        public PendingPullPageSteps(Page _page)
        {
            Browser = _page;
        }

        [Given(@"I have navigated to Campbell town repo")]
        public void GivenIHaveNavigatedToCampbellTownRepo()
        {
            NaviateSite("sympli-coding-challenge/QA-CC-V1-Campbelltown");
            Browser.CurrentPage = GetInstance<PendingPullPage>();
        }

        [Given(@"I see landed into the correct repo page")]
        public void GivenISeeLandedIntoTheCorrectRepoPage()
        {
            Assert.IsTrue(Browser.CurrentPage.As<PendingPullPage>().IsRightApp);
            LogHelpers.Write("Opened the correct Repo");
        }

        [When(@"I try to  create a new pull request")]
        public void WhenITryToCreateANewPullRequest()
        {
            Browser.CurrentPage.As<PendingPullPage>().NavigateToPullRequest();
        }

        [When(@"I Select the  source branch inorder to merge into the target branch")]
        public void WhenISelectTheSourceBranchInorderToMergeIntoTheTargetBranch()
        {
            Browser.CurrentPage.As<PendingPullPage>().CreateNewPullRequest();
        }

        [Then(@"I should see the view pull request option instead creating a new one")]
        public void ThenIShouldSeeTheViewPullRequestOptionInsteadCreatingANewOne()
        {
            Assert.IsTrue(Browser.CurrentPage.As<PendingPullPage>().CanCreatePull);
        }

    }
}
