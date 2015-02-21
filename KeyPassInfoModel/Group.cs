using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassInfoModel
{
	public class Group
	{
		private List<Key> _keys = new List<Key>();

		public List<Key> Keys
		{
			get { return _keys; }
			set { _keys = value; }
		}

		private string _name = string.Empty;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public Group()
		{}

		public Group(string name)
		{
			_name = name;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
