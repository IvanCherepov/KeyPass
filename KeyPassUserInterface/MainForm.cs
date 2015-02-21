using KeyPassBusiness;
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
using System.IO;
using System.Xml;
using System.Drawing.Printing;

namespace KeyPassUserInterface
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private Group group = null;
		private List<Key> Keys = null;
		private string FileName = string.Empty;

		private void OnFileExit(object sender, EventArgs e)
		{
			CheckifModified();
			Close();
		}

		private void OnAddGroup(object sender, EventArgs e)
		{
			mainControl1.OnGroupAdd(sender, e);
		}

		private void OnEditGroup(object sender, EventArgs e)
		{
			mainControl1.OnGroupEdit(sender, e);
		}

		private void OnDeleteGroup(object sender, EventArgs e)
		{
			mainControl1.OnGroupDelete(sender, e);
		}

		private void OnAddEntry(object sender, EventArgs e)
		{
			mainControl1.OnKeyAdd(sender, e);
		}

		private void OnEditEntry(object sender, EventArgs e)
		{
			mainControl1.OnKeyEdit(sender, e);
		}

		private void OnDeleteEntry(object sender, EventArgs e)
		{
			mainControl1.OnKeyDelete(sender, e);
		}

		private void OnAbout(object sender, EventArgs e)
		{
			AboutForm f = new AboutForm();
			f.ShowDialog();
		}

		public static Boolean Switcher(Boolean a)
		{
			if (a == true) return true;
			return false;
		}

		private void ToolBarOnOff(object sender, EventArgs e)
		{
			_toolStrip1.Visible = Switcher(_toolBarToolStripMenuItem.Checked);
		}

		private void StatusBarOnOff(object sender, EventArgs e)
		{
			_statusControl1.Visible = Switcher(_statusBarToolStripMenuItem.Checked);
		}

		private void OnEditMenuOpening(object sender, EventArgs e)
		{
			bool isGroupNodeSelected = (group != null);
			_mnuEditGroup.Enabled = isGroupNodeSelected;
			_mnuDeleteGroup.Enabled = isGroupNodeSelected;

			_editEntryToolStripMenuItem.Enabled = Keys.Count == 1;
			_deleteEntryToolStripMenuItem.Enabled = Keys.Count > 0;
		}

		private void OnLoad(object sender, EventArgs e)
		{
			Application.Idle += this.OnIdle;
		}

		private void OnIdle(object sender, EventArgs e)
		{
			group = UIContextMgr.SelectedGroup;
			Keys = UIContextMgr.SelectedKeys;
		}

		private void OnFileNew(object sender, EventArgs e)
		{
			CheckifModified();
			FileName = string.Empty;

			KeyPassMgr.ClearDocument();

			mainControl1.CleanGroups(sender, e);
			mainControl1.CleanKeys(sender, e);

			ChangeFormTitle("Key Pass");
		}

		private void ChangeFormTitle(string text)
		{
			this.Text = text;
		}

		private void OnFileOpen(object sender, EventArgs e)
		{
			CheckifModified();
			LoadDialog(sender, e);
		}

		private void OnFileSaveAs(object sender, EventArgs e)
		{
			StoreXmlAs();
		}

		private void OnFileSave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FileName)) StoreXmlAs();
			else StoreXml(FileName);
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			AboutForm f = new AboutForm();
			f.ShowDialog();
		}

		private void CheckifModified()
		{
			if (!KeyPassMgr.CompareDocuments())
			{
				bool BtnNoOn = true;
				ErrorMessageForm h = new ErrorMessageForm("Current Document has unsaved changes. Save changes?", BtnNoOn);

				if (h.ShowDialog(this) == DialogResult.OK)
				{
					if (string.IsNullOrEmpty(FileName)) StoreXmlAs();
					else StoreXml(FileName);
				}

			}
		}

		private void StoreXml(string fileName)
		{
			//XmlTextWriter xmlWriter = new XmlTextWriter(fileName, Encoding.UTF8);
			//xmlWriter.Formatting = Formatting.Indented;

			//xmlWriter.WriteStartDocument();
			//xmlWriter.WriteStartElement("MyKeyPass");

			//foreach (Group group in KeyPassMgr.Document.Groups)
			//{
			//	xmlWriter.WriteStartElement("Group");
			//	xmlWriter.WriteAttributeString("Name", group.Name);
			//	xmlWriter.WriteEndElement();

			//	foreach (Key key in group.Keys)
			//	{
			//		xmlWriter.WriteStartElement("Key");
			//		xmlWriter.WriteAttributeString("Title", key.Title);
			//		xmlWriter.WriteAttributeString("UserName", key.UserName);
			//		xmlWriter.WriteAttributeString("Password", key.Password);
			//		xmlWriter.WriteAttributeString("Url", key.Url);
			//		xmlWriter.WriteAttributeString("Notes", key.Notes);
			//		xmlWriter.WriteEndElement();
			//	}
			//}
			//xmlWriter.WriteEndDocument();
			//xmlWriter.Close();

			//KeyPassMgr.MakeDocumentCopy();

			//ChangeFormTitle(fileName);

			KeyPassMgr.SaveAs(fileName);

			KeyPassMgr.MakeDocumentCopy();

			ChangeFormTitle(fileName);
		}

		private void StoreXmlAs()
		{
			SaveFileDialog d = new SaveFileDialog();
			d.Filter = @"XML files|*.xml";
			d.DefaultExt = "xml";

			using (d)
			{
				if (d.ShowDialog(this) != DialogResult.OK)
					return;
			}

			StoreXml(d.FileName);
			FileName = d.FileName;
		}

		private void LoadDialog(object sender, EventArgs e)
		{
			OpenFileDialog d = new OpenFileDialog();
			d.Filter = "XML|*.xml";
			using (d)
			{
				if (d.ShowDialog(this) != DialogResult.OK)
					return;
				else
					LoadXml(d.FileName, sender, e);

			}
		}

		private void OnDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;
		}

		private void OnDragDrop(object sender, DragEventArgs e)
		{
			CheckifModified();
			string[] files = (string[])e.Data.GetData("FileDrop", false);
			LoadXml(files[0], sender, e);
		}

		private void LoadXml(String fname, object sender, EventArgs e)
		{
			//FileName = fname;
			//KeyPassMgr.ClearDocument();
			//mainControl1.CleanGroups(sender, e);
			//mainControl1.CleanKeys(sender, e);

			//XmlTextReader xmlReader = new XmlTextReader(fname);
			//while (xmlReader.Read())
			//{
			//	if (xmlReader.NodeType == XmlNodeType.Element)
			//	{
			//		switch (xmlReader.Name)
			//		{
			//			case "Group":
			//				group = new Group(xmlReader["Name"]);
			//				//group.Name = xmlReader["Name"];
			//				KeyPassMgr.AddGroup(group);
			//				break;
			//			case "Key":
			//				Key k = new Key();
			//				k.Title = xmlReader["Title"];
			//				k.UserName = xmlReader["UserName"];
			//				k.Password = xmlReader["Password"];
			//				k.Url = xmlReader["Url"];
			//				k.Notes = xmlReader["Notes"];
			//				KeyPassMgr.AddKey(group, k);
			//				break;
			//		}
			//	}

			//}
			//xmlReader.Close();
			//KeyPassMgr.MakeDocumentCopy();
			//mainControl1.DisplayGroups(sender, e);

			//ChangeFormTitle(fname);

			FileName = fname;
			KeyPassMgr.ClearDocument();
			mainControl1.CleanGroups(sender, e);
			mainControl1.CleanKeys(sender, e);

			try
			{
				KeyPassMgr.Open(fname);
				KeyPassMgr.MakeDocumentCopy();
				mainControl1.DisplayGroups(sender, e);
				ChangeFormTitle(fname);
			}
			catch (Exception ex)
			{
				ErrorMessageForm f = new ErrorMessageForm(ex.Message);
				f.ShowDialog(this);
			}
		}

		private void OnMenuPrint(object sender, EventArgs e)
		{
			PrintDocument printDoc = new PrintDocument();
			printDoc.PrintPage += new PrintPageEventHandler(OnPrintPage);
			printDoc.Print();
		}

		private void OnPrintPage(object sender, PrintPageEventArgs ev)
		{
			KeyPassMgr.Print(ev.Graphics);
			ev.HasMorePages = false;
		}

		private void OnMenuPrintPreview(object sender, EventArgs e)
		{
			PrintDocument printDoc = new PrintDocument();
			printDoc.PrintPage += new PrintPageEventHandler(OnPrintPage);
			PrintPreviewDialog printPrevDlg = new PrintPreviewDialog();
			printPrevDlg.WindowState = FormWindowState.Maximized;
			printPrevDlg.Document = printDoc;
			printPrevDlg.ShowDialog();
		}

	}
}
