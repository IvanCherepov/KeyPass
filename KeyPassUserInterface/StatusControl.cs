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
	public partial class StatusControl : UserControl
	{
		public StatusControl()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			Application.Idle += this.OnIdle;
			
			UIContextMgr.GroupSelected += OnGroupSelected;
			UIContextMgr.GroupAdded += OnGroupAdded;
			UIContextMgr.GroupModified += OnGroupModified;
			UIContextMgr.GroupDeleted += OnGroupDeleted;

			UIContextMgr.KeyAdded += OnKeyAdded;
			UIContextMgr.KeyEdited += OnKeyEdited;
			UIContextMgr.KeyDeleted += OnKeyDeleted;
		}

		private void OnGroupAdded(Group g)
		{
			AddItemtoCmx("Add Group", g);
		}

		private void OnGroupModified(Group g)
		{
			AddItemtoCmx("Edit Group", g);
		}

		private void OnGroupDeleted(Group g)
		{
			AddItemtoCmx("Delete Group", g);
		}

		void AddItemtoCmx(string action,Group g)
		{
			string audit = string.Format("{0}: {1}: {2}", DateTime.Now.ToString(), action, g);
			_cmxAudit.Items.Add(audit);
			_cmxAudit.SelectedItem = audit;
		}

		private void OnKeyAdded(Group g,Key k)
		{
			AddItemtoCmx("Add Key To Group", g, k);
		}

		private void OnKeyEdited(Group g, Key k)
		{
			AddItemtoCmx("Edit key in Group", g, k);
		}


		private void OnKeyDeleted(Group g, Key k)
		{
			AddItemtoCmx("Delete Key from Group", g, k);
		}

		void AddItemtoCmx(string action, Group g, Key k)
		{
			string audit = string.Format("{0}: {1}: {2}- {3} = {4}, {5} = {6}, {7} = {8}, {9} = {10}, {11} = {12}", 
				DateTime.Now.ToString(), action, g, "Title",k.Title,"User Name", k.UserName, "Password",k.Password,"URL",k.Url,"Notes",k.Notes);
			_cmxAudit.Items.Add(audit);
			_cmxAudit.SelectedItem = audit;
		}

		private void OnIdle(object sender, EventArgs e)
		{
			_lnofG.Text = KeyPassMgr.Document.Groups.Count.ToString();
			if (UIContextMgr.SelectedGroup != null)
				_lblTotalKeys.Text = UIContextMgr.SelectedGroup.Keys.Count.ToString();
			else
				_lblTotalKeys.Text = "0";
			_lblSelKeys.Text = UIContextMgr.SelectedKeys.Count.ToString();
		}

		void OnGroupSelected(Group group)
		{
			UIContextMgr.SelectedKeys = new List<Key>();
		}
	}
}
