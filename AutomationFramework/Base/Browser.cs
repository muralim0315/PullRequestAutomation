namespace AutomationFramework.Base
{
    public class Browser
    {
      
        public void GoToUrl(string url)
        {
            DriverContext.Driver.Navigate().GoToUrl("about:blank");
            DriverContext.Driver.Url = url;            
            DriverContext.Driver.Manage().Window.Maximize();
            
        }

    }

        public enum BrowserType
        {
            
            FireFox,
            Chrome,
            IE
        }
}
