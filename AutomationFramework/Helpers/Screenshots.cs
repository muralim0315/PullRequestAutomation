using OpenQA.Selenium;
using System.IO;
using AutomationFramework.Base;
using AutomationFramework.Config;


namespace AutomationFramework.Helpers
{
    public class Screenshots
    {
        

      
        public static void MakeScreenshotAfterStep()
        {
            if (!(DriverContext.Driver is ITakesScreenshot takesScreenshot))
            {
                return;
            }

            var screenshot = takesScreenshot.GetScreenshot();

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Path.GetTempFileName());
            string fileName = $"{fileNameWithoutExtension}.png";
            string dir = Settings.ScreenshotPath;
             string tempFileName = Path.Combine(dir, fileName);

          

            if (Directory.Exists(dir))
            {
                screenshot.SaveAsFile(tempFileName, ScreenshotImageFormat.Png);
            }

            else
            {
                Directory.CreateDirectory(dir);
                screenshot.SaveAsFile(tempFileName, ScreenshotImageFormat.Png);
            }
         

        
        }

        
    }
}
