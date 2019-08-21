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
    /// Description of ScrollVideo.
    /// </summary>
    [TestModule("1C2076B6-875E-4D66-AE41-2D4BDB13DFBB", ModuleType.UserCode, 1)]
    public class ScrollVideo : ITestModule
    {
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
        }
    }
}
