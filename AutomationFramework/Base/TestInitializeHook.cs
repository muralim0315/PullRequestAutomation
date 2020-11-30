using AutomationFramework.Config;
using AutomationFramework.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace AutomationFramework.Base
{

    public abstract class TestInitializeHook 
    {
        public static void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(Settings.BrowserType);

            LogHelpers.Write("Initialized framework");

        }

        private static void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver(); 
                    DriverContext.Browser = new Browser();
                    LogHelpers.Write("Chrome driver instantiated");
                    break;

                case BrowserType.FireFox:
                    string geckoDriverpath = AppDomain.CurrentDomain.BaseDirectory + @"Drivers";
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoDriverpath);
                    DriverContext.Driver = new FirefoxDriver(service);
                    DriverContext.Browser = new Browser();
                    LogHelpers.Write("Fire fox driver instantiated");
                    break;
                case BrowserType.IE:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser();
                    LogHelpers.Write("Fire fox driver instantiated");
                    break;
            }

        }


    }
}
