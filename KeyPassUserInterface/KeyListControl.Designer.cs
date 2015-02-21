namespace KeyPassUserInterface
{
	partial class KeyListControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyListControl));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._toolStripAddKey = new System.Windows.Forms.ToolStripButton();
			this._toolStripEditKey = new System.Windows.Forms.ToolStripButton();
			this._toolStripDeleteKey = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this._lvwKeys = new System.Windows.Forms.ListView();
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._mnuEntryAdd = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuEntryEdit = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuEntryDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._mnuEntryCopy = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuEntryPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.cmsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripAddKey,
            this._toolStripEditKey,
            this._toolStripDeleteKey,
            this.toolStripButton4});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(644, 35);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// _toolStripAddKey
			// 
			this._toolStripAddKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._toolStripAddKey.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripAddKey.Image")));
			this._toolStripAddKey.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripAddKey.Name = "_toolStripAddKey";
			this._toolStripAddKey.Size = new System.Drawing.Size(32, 32);
			this._toolStripAddKey.Text = "New Entry";
			this._toolStripAddKey.Click += new System.EventHandler(this.OnKeyAdd);
			// 
			// _toolStripEditKey
			// 
			this._toolStripEditKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._toolStripEditKey.Enabled = false;
			this._toolStripEditKey.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripEditKey.Image")));
			this._toolStripEditKey.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripEditKey.Name = "_toolStripEditKey";
			this._toolStripEditKey.Size = new System.Drawing.Size(32, 32);
			this._toolStripEditKey.Text = "Edit Entry";
			this._toolStripEditKey.Click += new System.EventHandler(this.OnKeyEdit);
			// 
			// _toolStripDeleteKey
			// 
			this._toolStripDeleteKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._toolStripDeleteKey.Enabled = false;
			this._toolStripDeleteKey.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripDeleteKey.Image")));
			this._toolStripDeleteKey.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripDeleteKey.Name = "_toolStripDeleteKey";
			this._toolStripDeleteKey.Size = new System.Drawing.Size(32, 32);
			this._toolStripDeleteKey.Text = "Delete entry";
			this._toolStripDeleteKey.Click += new System.EventHandler(this.OnKeyDelete);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(32, 32);
			this.toolStripButton4.Text = "Find";
			// 
			// _lvwKeys
			// 
			this._lvwKeys.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this._lvwKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.UserName,
            this.Password,
            this.URL});
			this._lvwKeys.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvwKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._lvwKeys.FullRowSelect = true;
			this._lvwKeys.GridLines = true;
			this._lvwKeys.HideSelection = false;
			this._lvwKeys.Location = new System.Drawing.Point(0, 35);
			this._lvwKeys.Name = "_lvwKeys";
			this._lvwKeys.Size = new System.Drawing.Size(644, 309);
			this._lvwKeys.TabIndex = 1;
			this._lvwKeys.UseCompatibleStateImageBehavior = false;
			this._lvwKeys.View = System.Windows.Forms.View.Details;
			this._lvwKeys.SelectedIndexChanged += new System.EventHandler(this.OnKeySelected);
			this._lvwKeys.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouse);
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 120;
			// 
			// UserName
			// 
			this.UserName.Text = "User Name";
			this.UserName.Width = 120;
			// 
			// Password
			// 
			this.Password.Text = "Password";
			this.Password.Width = 120;
			// 
			// URL
			// 
			this.URL.Text = "URL";
			this.URL.Width = 120;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.ItemHeight = 13;
			this.comboBox1.Location = new System.Drawing.Point(158, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(164, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// cmsMain
			// 
			this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuEntryAdd,
            this._mnuEntryEdit,
            this._mnuEntryDelete,
            this.toolStripSeparator1,
            this._mnuEntryCopy,
            this._mnuEntryPaste});
			this.cmsMain.Name = "contextMenuStrip1";
			this.cmsMain.Size = new System.Drawing.Size(153, 142);
			// 
			// _mnuEntryAdd
			// 
			this._mnuEntryAdd.Image = ((System.Drawing.Image)(resources.GetObject("_mnuEntryAdd.Image")));
			this._mnuEntryAdd.Name = "_mnuEntryAdd";
			this._mnuEntryAdd.Size = new System.Drawing.Size(152, 22);
			this._mnuEntryAdd.Text = "Add Entry";
			this._mnuEntryAdd.Click += new System.EventHandler(this.OnKeyAdd);
			// 
			// _mnuEntryEdit
			// 
			this._mnuEntryEdit.Image = ((System.Drawing.Image)(resources.GetObject("_mnuEntryEdit.Image")));
			this._mnuEntryEdit.Name = "_mnuEntryEdit";
			this._mnuEntryEdit.Size = new System.Drawing.Size(152, 22);
			this._mnuEntryEdit.Text = "Edit Entry";
			this._mnuEntryEdit.Click += new System.EventHandler(this.OnKeyEdit);
			// 
			// _mnuEntryDelete
			// 
			this._mnuEntryDelete.Image = ((System.Drawing.Image)(resources.GetObject("_mnuEntryDelete.Image")));
			this._mnuEntryDelete.Name = "_mnuEntryDelete";
			this._mnuEntryDelete.Size = new System.Drawing.Size(152, 22);
			this._mnuEntryDelete.Text = "Delete Entry";
			this._mnuEntryDelete.Click += new System.EventHandler(this.OnKeyDelete);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
			// 
			// _mnuEntryCopy
			// 
			this._mnuEntryCopy.Image = ((System.Drawing.Image)(resources.GetObject("_mnuEntryCopy.Image")));
			this._mnuEntryCopy.Name = "_mnuEntryCopy";
			this._mnuEntryCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this._mnuEntryCopy.Size = new System.Drawing.Size(152, 22);
			this._mnuEntryCopy.Text = "Copy";
			this._mnuEntryCopy.Click += new System.EventHandler(this.OnKeyCopy);
			// 
			// _mnuEntryPaste
			// 
			this._mnuEntryPaste.Enabled = false;
			this._mnuEntryPaste.Name = "_mnuEntryPaste";
			this._mnuEntryPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this._mnuEntryPaste.Size = new System.Drawing.Size(152, 22);
			this._mnuEntryPaste.Text = "Paste";
			this._mnuEntryPaste.Click += new System.EventHandler(this.OnKeyPaste);
			// 
			// KeyListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.cmsMain;
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this._lvwKeys);
			this.Controls.Add(this.toolStrip1);
			this.Name = "KeyListControl";
			this.Size = new System.Drawing.Size(644, 344);
			this.Load += new System.EventHandler(this.OnLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.cmsMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ListView _lvwKeys;
		private System.Windows.Forms.ToolStripButton _toolStripAddKey;
		private System.Windows.Forms.ToolStripButton _toolStripEditKey;
		private System.Windows.Forms.ToolStripButton _toolStripDeleteKey;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader UserName;
		private System.Windows.Forms.ColumnHeader Password;
		private System.Windows.Forms.ColumnHeader URL;
		private System.Windows.Forms.ContextMenuStrip cmsMain;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryAdd;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryEdit;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryCopy;
		private System.Windows.Forms.ToolStripMenuItem _mnuEntryPaste;
	}
}
