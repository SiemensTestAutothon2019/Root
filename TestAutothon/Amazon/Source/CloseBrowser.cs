/*
 * Created by Ranorex
 * User: Bindudevi
 * Date: 8/20/2019
 * Time: 1:13 AM
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

namespace Amazon
{
	/// <summary>
	/// Description of CloseBrowser.
	/// </summary>
	[TestModule("81D8502E-C4ED-4A1C-A94F-59A7725BD5F9", ModuleType.UserCode, 1)]
	public class CloseBrowser : ITestModule
	{
		
		
		string _URL = "www.amazon.com";
		[TestVariable("caf3c197-f169-45f9-92bd-e3d5efe0e50c")]
		public string URL
		{
			get { return _URL; }
			set { _URL = value; }
		}
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CloseBrowser()
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
			
			AmazonRepository repo = AmazonRepository.Instance;
			try
			{
				WebDocument myWebDocument = "/dom[@domain='"+URL+"']";
				Validate.Exists(myWebDocument.GetPath());
				myWebDocument.Close();
			}
			catch
			{
				throw new RanorexException("Unable to find chrome with given application.");
			}
		}
	}
}
