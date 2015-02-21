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
	public partial class ErrorMessageForm : Form
	{
		public string Error;

		public ErrorMessageForm(string error)
		{
			InitializeComponent();
			
			Error = error;
			Width = 300;
			StartPosition = FormStartPosition.CenterParent;
			_btnOk.Text = "Ok";
			_btnCancel.Visible = false;
			_pcbError.Visible = true;
		}

		public ErrorMessageForm(string error, bool p2)
		{
			InitializeComponent();
			
			Error = error;
			_btnOk.Text = "Yes";
			_btnCancel.Visible = p2;
			_pcbError.Visible = false;
		}

		private void OnOk(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			_labelErrorMsg.Text = Error;
		}

		private void OnCancel(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
