using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Global
{
	class SignOut
	{

		public static void SignOutFromPage()
		{


			Thread.Sleep(2000);
				ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/i[1]");
				ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/a[4]");
			
	

		}
	}
}
