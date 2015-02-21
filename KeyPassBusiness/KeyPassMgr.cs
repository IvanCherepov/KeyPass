using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyPassInfoModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.IO;



namespace KeyPassBusiness
{
	public static class KeyPassMgr
	{
		public static List<Group> groups;
		private static Group group = null;
		private static KeyPassDocument _document = new KeyPassDocument();
		private static KeyPassDocument _documentoriginal = new KeyPassDocument();

		private static Graphics _g;
		private static int x0 = 60;
		private static int y0 = 80;
		private const int w = 120;
		private const int h = 26;

		public static KeyPassDocument DocumentOriginal
		{
			get { return _documentoriginal; }
		}

		public static KeyPassDocument Document
		{
			get { return _document; }
		}

		static byte[] GetBytes(string str)
		{
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}

		static string GetString(byte[] bytes)
		{
			char[] chars = new char[bytes.Length / sizeof(char)];
			System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
			return new string(chars);
		}

		public static void SaveAs(string filename)
		{
			string s = string.Empty;
			foreach (Group g in _document.Groups)
			{
				s = s + " Group " + g.Name;
				foreach (Key k in g.Keys)
					s = s + " Key " + k.Title + " " + k.UserName + " " + k.Password + " " + k.Url + " " + k.Notes;
			}
			File.WriteAllBytes(filename, CryptoHelper.Encrypt(GetBytes(s)));
		}

		public static void Open(string filename)
		{
			string[] words = GetString(CryptoHelper.Decrypt(File.ReadAllBytes(filename))).Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				string word = words[i];
				switch (word)
				{
					case "Group":
						group = new Group(words[i + 1]);
						KeyPassMgr.AddGroup(group);
						break;
					case "Key":
						Key key = new Key();
						key.Title = words[i + 1];
						key.UserName = words[i + 2];
						key.Password = words[i + 3];
						key.Url = words[i + 4];
						key.Notes = words[i + 5];
						KeyPassMgr.AddKey(group, key);
						break;
				}
			}

		}

		public static void MakeDocumentCopy()
		{
			_documentoriginal = new KeyPassDocument();
			foreach (Group g in _document.Groups)
			{
				Group tgroup = new Group(g.Name);
				foreach (Key k in g.Keys)
				{
					Key ktemp = new Key();
					ktemp.Title = k.Title;
					ktemp.UserName = k.UserName;
					ktemp.Password = k.Password;
					ktemp.Url = k.Url;
					ktemp.Notes = k.Notes;
					tgroup.Keys.Add(ktemp);
				}

				_documentoriginal.Groups.Add(tgroup);
			}
		}


		public static bool CompareDocuments()
		{
			if (_document.Groups.Count != _documentoriginal.Groups.Count)
				return false;

			for (int i = 0; i < _document.Groups.Count; i++)
			{
				Group g = _document.Groups[i];
				Group k = _documentoriginal.Groups[i];
				if ((g.Name != k.Name) | (g.Keys.Count != k.Keys.Count))
					return false;
				for (int j = 0; j < g.Keys.Count; j++)
				{
					if ((g.Keys[j].Title != k.Keys[j].Title) | (g.Keys[j].UserName != k.Keys[j].UserName) | (g.Keys[j].Password != k.Keys[j].Password) | (g.Keys[j].Url != k.Keys[j].Url) | (g.Keys[j].Notes != k.Keys[j].Notes))
						return false;
				}
			}

			return true;
		}

		public static bool AddGroup(Group group)
		{
			_document.Groups.Add(group);
			return true;
		}

		public static bool EditGroup()
		{
			return true;
		}

		public static bool DeleteGroup(Group group)
		{
			Group match = _document.Groups.Find(s => s == group);
			DeleteKeys(match);
			_document.Groups.Remove(group);
			return true;
		}

		public static void AddKey(Group group, Key key)
		{
			Group g = FindGroup(group);
			g.Keys.Add(key);
		}

