/*
 * Created by Ranorex
 * User: Bindudevi
 * Date: 8/19/2019
 * Time: 11:33 PM
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
	/// Description of AddProduct.
	/// </summary>
	[TestModule("4EE3041A-EF81-4B93-BAB8-916DF7D0E05F", ModuleType.UserCode, 1)]
	public class AddProduct : ITestModule
	{
		
		string _ProductName = "T-Shirt";
		[TestVariable("754cf9a8-1e36-460f-a459-75c38672d609")]
		public string ProductName
		{
			get { return _ProductName; }
			set { _ProductName = value; }
		}
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public AddProduct()
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
			
			AmazonRepository repo = AmazonRepository.Instance;
			
			var amazon = repo.Amazon;
			WebElement elmSearchBox,elmBox;
			WebDocument myWebDocument = "/dom[@domain='www.amazon.com']";
			elmSearchBox = myWebDocument.FindSingle(".//input[@id='twotabsearchtextbox']");
			elmSearchBox.PressKeys(ProductName);
			elmBox = myWebDocument.FindSingle(".//input[@class='nav-input']");
			if(elmBox!=null)
			{
				elmBox.Click();
				Report.Success(string.Format("Successfully filtered {0} product",ProductName));
			}
			else
				throw new RanorexException("Failed to find search button.");
		}
	}
}
