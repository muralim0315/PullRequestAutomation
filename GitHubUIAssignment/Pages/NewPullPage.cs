using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace GitHubUIAssignment.Pages
{
    class NewPullPage : HomePage
    {
        protected override string PageUrl => "https://github.com/sympli-coding-challenge/QA-CC-V1-Kakadu";
        protected override string PageTitle => "sympli-coding-challenge/QA-CC-V1-Kakadu";

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary js-details-target']")]
        protected IWebElement btnCreateNewPullRequest { get; set; }

        public override bool IsRightApp => (DriverContext.Driver.IsTheSamePage(PageTitle, PageUrl));
        public bool CanCreatePull => btnCreateNewPullRequest.IsClickable(DriverContext.Driver);

    }
}