		public static void EditKey(Group group, Key key)
		{
			Group g = FindGroupByKey(key);

			if (group != g)
			{
				g.Keys.Remove(key);
				group.Keys.Add(key);
			}
			else
			{
				group.Keys.Remove(key);
				group.Keys.Add(key);
			}
		}

		public static Group FindGroup(Group group)
		{
			Group match = _document.Groups.Find(s => s == group);
			return match;
		}

		public static Group FindGroupByKey(Key key)
		{
			foreach (Group g in _document.Groups)
			{
				Key k = g.Keys.Find(s => s == key);
				if (k != null)
					return g;
			}
			return null;
		}

		public static void DeleteKeys(Group group)
		{
			Group g = FindGroup(group);
			g.Keys.Clear();
		}

		public static void DeleteKey(Group group, Key key)
		{
			Group g = FindGroup(group);
			g.Keys.Remove(key);
		}

		public static void ClearDocument()
		{
			_document.Groups.Clear();
			_documentoriginal.Groups.Clear();
		}

		public static Group CopyGroup(Group group)
		{
			Group g = FindGroup(group);

			Group tgroup = new Group(g.Name);
			//tgroup.Name = g.Name;
			foreach (Key k in g.Keys)
			{
				Key ktemp = new Key();
				ktemp.Title = k.Title;
				ktemp.UserName = k.UserName;
				ktemp.Password = k.Password;
				ktemp.Url = k.Url;
				ktemp.Notes = k.Notes;
				tgroup.Keys.Add(ktemp);
			}
			_document.Groups.Add(tgroup);
			return tgroup;
		}

		public static List<Key> CopyKeys(Group group, List<Key> keys)
		{
			Group g = FindGroup(group);
			List<Key> k = new List<Key>();

			foreach (Key key in keys)
			{
				Key ktemp = new Key();
				ktemp.Title = key.Title;
				ktemp.UserName = key.UserName;
				ktemp.Password = key.Password;
				ktemp.Url = key.Url;
				ktemp.Notes = key.Notes;
				k.Add(ktemp);
			}

			group.Keys.AddRange(k);

			return k;
		}

		public static void Print(Graphics g)
		{
			_g = g;
			DrawHeader(x0, y0);
			DrawGroups(x0, y0 + h);
		}

		static void DrawHeader(int x, int y)
		{
			List<string> elements = new List<string>();
			elements.Add("Group");
			elements.Add("Title");
			elements.Add("UserName");
			elements.Add("Password");
			elements.Add("Url");
			elements.Add("Notes");
			foreach (string s in elements)
			{
				DrawEntry(s, x, y, true);
				x = x + w;
			}
		}

		static void DrawGroups(int x, int y)
		{
			foreach (Group g in _document.Groups)
			{
				DrawEntry(g.Name, x0, y, true);
				foreach (Key k in g.Keys)
				{
					DrawKey(k, x + w, y + h);
					y = y + h;
				}
				y = y + 2 * h;
			}
		}

		static void DrawKey(Key k, int x, int y)
		{
			DrawEntry(k.Title, x, y, false);
			DrawEntry(k.UserName, x + w, y, false);
			DrawEntry(k.Password, x + 2 * w, y, false);
			DrawEntry(k.Url, x + 3 * w, y, false);
			DrawEntry(k.Notes, x + 4 * w, y, false);
		}

		static void DrawEntry(string name, int xc, int yc, bool fill)
		{
			Rectangle rect = new Rectangle(xc, yc, w, h);
			Font font = new Font("Times New Roman", 12);

			if (fill)
			{
				SolidBrush b = new SolidBrush(SystemColors.InactiveCaption);
				_g.FillRectangle(b, rect);
			}
			_g.DrawString(name, font, new SolidBrush(Color.Black), rect);
			_g.DrawRectangle(new Pen(Color.Black), rect.X, rect.Y, rect.Width, rect.Height);
		}
	}
}
