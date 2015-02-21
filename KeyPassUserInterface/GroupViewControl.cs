using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassInfoModel;
using KeyPassBusiness;

namespace KeyPassUserInterface
{
	public partial class GroupViewControl : UserControl
	{
		private Group group;

		public TreeNode SelectedNode
		{
			get { return (TreeNode)_tvwGroups.SelectedNode; }
		}

		public GroupViewControl()
		{
			InitializeComponent();
		}

		public void OnGroupAdd(object sender, EventArgs e)
		{
			GroupPropertiesForm f = new GroupPropertiesForm();

			if (f.ShowDialog(this) != DialogResult.OK)
				return;

			Group group = new Group(f.GroupName);
			KeyPassMgr.AddGroup(group);

			AddNodetoTreeView(group);
			UIContextMgr.AddedGroup = group;
		}

		public void OnGroupEdit(object sender, EventArgs e)
		{
			Group group = SelectedNode.GetGroup();

			GroupPropertiesForm f = new GroupPropertiesForm(group);

			if (f.ShowDialog(this) != DialogResult.OK)
				return;

			group.Name = f.GroupName;

			TreeNode node = _tvwGroups.SelectedNode;

			_tvwGroups.SelectedNode.Text = group.Name;
			node.Tag = group;

			_tvwGroups.SelectedNode = null;
			_tvwGroups.SelectedNode = node;

			UIContextMgr.ModifiedGroup = group;
		}

		private void AddNodetoTreeView(Group group)
		{
			TreeNode groupNode = new TreeNode(group.Name);
			groupNode.Tag = group;
			groupNode.Name = group.Name;
			_tvwGroups.SelectedNode = groupNode;
			_tvwGroups.Nodes.Add(groupNode);
		}

		public void OnGroupDelete(object sender, EventArgs e)
		{
			ErrorMessageForm f = new ErrorMessageForm("This will delete the group and all keys. Are you sure?", true);

			if (f.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			Group group = SelectedNode.GetGroup();
			KeyPassMgr.DeleteGroup(group);

			_tvwGroups.SelectedNode.Remove();
			if (_tvwGroups.SelectedNode == null)
				UIContextMgr.Initialize();

			UIContextMgr.FireGroupSelected();

			UIContextMgr.DeletedGroup = group;
		}

		public void CleanGroups(object sender, EventArgs e)
		{
			_tvwGroups.Nodes.Clear();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			Application.Idle += this.OnIdle;
		}

		private void OnIdle(object sender, EventArgs e)
		{
			_toolStripButtonEdit.Enabled = _toolStripDeleteGroup.Enabled = _tvwGroups.SelectedNode != null;
			_ctxmenuEditGroup.Enabled = _ctxmenuDeleteGroup.Enabled = _tvwGroups.SelectedNode != null;
		}

		public void DisplayGroups(object sender, EventArgs e)
		{
			foreach (Group group in KeyPassMgr.Document.Groups)
			{
				TreeNode node = new TreeNode(group.Name);
				node.Tag = group;
				_tvwGroups.Nodes.Add(node);
				_tvwGroups.SelectedNode = node;
			}
		}

		private void OnNode(object sender, TreeNodeMouseClickEventArgs e)
		{
			_tvwGroups.SelectedNode = e.Node;
		}

		private void OnGroupSelected(object sender, TreeViewEventArgs e)
		{
			//UIContextMgr.SelectedGroup = (Group)_tvwGroups.SelectedNode.Tag;
			UIContextMgr.SelectedGroup = SelectedNode.GetGroup();
		}

		private void OnMouse(object sender, MouseEventArgs e)
		{
			OnGroupEdit(sender, e);
		}

		private void OnGroupCopy(object sender, EventArgs e)
		{
			group = UIContextMgr.SelectedGroup;
		}

		private void OnGroupPaste(object sender, EventArgs e)
		{
			Group newgroup = KeyPassMgr.CopyGroup(group);
			AddNodetoTreeView(newgroup);
		}
	}
}
