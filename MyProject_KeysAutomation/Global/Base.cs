using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MyProject_KeysAutomation.Config;
using System.IO;
using System.Drawing.Imaging;
using RelevantCodes.ExtentReports;

namespace MyProject_KeysAutomation.Global
{
	class Base
		
	{
		//private static IWebDriver webDriver;
        
		public static string browser = (Resource1.Browser);
		
		public static string ExcelPath = Resource1.ExcelPath;
		public static string ScreenshotPath = Resource1.ScreenshotPath;
		public static string ReportPath = Resource1.ReportPath;
		public static string PhotoPath = Resource1.PhotoPath;

		//private static string browser = ConfigurationManager.AppSettings["browser"];
		public static ExtentTest test;
		public static ExtentReports extent;
		public static void Init()
		{
			switch (browser)
			{
				case "Chrome":
					Driver.driver = new ChromeDriver();
					break;
				case "IE":
					Driver.driver = new InternetExplorerDriver();
					break;
				case "Firefox":
					Driver.driver = new FirefoxDriver();
					break;
			}
			Driver.driver.Manage().Window.Maximize();
			extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
			extent.LoadConfig(Resource1.ReportXML);

		}
		public static string Title
		{
			get { return Driver.driver.Title; }
		}
		public static IWebDriver GetDriver
		{
			get { return Driver.driver; }
		}
		public static void Goto(string url)
		{
			Driver.driver.Url = url;
			
		}
		//report initialization
		
		public static void Close()
		{
			Driver.driver.Quit();
		}

		
	}
	
}