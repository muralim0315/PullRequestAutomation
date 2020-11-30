using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutomationFramework.Extensions
{
    public static class WebDriverExtensions
    {
        public static bool IsTheSamePage(this IWebDriver Driver, string pagetitle, string pageURL)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlMatches(pageURL));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleIs(pagetitle));

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
