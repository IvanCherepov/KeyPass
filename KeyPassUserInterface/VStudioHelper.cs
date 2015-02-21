using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	public static class VStudioHelper
	{
		public static bool AmIRunningInVisualStudioDesigner()
		{
			Process curProcess = Process.GetCurrentProcess();
			if (curProcess.ProcessName.Contains("devenv"))
				return true;
			return false;
		}
	}
}
