using AutomationFramework.Base;
using GitHubUIAssignment.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using GitHubUIAssignment.Context;
using AutomationFramework.Helpers;

namespace GitHubUIAssignment.Steps
{
    [Binding]
  public class HomePageSteps:BaseStep
    {
        private readonly Page Browser;
        public HomePageSteps(Page _page)
        {
            Browser = _page;
        }


        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NaviateSite("login");
            Browser.CurrentPage = GetInstance<LoginPage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            Assert.IsTrue(Browser.CurrentPage.As<LoginPage>().IsRightPage);
          //  Assert.IsTrue(Browser.CurrentPage.As<LoginPage>().IsRightApp);
            LogHelpers.Write("Application opened");
        }

        [When(@"I enter below UserName and Password")]
        public void WhenIEnterBelowUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Browser.CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
            Browser.UserName = data.UserName;
        }

        [When(@"I click sign in button")]
        public void WhenIClickSignInButton()
        {
            Browser.CurrentPage = Browser.CurrentPage.As<LoginPage>().ClickLoginButton();
        }

        [Then(@"I should get navigated to Homepage")]
        public void ThenIShouldGetNavigatedToHomepage()
        {
            NaviateSite("sympli-coding-challenge");
            Assert.IsTrue(Browser.CurrentPage.As<HomePage>().IsRightApp);
            LogHelpers.Write("LoggedInto Sympli Repo");
            
        }



    }
}
