using KeyPassInfoModel;
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
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void OnClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			_label1_ProductName.Text = MyCompany.ProductName;
			_label2_Version.Text = MyCompany.ProductVersion;
			_label3_Author.Text = MyCompany.ProductCreator;
			_label4_Componay.Text = MyCompany.CompanyName;

			_textBox1_Description.Text = MyCompany.ProductDescription;
		}
	}
}
