﻿/*
 * Created by Ranorex
 * User: Abin
 * Date: 21-08-2019
 * Time: 11:14 AM
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
    /// Description of Navigate_Tab.
    /// </summary>
    [TestModule("F529B6CB-CF78-4F52-B7B7-84B9108C349D", ModuleType.UserCode, 1)]
    public class Navigate_Tab : ITestModule
    {
    	
    	string _TabName = "VIDEOS";
    	[TestVariable("bc5faa3e-4b17-41fe-aa17-41d0ab98e51b")]
    	public string TabName
    	{
    		get { return _TabName; }
    		set { _TabName = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_Tab()
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
            
            TestAutothonRepository repo = TestAutothonRepository.Instance;
            WebElement elmTab;
            if(repo.StepInForumYouTube.VideosTabInfo.Exists(20000,out elmTab))
            {
            	elmTab.Click();
            	Report.Success(string.Format("Successfully clicked on {0} tab.",TabName));
            }
            else
            	throw new RanorexException(string.Format("Failed to find {0} tab.",TabName));
        }
    }
}
