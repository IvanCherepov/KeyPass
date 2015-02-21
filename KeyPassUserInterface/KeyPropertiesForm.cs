using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoModel;

namespace KeyPassUserInterface
{
	public partial class KeyPropertiesForm : Form
	{
		private Group _group = null;
		private Key _key = null;

		public Group Group
		{
			get { return _group; }
			set { _group = value; }
		}

		public Key Key
		{
			get { return _key; }
			set { _key = value; }
		}
		public KeyPropertiesForm()
		{
			InitializeComponent();
		}

		public KeyPropertiesForm(Group group)
			: this()
		{
			_group = group;
		}

		public KeyPropertiesForm(Group group, Key key)
			: this()
		{
			_group = group;
			_key = key;
		}

		private void _btnOk_Click(object sender, EventArgs e)
		{
			if (!ValidateTextBoxes())
				return;

			if (_key == null)
			{
				_key = new Key();
			}
			_key.Title = _txtboxKeyTitle.Text;
			_key.UserName = _txtboxKeyUser.Text;
			_key.Password = _txtboxKeyPassword.Text;
			_key.Url = _txtboxKeyUrl.Text;
			_key.Notes = _txtboxKeyNotes.Text;

			_group = (Group)_cmbboxGroups.SelectedItem;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void _btnTest_Click(object sender, EventArgs e)
		{
			_txtboxKeyTitle.Text = Randomizer.GetString();
			_txtboxKeyUser.Text = Randomizer.GetString();
			string temp = Randomizer.GetString();
			_txtboxKeyPassword.Text = temp;
			_txtboxKeyConfPassw.Text = temp;
			_txtboxKeyUrl.Text = Randomizer.GetString();
			_txtboxKeyNotes.Text = Randomizer.GetString();
		}

		private void _btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private Boolean ValidateTextBoxes()
		{
			if (string.IsNullOrEmpty(_txtboxKeyTitle.Text))
			{
				ErrorMessageForm h = new ErrorMessageForm("Title cannot be Blank");
				h.ShowDialog(this);
				return false;
			}

			if (string.IsNullOrEmpty(_txtboxKeyUser.Text))
			{
				ErrorMessageForm h = new ErrorMessageForm("User Name cannot be Blank");
				h.ShowDialog(this);
				return false;
			}

			if (string.IsNullOrEmpty(_txtboxKeyPassword.Text))
			{
				ErrorMessageForm h = new ErrorMessageForm("Password cannot be Blank");
				h.ShowDialog(this);
				return false;
			}

			if (_txtboxKeyPassword.Text != _txtboxKeyConfPassw.Text)
			{
				ErrorMessageForm h = new ErrorMessageForm("Passwords don't match");
				h.ShowDialog(this);
				return false;
			}

			return true;
		}

		private void OnLoad(object sender, EventArgs e)
		{
			foreach (Group g in KeyPassMgr.Document.Groups)
				_cmbboxGroups.Items.Add(g);

			_cmbboxGroups.SelectedItem = _group;

			if (_key != null)
			{
				_txtboxKeyTitle.Text = _key.Title;
				_txtboxKeyUser.Text = _key.UserName;
				_txtboxKeyPassword.Text = _key.Password;
				_txtboxKeyConfPassw.Text = _key.Password;
				_txtboxKeyUrl.Text = _key.Url;
				_txtboxKeyNotes.Text = _key.Notes;
			}

		}
	}
}
