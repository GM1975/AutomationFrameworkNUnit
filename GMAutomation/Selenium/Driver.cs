using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;


namespace GMAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {

            get { return ConfigurationManager.AppSettings["EnvUrl"]; }

        }

        public static void Initialise()
        {

            string browser = ConfigurationManager.AppSettings["Browser"];

            switch (browser)
            {
                case "Chrome":
                    Instance = new ChromeDriver();
                    break;
                case "IE":
                    Instance = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    Instance = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("No valid config for key 'Browser'. Accepted values are 'Chrome', 'IE', 'Firefox'");

            }

            Instance = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Chrome());
            //Instance = new RemoteWebDriver(new Uri("http://192.168.183.101:8080/wd/hub"), DesiredCapabilities.Firefox());
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            Instance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(15));
            Instance.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(15));
        }

        public static void Close()

        {
            Instance.Quit();
        }
    }
}