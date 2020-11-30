using AutomationFramework.Config;
using AutomationFramework.Helpers;


namespace AutomationFramework.Base
{
    public abstract class BaseStep:Base 
    {

        public virtual void NaviateSite(string RepoURL="")
        {
            DriverContext.Browser.GoToUrl(Settings.AUT+ RepoURL);
            LogHelpers.Write("Opened the browser !!!");
           
        }
    }
}
