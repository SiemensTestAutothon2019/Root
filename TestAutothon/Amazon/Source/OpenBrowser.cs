/*
 * Created by Ranorex
 * User: Bindudevi
 * Date: 8/19/2019
 * Time: 11:05 PM
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
    /// Description of OpenBrowser.
    /// </summary>
    [TestModule("67D3E2FC-1F46-4B1C-A678-3EE614D731AE", ModuleType.UserCode, 1)]
    public class OpenBrowser : ITestModule
    {
    	
    	string _URL = "www.amazon.com";
    	[TestVariable("d19ac2b9-62f9-4106-afb8-08f14a424661")]
    	public string URL
    	{
    		get { return _URL; }
    		set { _URL = value; }
    	}
    	
    	
    	string _Browser = "";
    	[TestVariable("27713f87-9d31-4df3-8d99-f6b46f736cb0")]
    	public string Browser
    	{
    		get { return _Browser; }
    		set { _Browser = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
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
            
            Host.Local.OpenBrowser(URL,Browser,false,false);
			Report.Success(string.Format("Successfully opened {0} URL.",URL));
        }
    }
}
