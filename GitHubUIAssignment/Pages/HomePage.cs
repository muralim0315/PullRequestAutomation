using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace GitHubUIAssignment.Pages
{
    public class HomePage: BasePage
    {
        protected override string PageUrl => "https://github.com/sympli-coding-challenge";
        protected override string PageTitle => "sympli-coding-challenge";


        [FindsBy(How = How.XPath, Using = "//span[text()='Pull requests']")]
        protected IWebElement lnkPullRequests { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='d-none d-md-block']")]
        protected IWebElement btnCreatePullRequest { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[text()='compare:']")]
        protected IWebElement drpSrource { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='select-menu-item-text break-word']")]
        protected virtual IWebElement lnkSourceBranch { get; set; }

     
        public virtual bool IsRightApp => (DriverContext.Driver.IsTheSamePage(PageTitle, PageUrl));
        public void NavigateToPullRequest()
        {
            lnkPullRequests.IsClickable(DriverContext.Driver);
            lnkPullRequests.Click();
            btnCreatePullRequest.IsClickable(DriverContext.Driver);
            btnCreatePullRequest.Click();
        }

        public void CreateNewPullRequest()
        {
            drpSrource.IsClickable(DriverContext.Driver);
            drpSrource.Click();
            lnkSourceBranch.IsClickable(DriverContext.Driver);
            lnkSourceBranch.Click();
        }
    }
}
