/*
 * Created by Ranorex
 * User: Bindudevi
 * Date: 8/20/2019
 * Time: 9:48 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestAutothon
{
	/// <summary>
	/// Description of Open_Browser.
	/// </summary>
	[TestModule("4A0B4EAE-ACC4-436B-9178-DBC6F364152A", ModuleType.UserCode, 1)]
	public class Open_Browser : ITestModule
	{
		
		string _URL = "www.youtube.com";
		[TestVariable("cf32ee9f-2278-4f3c-9e29-82eebe1b26e1")]
		public string URL
		{
			get { return _URL; }
			set { _URL = value; }
		}
		
		
		string _BrowserType = "RanorexWebTesting";
		[TestVariable("15f78a00-a9c1-45e5-b04a-d036246b97b5")]
		public string BrowserType
		{
			get { return _BrowserType; }
			set { _BrowserType = value; }
		}
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Open_Browser()
		{
			// Do not delete - a parameterless constructor is required!
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			Mouse.Enabled=false;
			
			if(BrowserType.Equals("RanorexWebTesting"))
				Host.Local.RunMobileApp("Current Endpoint(USB-ZY22269JPS)",URL);
			else
				Host.Local.OpenBrowser(URL,"Chrome",false,false);
			Report.Success(string.Format("Successfully opened {0} URL.",URL));
		}
	}
}
