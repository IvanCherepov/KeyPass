using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassInfoModel
{
	public class KeyPassDocument
	{
		private List<Group> _groups = new List<Group>();

		public List<Group> Groups
		{
			get { return _groups; }
			set { _groups = value; }
		}

	}
}
