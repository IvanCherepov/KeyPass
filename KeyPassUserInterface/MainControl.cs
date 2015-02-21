using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoModel;

namespace KeyPassUserInterface
{
	public partial class MainControl : UserControl
	{
		public MainControl()
		{
			InitializeComponent();

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{
			splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		}

		private void OnLoad(object sender, EventArgs e)
		{
			UIContextMgr.KeySelected += OnKeySelected;
			UIContextMgr.GroupSelected += OnGroupSelected;
			UIContextMgr.KeyModified += OnKeyModified;
		}

		void OnKeySelected(List<Key> keys)
		{
			_rtxtKey.Clear();
			if (keys.Count == 1) DispayKey(keys[0]);
			else
			{
				_rtxtKey.BackColor = Color.WhiteSmoke;
			}
		}

		void OnGroupSelected(Group group)
		{
			_rtxtKey.Clear();
			_rtxtKey.BackColor = Color.WhiteSmoke;
		}

		void OnKeyModified(Key k)
		{
			_rtxtKey.Clear();
			DispayKey(k);
		}

		private void DispayKey(Key key)
		{

			_rtxtKey.BackColor = Color.Bisque;
			_rtxtKey.AppendText("Title = " + key.Title + Environment.NewLine + "UserName = " + key.UserName +
				Environment.NewLine + "Password = " + key.Password + Environment.NewLine + "Url = " + key.Url +
				Environment.NewLine + "Notes" + Environment.NewLine +
				"------------------------------------------" + Environment.NewLine + key.Notes);
		}

		public void OnGroupAdd(object sender, EventArgs e)
		{
			groupViewControl1.OnGroupAdd(sender, e);
		}

		public void OnGroupEdit(object sender, EventArgs e)
		{
			groupViewControl1.OnGroupEdit(sender, e);
		}

		public void OnGroupDelete(object sender, EventArgs e)
		{
			groupViewControl1.OnGroupDelete(sender, e);
		}

		public void OnKeyAdd(object sender, EventArgs e)
		{
			keyListControl1.OnKeyAdd(sender, e);
		}

		public void OnKeyEdit(object sender, EventArgs e)
		{
			keyListControl1.OnKeyEdit(sender, e);
		}

		public void OnKeyDelete(object sender, EventArgs e)
		{
			keyListControl1.OnKeyDelete(sender, e);
		}

		public void CleanGroups(object sender, EventArgs e)
		{
			groupViewControl1.CleanGroups(sender, e);
		}

		public void CleanKeys(object sender, EventArgs e)
		{
			keyListControl1.ClearKeys(sender, e);
		}

		public void DisplayGroups(object sender, EventArgs e)
		{
			groupViewControl1.DisplayGroups(sender, e);
		}
	}
}
