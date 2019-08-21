/*
 * Created by Ranorex
 * User: Abin
 * Date: 21-08-2019
 * Time: 11:12 AM
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
    /// Description of Search_Click.
    /// </summary>
    [TestModule("DDC5D006-F210-43EF-8770-384DE9CB8121", ModuleType.UserCode, 1)]
    public class Search_Click : ITestModule
    {
    	
    	string _Text = "Step-inforum";
    	[TestVariable("fd664167-ee10-4624-8b39-2e90fcb76090")]
    	public string Text
    	{
    		get { return _Text; }
    		set { _Text = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Search_Click()
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
            
            TestAutothonRepository repo = TestAutothonRepository.Instance;
            WebElement elmAddText,elmSearchButton;
            if(repo.StepInForumYouTube.SearchQueryInfo.Exists(10000,out elmAddText))
            {
            	elmAddText.PressKeys(Text);
            	elmSearchButton = repo.StepInForumYouTube.SearchButton;
            	elmSearchButton.Click();
            	Report.Success(string.Format("Successfully searched the {0}.",Text));
            
            }
            else
            	throw new RanorexException("Failed to find search query.");
        }
    }
}
