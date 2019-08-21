/*
 * Created by Ranorex
 * User: Abin
 * Date: 21-08-2019
 * Time: 11:13 AM
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
    /// Description of Select_Channel.
    /// </summary>
    [TestModule("CDB1D30B-8B8A-4AC5-B03C-B285F6E048CB", ModuleType.UserCode, 1)]
    public class Select_Channel : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Channel()
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
            Mouse.Enabled = false;
            
            TestAutothonRepository repo = TestAutothonRepository.Instance;
            WebElement elmYoutubeChannel;
            if(repo.StepInForumYouTube.STePINForumInfo.Exists(10000,out elmYoutubeChannel))
            {
            	elmYoutubeChannel.Click();
            	Report.Success("Successfully clicked on StepInForum you tube channel.");
            }
            else
            	throw new RanorexException("Failed to find StepInForum youtube channel.");
        }
    }
}
