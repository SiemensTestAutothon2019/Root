/*
 * Created by Ranorex
 * User: Asmi
 * Date: 8/20/2019
 * Time: 2:40 PM
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
    /// Description of Delete_Item_Cart.
    /// </summary>
    [TestModule("1E537099-F6AE-4819-8DC9-B97C3FD7CB27", ModuleType.UserCode, 1)]
    public class Delete_Item_Cart : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Delete_Item_Cart()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        
        string _ItemName = "Fenoix Men's Cotton T-Shirt Hooded Maroon-Medium";
        [TestVariable("f2213410-d38c-444a-8c5a-a7c2cabe8058")]
        public string ItemName
        {
        	get { return _ItemName; }
        	set { _ItemName = value; }
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
            AmazonRepository repo = AmazonRepository.Instance;
			repo.rep_ItemName = ItemName;
			WebElement elmItems,elmParent,elmSibling,elmDelete;
			if(repo.Amazon.Body.CartView.ItemInfo.Exists(5000,out elmItems))
			{
				elmParent = Helper.GetParent(elmItems,"Ul","TagName","ul");
				elmSibling = elmParent.NextSibling;
				if(elmSibling.TryFindSingle(elmSibling.GetPath().ToString()+"//input[@tagname='input' and @tagvalue='Delete']",5000,out elmDelete))
				{
					bool clickOperation=true;
					do
					{
						if(elmDelete==null)
							clickOperation = false;
						else
							elmDelete.Click();
						
					}while(clickOperation==false);
				}
				else
					throw new RanorexException("Delete button is not available");
			}
			else
				throw new RanorexException("items is not avaialble in the cart");
        }
    }
}
