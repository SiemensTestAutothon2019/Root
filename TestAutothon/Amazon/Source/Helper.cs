/*
 * Created by Ranorex
 * User: Asmi
 * Date: 8/20/2019
 * Time: 2:41 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using OpenQA.Selenium.Internal;
using Ranorex;
using Ranorex.Core;

namespace Amazon
{
	/// <summary>
	/// Description of Helper.
	/// </summary>
	public class Helper
	{
		public Helper()
		{
		}
		public static WebElement GetParent(WebElement Childelement, string ParentElementType, string ParentElementAttributeToCheck, string ParentElementAttributeValue )
		{
			WebElement parent;
			WebElement parentElement = null;
			bool IsFound = false;
			//Report.Info("Initial = "+Childelement.Class);
			try
			{
				parent = Childelement.Parent;
				do
				{
					var type = parent.TagName;
					if (type.ToString().Contains(ParentElementType.ToLower()))
					{
						string parentClassText = parent.GetAttributeValue<string>(ParentElementAttributeToCheck);
						if (!string.IsNullOrEmpty(parentClassText) &&   parentClassText.Contains(ParentElementAttributeValue))
						{
							IsFound = true;
							parentElement = parent;
						}
					}
					parent = parent.Parent;
					Report.Info(string.Format("{0}",parent));
				}while (!IsFound);
				
				return parentElement;
			}
			catch (Exception ex)
			{
				//	Report.Info(Childelement.Class);
				//Report.Warn(ex.StackTrace);
				throw new RanorexException(string.Format("Unable to find the parent, Error Details : {0} ", ex.Message));
			}
		}
	}
}
