/*
 * Created by Ranorex
 * User: Abin
 * Date: 21-08-2019
 * Time: 11:16 AM
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
    /// Description of Change_VideoQaulity.
    /// </summary>
    [TestModule("A501E764-CB28-40E7-97C0-5EF9639D1794", ModuleType.UserCode, 1)]
    public class Change_VideoQaulity : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Change_VideoQaulity()
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
