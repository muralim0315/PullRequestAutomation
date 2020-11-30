using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace GitHubUIAssignment.Pages
{
    class SameBranchesPage : HomePage
    {
        protected override string PageUrl => "https://github.com/sympli-coding-challenge/QA-CC-V1-OperaHouse";
        protected override string PageTitle => "sympli-coding-challenge/QA-CC-V1-OperaHouse";

        [FindsBy(How = How.XPath, Using = "//span[@class='select-menu-item-text flex-auto break-word']")]        
        public  IWebElement lnkSrcBranch { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You’ll need to use two different branch names to get a valid comparison.')]")]
        public IWebElement lblMessage { get; set; }
        
        public override bool IsRightApp => (DriverContext.Driver.IsTheSamePage(PageTitle, PageUrl));
        public bool ShouldNotMerge()
        {
           return lblMessage.IsClickable(DriverContext.Driver);         
        }

        public void CreateNewPullRequestforSameBranches()
        {
            drpSrource.IsClickable(DriverContext.Driver);
            drpSrource.Click();
            lnkSrcBranch.IsClickable(DriverContext.Driver);
            lnkSrcBranch.Click();
        }


    }
}
