namespace KeyPassUserInterface
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this._mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this._mnuEditGroup = new System.Windows.Forms.ToolStripMenuItem();
			this._mnuDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this._addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duplicateEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._tsbNew = new System.Windows.Forms.ToolStripButton();
			this._tsbOpen = new System.Windows.Forms.ToolStripButton();
			this._tsbSave = new System.Windows.Forms.ToolStripButton();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.mainControl1 = new KeyPassUserInterface.MainControl();
			this._statusControl1 = new KeyPassUserInterface.StatusControl();
			this.menuStrip1.SuspendLayout();
			this._toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuFileNew,
            this._mnuFileOpen,
            this.toolStripSeparator,
            this._mnuFileSave,
            this._mnuFileSaveAs,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// _mnuFileNew
			// 
			this._mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("_mnuFileNew.Image")));
			this._mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._mnuFileNew.Name = "_mnuFileNew";
			this._mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this._mnuFileNew.Size = new System.Drawing.Size(176, 24);
			this._mnuFileNew.Text = "&New";
			this._mnuFileNew.Click += new System.EventHandler(this.OnFileNew);
			// 
			// _mnuFileOpen
			// 
			this._mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("_mnuFileOpen.Image")));
			this._mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._mnuFileOpen.Name = "_mnuFileOpen";
			this._mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this._mnuFileOpen.Size = new System.Drawing.Size(176, 24);
			this._mnuFileOpen.Text = "&Open...";
			this._mnuFileOpen.Click += new System.EventHandler(this.OnFileOpen);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(173, 6);
			// 
			// _mnuFileSave
			// 
			this._mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("_mnuFileSave.Image")));
			this._mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._mnuFileSave.Name = "_mnuFileSave";
			this._mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this._mnuFileSave.Size = new System.Drawing.Size(176, 24);
			this._mnuFileSave.Text = "&Save";
			this._mnuFileSave.Click += new System.EventHandler(this.OnFileSave);
			// 
			// _mnuFileSaveAs
			// 
			this._mnuFileSaveAs.Name = "_mnuFileSaveAs";
			this._mnuFileSaveAs.Size = new System.Drawing.Size(176, 24);
			this._mnuFileSaveAs.Text = "Save &As...";
			this._mnuFileSaveAs.Click += new System.EventHandler(this.OnFileSaveAs);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
			this.printToolStripMenuItem.Text = "&Print...";
			this.printToolStripMenuItem.Click += new System.EventHandler(this.OnMenuPrint);
			// 
			// printPreviewToolStripMenuItem
			// 
			this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
			this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
			this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
			this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.OnMenuPrintPreview);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnFileExit);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.addGroupToolStripMenuItem,
            this.toolStripSeparator6,
            this._mnuEditGroup,
            this._mnuDeleteGroup,
            this.toolStripSeparator7,
            this._addEntryToolStripMenuItem,
            this._editEntryToolStripMenuItem,
            this._deleteEntryToolStripMenuItem,
            this.duplicateEntryToolStripMenuItem,
            this.toolStripSeparator8,
            this.findToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnEditMenuOpening);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(185, 6);
			// 
			// addGroupToolStripMenuItem
			// 
			this.addGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addGroupToolStripMenuItem.Image")));
			this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
			this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
			this.addGroupToolStripMenuItem.Text = "Add Group...";
			this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.OnAddGroup);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(185, 6);
			// 
			// _mnuEditGroup
			// 
			this._mnuEditGroup.Enabled = false;
			this._mnuEditGroup.Name = "_mnuEditGroup";
			this._mnuEditGroup.Size = new System.Drawing.Size(188, 24);
			this._mnuEditGroup.Text = "Edit Group...";
			this._mnuEditGroup.Click += new System.EventHandler(this.OnEditGroup);
			// 
			// _mnuDeleteGroup
			// 
			this._mnuDeleteGroup.Enabled = false;
			this._mnuDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("_mnuDeleteGroup.Image")));
			this._mnuDeleteGroup.Name = "_mnuDeleteGroup";
			this._mnuDeleteGroup.Size = new System.Drawing.Size(188, 24);
			this._mnuDeleteGroup.Text = "Delete Group...";
			this._mnuDeleteGroup.Click += new System.EventHandler(this.OnDeleteGroup);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(185, 6);
			// 
			// _addEntryToolStripMenuItem
			// 
			this._addEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_addEntryToolStripMenuItem.Image")));
			this._addEntryToolStripMenuItem.Name = "_addEntryToolStripMenuItem";
			this._addEntryToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
			this._addEntryToolStripMenuItem.Text = "Add Entry...";
			this._addEntryToolStripMenuItem.Click += new System.EventHandler(this.OnAddEntry);
			// 
			// _editEntryToolStripMenuItem
			// 
			this._editEntryToolStripMenuItem.Enabled = false;
			this._editEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_editEntryToolStripMenuItem.Image")));
			this._editEntryToolStripMenuItem.Name = "_editEntryToolStripMenuItem";
			this._editEntryToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
			this._editEntryToolStripMenuItem.Text = "Edit Entry...";
			this._editEntryToolStripMenuItem.Click += new System.EventHandler(this.OnEditEntry);
			// 
			// _deleteEntryToolStripMenuItem
			// 
			this._deleteEntryToolStripMenuItem.Enabled = false;
			this._deleteEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_deleteEntryToolStripMenuItem.Image")));
			this._deleteEntryToolStripMenuItem.Name = "_deleteEntryToolStripMenuItem";
			this._deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
			this._deleteEntryToolStripMenuItem.Text = "Delete Entry...";
			this._deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.OnDeleteEntry);
			// 
			// duplicateEntryToolStripMenuItem
			// 
			this.duplicateEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("duplicateEntryToolStripMenuItem.Image")));
			this.duplicateEntryToolStripMenuItem.Name = "duplicateEntryToolStripMenuItem";
			this.duplicateEntryToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
			this.duplicateEntryToolStripMenuItem.Text = "Duplicate Entry...";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(185, 6);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
			this.findToolStripMenuItem.Text = "Find...";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolBarToolStripMenuItem,
            this._statusBarToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// _toolBarToolStripMenuItem
			// 
			this._toolBarToolStripMenuItem.Checked = true;
			this._toolBarToolStripMenuItem.CheckOnClick = true;
			this._toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this._toolBarToolStripMenuItem.Name = "_toolBarToolStripMenuItem";
			this._toolBarToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
			this._toolBarToolStripMenuItem.Text = "ToolBar";
			this._toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarOnOff);
			// 
			// _statusBarToolStripMenuItem
			// 
			this._statusBarToolStripMenuItem.Checked = true;
			this._statusBarToolStripMenuItem.CheckOnClick = true;
			this._statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this._statusBarToolStripMenuItem.Name = "_statusBarToolStripMenuItem";
			this._statusBarToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
			this._statusBarToolStripMenuItem.Text = "StatusBar";
			this._statusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.StatusBarOnOff);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
			this.customizeToolStripMenuItem.Text = "&Customize...";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Checked = true;
			this.optionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
			this.optionsToolStripMenuItem.Text = "&Options...";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contentsToolStripMenuItem.Image")));
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
			this.contentsToolStripMenuItem.Text = "&Contents";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAbout);
			// 
			// _toolStrip1
			// 
			this._toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this._toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbNew,
            this._tsbOpen,
            this._tsbSave,
            this.printToolStripButton,
            this.helpToolStripButton});
			this._toolStrip1.Location = new System.Drawing.Point(0, 28);
			this._toolStrip1.Name = "_toolStrip1";
			this._toolStrip1.Size = new System.Drawing.Size(1049, 39);
			this._toolStrip1.TabIndex = 2;
			this._toolStrip1.Text = "New";
			// 
			// _tsbNew
			// 
			this._tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("_tsbNew.Image")));
			this._tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tsbNew.Name = "_tsbNew";
			this._tsbNew.Size = new System.Drawing.Size(36, 36);
			this._tsbNew.Text = "New";
			this._tsbNew.Click += new System.EventHandler(this.OnFileNew);
			// 
			// _tsbOpen
			// 
			this._tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("_tsbOpen.Image")));
			this._tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tsbOpen.Name = "_tsbOpen";
			this._tsbOpen.Size = new System.Drawing.Size(36, 36);
			this._tsbOpen.Text = "&Open";
			this._tsbOpen.Click += new System.EventHandler(this.OnFileOpen);
			// 
			// _tsbSave
			// 
			this._tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("_tsbSave.Image")));
			this._tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tsbSave.Name = "_tsbSave";
			this._tsbSave.Size = new System.Drawing.Size(36, 36);
			this._tsbSave.Text = "&Save";
			this._tsbSave.Click += new System.EventHandler(this.OnFileSave);
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(36, 36);
			this.printToolStripButton.Text = "&Print";
			this.printToolStripButton.Click += new System.EventHandler(this.OnMenuPrint);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(36, 36);
			this.helpToolStripButton.Text = "He&lp";
			this.helpToolStripButton.Click += new System.EventHandler(this.OnHelpAbout);
			// 
			// mainControl1
			// 
			this.mainControl1.AutoSize = true;
			this.mainControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.mainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainControl1.Location = new System.Drawing.Point(0, 67);
			this.mainControl1.Name = "mainControl1";
			this.mainControl1.Size = new System.Drawing.Size(1049, 475);
			this.mainControl1.TabIndex = 6;
			// 
			// _statusControl1
			// 
			this._statusControl1.AutoSize = true;
			this._statusControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._statusControl1.Location = new System.Drawing.Point(0, 542);
			this._statusControl1.Name = "_statusControl1";
			this._statusControl1.Size = new System.Drawing.Size(1049, 35);
			this._statusControl1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1049, 577);
			this.Controls.Add(this.mainControl1);
			this.Controls.Add(this._statusControl1);
			this.Controls.Add(this._toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Key Pass";
			this.Load += new System.EventHandler(this.OnLoad);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this._toolStrip1.ResumeLayout(false);
			this._toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _mnuFileNew;
		private System.Windows.Forms.ToolStripMenuItem _mnuFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem _mnuFileSave;
		private System.Windows.Forms.ToolStripMenuItem _mnuFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem _mnuEditGroup;
		private System.Windows.Forms.ToolStripMenuItem _mnuDeleteGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem _addEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _editEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _deleteEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem duplicateEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _toolBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _statusBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStrip _toolStrip1;
		private System.Windows.Forms.ToolStripButton _tsbNew;
		private System.Windows.Forms.ToolStripButton _tsbOpen;
		private System.Windows.Forms.ToolStripButton _tsbSave;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private StatusControl _statusControl1;
		private MainControl mainControl1;


	}
}