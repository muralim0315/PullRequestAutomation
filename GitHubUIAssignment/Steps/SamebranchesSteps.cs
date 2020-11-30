using AutomationFramework.Base;
using GitHubUIAssignment.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;
using GitHubUIAssignment.Context;
using AutomationFramework.Helpers;

namespace GitHubUIAssignment.Steps
{
    [Binding]
    class SamebranchesSteps: BaseStep
    {
        private readonly Page Browser;
        public SamebranchesSteps(Page _page)
        {
            Browser = _page;
        }

        [Given(@"I have navigated to OperaHouse repo")]
        public void GivenIHaveNavigatedToOperaHouseRepo()
        {
            NaviateSite("sympli-coding-challenge/QA-CC-V1-OperaHouse");
            Browser.CurrentPage = GetInstance<SameBranchesPage>();
        }

        [Given(@"I landed into the OperaHouse repo page")]
        public void GivenILandedIntoTheOperaHouseRepoPage()
        {
            Assert.IsTrue(Browser.CurrentPage.As<SameBranchesPage>().IsRightApp);
            LogHelpers.Write("Opened the correct Repo");
        }

        [Then(@"I try to create a new pull request for the repo")]
        public void ThenITryToCreateANewPullRequestForTheRepo()
        {
            Browser.CurrentPage.As<SameBranchesPage>().NavigateToPullRequest();
        }

        [When(@"I select the soure branch same as target branch")]
        public void WhenISelectTheSoureBranchSameAsTargetBranch()
        {
            Browser.CurrentPage.As<SameBranchesPage>().CreateNewPullRequestforSameBranches();
        }

        [Then(@"I should see the validation message stating source and target should not be the same")]
        public void ThenIShouldSeeTheValidationMessageStatingSourceAndTargetShouldNotBeTheSame()
        {
            Assert.IsTrue(Browser.CurrentPage.As<SameBranchesPage>().ShouldNotMerge());
        }

    }
}
