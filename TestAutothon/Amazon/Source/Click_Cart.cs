/*
 * Created by Ranorex
 * User: Asmi
 * Date: 8/19/2019
 * Time: 5:11 PM
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
    /// Description of Click_Cart.
    /// </summary>
    [TestModule("26344B4C-2298-4EC0-B2AE-7D5CD0DAA6F7", ModuleType.UserCode, 1)]
    public class Click_Cart : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Cart()
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
            
            Report.info("Click on cart option in Amazon Home page");
            
            AmazonRepository repo = AmazonRepository.Instance;
			WebElement elmCart;
			bool clickOperation=true;
			do
			{
				if(!repo.Amazon.Header.CartInfo.Exists(5000, out elmCart))
					throw new RanorexException("Cart is not avaialable in the website");
				if(elmCart==null)
					clickOperation = false;
				else
					elmCart.Click();
				
			}while(clickOperation==false);
			Report.Success("Cart has been click successfully");
        }
    }
}
