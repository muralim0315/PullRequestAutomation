using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.Extensions
{
    public static class WebElementExtensions
    {



        public static bool IsClickable(this IWebElement element, IWebDriver Driver)
        {
            try
            {

                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));


                return true;
            }
            catch
            {
                return false;
            }
        }


      
        }



 }
