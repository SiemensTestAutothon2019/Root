/*
 * Created by Ranorex
 * User: Bindudevi
 * Date: 8/20/2019
 * Time: 12:35 AM
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
	/// Description of Open_Product.
	/// </summary>
	[TestModule("5E6DFC10-0050-4D49-9BA2-B356288CD463", ModuleType.UserCode, 1)]
	public class Open_Product : ITestModule
	{
		
		
		string _ProductName = "Amazon Brand - Goodthreads Men's Lightweight Slub V-Neck Pocket T-Shirt";
		[TestVariable("56a7585f-c751-49d6-82d7-b0e78cf12ff0")]
		public string ProductName
		{
			get { return _ProductName; }
			set { _ProductName = value; }
		}
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Open_Product()
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
			
			WebElement elmProduct,elmClikProduct;
			WebDocument myWebDocument = "/dom[@domain='www.amazon.com']";
			elmProduct = myWebDocument.FindSingle(".//span[@data-component-type='s-search-results']");
			if(elmProduct.TryFindSingle(elmProduct.GetPath().ToString()+"//span[@innertext='"+ProductName+"']",30000, out elmClikProduct))
			{
				elmClikProduct.Click();
				Report.Success(string.Format("Successfully filtered {0} product",ProductName));
			}
			else
				throw new RanorexException(string.Format("Failed to find {0} product.",ProductName));
		}
	}
}
