﻿/*
 * Created by Ranorex
 * User: Abin
 * Date: 21-08-2019
 * Time: 11:17 AM
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
    /// Description of ReadUpcomimgVideoList.
    /// </summary>
    [TestModule("DB5289E4-1C6B-4FB4-BCF4-45AE697012CA", ModuleType.UserCode, 1)]
    public class ReadUpcomimgVideoList : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReadUpcomimgVideoList()
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
            
            var repo = TestAutothonRepository.Instance;
            var VideolList = repo.StepInForumYouTube.StyleScopeYtdWatchNextSecondaryRes;
            List<string> lstVideos=new List<string>();
            IList<WebElement> elmVideoList=VideolList.Find<WebElement>(VideolList.GetPath().ToString()+"//div[@id='dismissable']//span[@id='video-title']");
            Report.Info(VideolList.GetPath().ToString()+"//div[@Id='contents']//div[@id='dismissable']//span[@id='video-title']");
            foreach (var video in elmVideoList)
            {
            	Report.Info(video.GetPath().ToString());
            	lstVideos.Add(video.GetAttributeValue<object>("Title").ToString());
            }

        }
    }
}
