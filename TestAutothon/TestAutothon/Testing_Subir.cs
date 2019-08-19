/*
 * Created by Ranorex
 * User: Asmi
 * Date: 8/19/2019
 * Time: 3:23 PM
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
    /// Description of Testing_Subir.
    /// </summary>
    [TestModule("CCA1ED1D-3138-4D89-8A3A-4507D21FC11D", ModuleType.UserCode, 1)]
    public class Testing_Subir : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Testing_Subir()
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
            
            Report.Info("Testing");
        }
    }
}
