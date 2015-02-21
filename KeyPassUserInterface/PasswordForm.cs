using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class PasswordForm : Form
	{
		public const string DefaultPassword = "FooBarMeow";

		public PasswordForm()
		{
			InitializeComponent();
		}

		private void OnCheck(object sender, EventArgs e)
		{
			if (_chkbox.Checked == true) _txtPassw.PasswordChar = (char)0;
			else _txtPassw.PasswordChar = '*';
		}

		private void OnLoad(object sender, EventArgs e)
		{
			_txtPassw.Text = DefaultPassword;
		}

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void _btnOk_Click(object sender, EventArgs e)
		{
			if (_txtPassw.Text != DefaultPassword)
			{
				ErrorMessageForm f = new ErrorMessageForm("Invalid Password");
				f.ShowDialog(this);
			}

			else
			{
				DialogResult = DialogResult.OK;
				Close();
			}

		}
	}
}
