using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassInfoModel;
using KeyPassBusiness;

namespace KeyPassUserInterface
{
	public partial class GroupPropertiesForm : Form
	{
		private Group _group = null;
		
		public string GroupName
		{
			get { return _textBoxGroupName.Text; }
			set { _textBoxGroupName.Text = value; }
		}

		public GroupPropertiesForm()
		{
			InitializeComponent();
		}

		public GroupPropertiesForm(Group group)
			:this()
		{
			_group = group;
		}

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void OnTest(object sender, EventArgs e)
		{
			_textBoxGroupName.Text = Randomizer.GetString();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			if (_group != null)
				GroupName = _group.Name;
		}

		private void OnOk(object sender, EventArgs e)
		{
			if (GroupName == string.Empty)
			{
				System.Media.SystemSounds.Hand.Play();
				ErrorMessageForm f = new ErrorMessageForm("Group Name cannot be Blank");
				f.ShowDialog(this);
				return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
