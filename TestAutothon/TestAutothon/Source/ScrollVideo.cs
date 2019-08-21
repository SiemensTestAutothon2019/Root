/*
 * Created by Ranorex
 * User: Abin
 * Date: 21-08-2019
 * Time: 11:15 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Net.Http;

namespace TestAutothon
{
	public class Video
	{
		public string VideoName { get; set; }
	}

	/// <summary>
	/// Description of ScrollVideo.
	/// </summary>
	[TestModule("1C2076B6-875E-4D66-AE41-2D4BDB13DFBB", ModuleType.UserCode, 1)]
	public class ScrollVideo : ITestModule
	{
		string _VideoName = "summit2019";
		[TestVariable("918b6a8e-6f7d-4c8a-9230-be2d4c29f455")]
		public string VideoName
		{
			get { return _VideoName; }
			set { _VideoName = value; }
		}
		
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ScrollVideo()
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
			var videoList = repo.StepInForumYouTube.VideoList;
			
			WebElement video;
			if(!videoList.TryFindSingle(videoList.GetPath().ToString()+"//a[@innertext='"+VideoName+"']",25000,out video))
				throw new RanorexException("d");
			video.EnsureVisible();
			//videoList.CaptureCompressedImage("");
			video.Click();
			

		}
		
		
	}
}
