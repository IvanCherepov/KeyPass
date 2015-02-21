using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using KeyPassInfoModel;

namespace KeyPassBusiness
{
	public static class PlatformExtensions
	{
		public static Group GetGroup(this TreeNode node)
		{
			return (Group)node.Tag;
		}
	}
}
