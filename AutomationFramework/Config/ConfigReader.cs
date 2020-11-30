using AutomationFramework.Base;
using System;
using System.IO;
using System.Xml.XPath;

namespace AutomationFramework.Config
{
    public class ConfigReader
    {

        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem islog;            
            XPathItem buildname;
            //XPathItem logPath;
            XPathItem appConnection;
            XPathItem browsertype;

           string configFile = AppDomain.CurrentDomain.BaseDirectory + @"Config\GlobalConfig.xml";
            string logLocation= AppDomain.CurrentDomain.BaseDirectory + @"Storage\Logs";
            string screenShotPath= AppDomain.CurrentDomain.BaseDirectory + @"Storage\Screenshots";
            

            FileStream stream = new FileStream(configFile, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("AutoFramework /RunSettings/AUT");
            buildname = navigator.SelectSingleNode("AutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("AutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("AutoFramework/RunSettings/IsLog");

            //logPath = navigator.SelectSingleNode("AutoFramework/RunSettings/LogPath");
            
            appConnection = navigator.SelectSingleNode("AutoFramework/RunSettings/ApplicationDb");
            browsertype = navigator.SelectSingleNode("AutoFramework/RunSettings/Browser");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.LogPath = logLocation;
            Settings.ScreenshotPath = screenShotPath;
            Settings.AppConnectionString = appConnection.Value.ToString();
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), browsertype.Value.ToString());


        }

    }
}
