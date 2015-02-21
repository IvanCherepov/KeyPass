using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassInfoModel
{
	public class Key
	{
		public Key()
		{

		}

		private string _title = string.Empty;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private string _userName = string.Empty;

		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		private string _password = string.Empty;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private string _url = string.Empty;

		public string Url
		{
			get { return _url; }
			set { _url = value; }
		}

		private string _notes = string.Empty;

		public string Notes
		{
			get { return _notes; }
			set { _notes = value; }
		}
	}

}
