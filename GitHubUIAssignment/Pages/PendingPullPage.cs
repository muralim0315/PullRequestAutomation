using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace GitHubUIAssignment.Pages
{
    class PendingPullPage : HomePage
    {
        protected override string PageUrl => "https://github.com/sympli-coding-challenge/QA-CC-V1-Campbelltown";
        protected override string PageTitle => "sympli-coding-challenge/QA-CC-V1-Campbelltown";

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-primary']")]
        protected IWebElement btnViewPullRequest { get; set; }

                public override bool IsRightApp => (DriverContext.Driver.IsTheSamePage(PageTitle, PageUrl));
        public bool CanCreatePull => btnViewPullRequest.IsClickable(DriverContext.Driver);


    }
}
