using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPassBusiness
{
	public class Randomizer
	{
		public static string GetString()
		{
			string str = Path.GetRandomFileName();
			str = str.Replace(".","");
			return str;
		}
	}
}
