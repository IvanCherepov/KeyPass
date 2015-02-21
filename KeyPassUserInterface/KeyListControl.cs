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
using KeyPassUserInterface;
using KeyPassInfoModel;

namespace KeyPassUserInterface
{
	public partial class KeyListControl : UserControl
	{

		private List<Key> keys;

		public KeyListControl()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			UIContextMgr.GroupSelected += OnGroupSelected;
			Application.Idle += this.OnIdle;
		}

		void OnGroupSelected(Group group)
		{
			DisplayKeysforGroup(group);
		}

		private void DisplayKeysforGroup(Group group)
		{
			_lvwKeys.Clear();

			_lvwKeys.Columns.Add("Title", 120);
			_lvwKeys.Columns.Add("User Name", 120);
			_lvwKeys.Columns.Add("Password", 120);
			_lvwKeys.Columns.Add("URL", 120);

			if (group != null)
				foreach (Key k in group.Keys)
				{
					AddListItem(k);
				}
		}

		private void OnIdle(object sender, EventArgs e)
		{
			_toolStripDeleteKey.Enabled = _mnuEntryDelete.Enabled = _mnuEntryCopy.Enabled = _lvwKeys.SelectedItems.Count != 0;
			_toolStripEditKey.Enabled = _mnuEntryEdit.Enabled = _lvwKeys.SelectedItems.Count == 1;
		}

		public void OnKeyAdd(object sender, EventArgs e)
		{
			if (UIContextMgr.SelectedGroup == null)
			{
				ErrorMessageForm g = new ErrorMessageForm("Please select a group");
				g.Show();
				return;
			}
			KeyPropertiesForm f = new KeyPropertiesForm(UIContextMgr.SelectedGroup);
			if (f.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			KeyPassMgr.AddKey(f.Group, f.Key);
			UIContextMgr.FireKeyAdded(f.Group, f.Key);
			if (f.Group.ToString() == (UIContextMgr.SelectedGroup.ToString()))
			{
				AddListItem(f.Key);
				_lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
			}
		}

		public void OnKeyEdit(object sender, EventArgs e)
		{
			Key selectedKey = (Key)_lvwKeys.SelectedItems[0].Tag;
			KeyPropertiesForm f = new KeyPropertiesForm(UIContextMgr.SelectedGroup, selectedKey);

			if (f.ShowDialog(this) != DialogResult.OK)
				return;

			KeyPassMgr.EditKey(f.Group, f.Key);
			UIContextMgr.ModifiedKey = f.Key;
			UIContextMgr.FireKeyEdited(f.Group, f.Key);

			if (f.Group.ToString() == (UIContextMgr.SelectedGroup.ToString()))
				EditListItem(f.Key);
			else
				DeleteListItem(f.Key);

			_lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
		}

		public void OnKeyDelete(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in _lvwKeys.SelectedItems)
			{
				Key selectedKey = (Key)_lvwKeys.SelectedItems[0].Tag;
				KeyPassMgr.DeleteKey(UIContextMgr.SelectedGroup, selectedKey);
				DeleteListItem(selectedKey);
				UIContextMgr.FireKeyDeleted(UIContextMgr.SelectedGroup, selectedKey);
			}
		}

		private void AddListItem(Key key)
		{
			ListViewItem lvi = _lvwKeys.Items.Add(key.Title);
			lvi.Tag = key;
			lvi.Name = key.Title;
			lvi.SubItems.Add(key.UserName);
			lvi.SubItems.Add(key.Password);
			lvi.SubItems.Add(key.Url);
		}

		private ListViewItem FindLviByTag(Key key)
		{
			foreach (ListViewItem lvi in _lvwKeys.Items)
			{
				if (lvi.Tag == key)
					return lvi;
			}
			return null;
		}

		private void EditListItem(Key key)
		{
			ListViewItem lvi = FindLviByTag(key);

			_lvwKeys.BeginUpdate();
			lvi.Text = key.Title;
			lvi.SubItems[1].Text = key.UserName;
			lvi.SubItems[2].Text = key.Password;
			lvi.SubItems[3].Text = key.Url;
			_lvwKeys.EndUpdate();
		}

		private void DeleteListItem(Key key)
		{
			ListViewItem lvi = FindLviByTag(key);
			_lvwKeys.BeginUpdate();
			lvi.Remove();
			_lvwKeys.EndUpdate();
		}

		private void OnMouse(object sender, MouseEventArgs e)
		{
			OnKeyEdit(sender, e);
		}

		private void OnKeySelected(object sender, EventArgs e)
		{

			UIContextMgr.SelectedKeys.Clear();
			foreach (ListViewItem lvi in _lvwKeys.SelectedItems)
			{
				UIContextMgr.SelectedKeys.Add((Key)lvi.Tag);
			}
			UIContextMgr.SetKeySelected();
		}

		public void ClearKeys(object sender, EventArgs e)
		{
			_lvwKeys.Clear();
			_lvwKeys.Columns.Add("Title", 120);
			_lvwKeys.Columns.Add("User Name", 120);
			_lvwKeys.Columns.Add("Password", 120);
			_lvwKeys.Columns.Add("URL", 120);
			UIContextMgr.Initialize();
			UIContextMgr.SetKeySelected();
		}

		private void OnKeyCopy(object sender, EventArgs e)
		{
			_mnuEntryPaste.Enabled = true;
			keys = new List<Key>();
			foreach (ListViewItem lvi in _lvwKeys.SelectedItems)
			{
				Key selectedKey = (Key)lvi.Tag;
				keys.Add(selectedKey);
			}

		}

		private void OnKeyPaste(object sender, EventArgs e)
		{
			List<Key> newkeys = KeyPassMgr.CopyKeys(UIContextMgr.SelectedGroup, keys);
			foreach (Key key in newkeys)
				AddListItem(key);
		}
	}
}
