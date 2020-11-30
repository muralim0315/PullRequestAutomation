using AutomationFramework.Base;
using GitHubUIAssignment.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;
using GitHubUIAssignment.Context;
using AutomationFramework.Helpers;

namespace GitHubUIAssignment.Steps
{
    [Binding]
    class NewPullPageSteps: BaseStep
    {
        private readonly Page Browser;
        public NewPullPageSteps(Page _page)
        {
            Browser = _page;
        }


        [Given(@"I have navigated to Kakadu repo")]
        public void GivenIHaveNavigatedToKakaduRepo()
        {
            NaviateSite("sympli-coding-challenge/QA-CC-V1-Kakadu");
            Browser.CurrentPage = GetInstance<NewPullPage>();
        }

        [Given(@"I see landed in to the correct repo page")]
        public void GivenISeeLandedInToTheCorrectRepoPage()
        {
            Assert.IsTrue(Browser.CurrentPage.As<NewPullPage>().IsRightApp);
            LogHelpers.Write("Opened the correct Repo");
        }

        [When(@"I try to create a new pull request")]
        public void WhenITryToCreateANewPullRequest()
        {
            Browser.CurrentPage.As<NewPullPage>().NavigateToPullRequest();
        }

        [When(@"I Select the source branch inorder to merge into the target branch")]
        public void WhenISelectTheSourceBranchInorderToMergeIntoTheTargetBranch()
        {
            Browser.CurrentPage.As<NewPullPage>().CreateNewPullRequest();
        }

        [Then(@"I should see the create pull request option available to merge into target branch\.")]
        public void ThenIShouldSeeTheCreatePullRequestOptionAvailableToMergeIntoTargetBranch_()
        {
            Assert.IsTrue(Browser.CurrentPage.As<NewPullPage>().CanCreatePull);
        }

    }
}
