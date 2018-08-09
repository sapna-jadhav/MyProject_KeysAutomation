using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject_KeysAutomation.Global
{
	class HomePage
	{
		public static void SkipButton()
		{

			//To skip the alert
			//ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html/body/div[5]/div/div[5]/a[1]");
			Thread.Sleep(1500);
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/div[4]/i[1]");
			ExtendMethods.ButtonClick(Driver.driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/div[2]/div[4]/div[1]/a[4]");
		}
	}
}
