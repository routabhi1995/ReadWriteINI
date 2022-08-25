using System;

namespace ReadWriteIni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            IniFile settingsIni = new IniFile (@".\\TestData.Ini");
 
            string executionMode = settingsIni.Read ("BrowserName", "BrowserInfo").ToLower ();
            Console.WriteLine (executionMode);
 
            string WebdriverToUse = settingsIni.Read ("WebDriverLocation", "BrowserInfo").ToLower ();
            Console.WriteLine (WebdriverToUse);
            settingsIni.Write("TimeOut","4000","BrowserInfo");
           

            string WebdriverTotime = settingsIni.Read ("BrowserName", "BrowserInfo");
            Console.WriteLine (WebdriverTotime);
            settingsIni.Read("TimeOut","BrowserInfo");
            settingsIni.Write("BrowserName","IE","BrowserInfo");
            settingsIni.Write("Url","www.facebook.com","AppUnderTest");
            //settingsIni.Write("Url","www.facebook.com","AppUnderTest");
        }
    }
}
