using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using AutomationFramework.Base;
using AutomationFramework.Extensions;

namespace GitHubUIAssignment.Pages
{
    public class LoginPage : BasePage
    {

        protected override string PageUrl => "https://github.com/login";
        protected override string PageTitle => "Sign in to GitHub · GitHub";


        [FindsBy(How = How.Id, Using = "login_field")]
        IWebElement TxtUserName { get; set; }


        [FindsBy(How = How.Id, Using = "password")]
        IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-primary btn-block']")]
        IWebElement BtnLogin { get; set; }


        public void Login(string userName, string password)
        {
            TxtUserName.Clear();
            TxtUserName.SendKeys(userName);

            TxtPassword.Clear();
            TxtPassword.SendKeys(password);
        }

        
        public bool IsRightPage => (DriverContext.Driver.IsTheSamePage(PageTitle, PageUrl));
        public HomePage ClickLoginButton()
        {
            BtnLogin.Click();
            return GetInstance<HomePage>();
        }

    }
}
