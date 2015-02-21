using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
	public partial class ClockControl : UserControl
	{
		public ClockControl()
		{
			InitializeComponent();
		}

		private void OnTimerTick(object sender, EventArgs e)
		{
			_ClockLabel.Text = DateTime.Now.ToString();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			if (WindowsFormsApplication1.VStudioHelper.AmIRunningInVisualStudioDesigner())
			{
				_timer.Enabled = false;
			}
			else
			{
				_timer.Enabled = true;
			}
		}

		private void OnClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL TimeDate.cpl");
		}
	}
}
