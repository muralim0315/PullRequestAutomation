using AutomationFramework.Base;
using AutomationFramework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace GitHubUIAssignment.Pages
{
    class NoDifferencePage : HomePage
    {
        protected override string PageUrl => "https://github.com/sympli-coding-challenge/QA-CC-V1-HarbourBridge";
        protected override string PageTitle => "sympli-coding-challenge/QA-CC-V1-HarbourBridge";

        [FindsBy(How = How.XPath, Using = "//h3[text()='There isn’t anything to compare.']")]
        IWebElement lblMessage { get; set; }
        public override bool IsRightApp => (DriverContext.Driver.IsTheSamePage(PageTitle, PageUrl));
        public bool ShouldNotMerge()
        {
            lblMessage.IsClickable(DriverContext.Driver);           
            return lblMessage.Text == "There isn’t anything to compare.";
        }

    }
}
