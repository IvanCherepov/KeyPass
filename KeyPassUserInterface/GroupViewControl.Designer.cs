namespace KeyPassUserInterface
{
	partial class GroupViewControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupViewControl));
			this._tvwGroups = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._ctxmenuAddGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripAdd = new System.Windows.Forms.ToolStripSeparator();
			this._ctxmenuEditGroup = new System.Windows.Forms.ToolStripMenuItem();
			this._ctxmenuDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._ctxmenucCopy = new System.Windows.Forms.ToolStripMenuItem();
			this._ctxmenuPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this._toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
			this._toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
			this._toolStripDeleteGroup = new System.Windows.Forms.ToolStripButton();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tvwGroups
			// 
			this._tvwGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._tvwGroups.ContextMenuStrip = this.contextMenuStrip1;
			this._tvwGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tvwGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._tvwGroups.HideSelection = false;
			this._tvwGroups.ImageIndex = 0;
			this._tvwGroups.ImageList = this.imageList1;
			this._tvwGroups.Indent = 35;
			this._tvwGroups.ItemHeight = 32;
			this._tvwGroups.Location = new System.Drawing.Point(0, 0);
			this._tvwGroups.Name = "_tvwGroups";
			this._tvwGroups.SelectedImageIndex = 0;
			this._tvwGroups.Size = new System.Drawing.Size(174, 534);
			this._tvwGroups.TabIndex = 0;
			this._tvwGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnGroupSelected);
			this._tvwGroups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnNode);
			this._tvwGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouse);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ctxmenuAddGroup,
            this.toolStripAdd,
            this._ctxmenuEditGroup,
            this._ctxmenuDeleteGroup,
            this.toolStripSeparator1,
            this._ctxmenucCopy,
            this._ctxmenuPaste});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 148);
			// 
			// _ctxmenuAddGroup
			// 
			this._ctxmenuAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("_ctxmenuAddGroup.Image")));
			this._ctxmenuAddGroup.Name = "_ctxmenuAddGroup";
			this._ctxmenuAddGroup.Size = new System.Drawing.Size(152, 22);
			this._ctxmenuAddGroup.Text = "Add Group";
			this._ctxmenuAddGroup.Click += new System.EventHandler(this.OnGroupAdd);
			// 
			// toolStripAdd
			// 
			this.toolStripAdd.Name = "toolStripAdd";
			this.toolStripAdd.Size = new System.Drawing.Size(149, 6);
			// 
			// _ctxmenuEditGroup
			// 
			this._ctxmenuEditGroup.Name = "_ctxmenuEditGroup";
			this._ctxmenuEditGroup.Size = new System.Drawing.Size(152, 22);
			this._ctxmenuEditGroup.Text = "Edit Group";
			this._ctxmenuEditGroup.Click += new System.EventHandler(this.OnGroupEdit);
			// 
			// _ctxmenuDeleteGroup
			// 
			this._ctxmenuDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("_ctxmenuDeleteGroup.Image")));
			this._ctxmenuDeleteGroup.Name = "_ctxmenuDeleteGroup";
			this._ctxmenuDeleteGroup.Size = new System.Drawing.Size(152, 22);
			this._ctxmenuDeleteGroup.Text = "Delete Group";
			this._ctxmenuDeleteGroup.Click += new System.EventHandler(this.OnGroupDelete);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// _ctxmenucCopy
			// 
			this._ctxmenucCopy.Image = ((System.Drawing.Image)(resources.GetObject("_ctxmenucCopy.Image")));
			this._ctxmenucCopy.Name = "_ctxmenucCopy";
			this._ctxmenucCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this._ctxmenucCopy.Size = new System.Drawing.Size(152, 22);
			this._ctxmenucCopy.Text = "Copy";
			this._ctxmenucCopy.Click += new System.EventHandler(this.OnGroupCopy);
			// 
			// _ctxmenuPaste
			// 
			this._ctxmenuPaste.Image = ((System.Drawing.Image)(resources.GetObject("_ctxmenuPaste.Image")));
			this._ctxmenuPaste.Name = "_ctxmenuPaste";
			this._ctxmenuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this._ctxmenuPaste.Size = new System.Drawing.Size(152, 22);
			this._ctxmenuPaste.Text = "Paste";
			this._ctxmenuPaste.Click += new System.EventHandler(this.OnGroupPaste);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Lock.ico");
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripButtonAdd,
            this._toolStripButtonEdit,
            this._toolStripDeleteGroup});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(35, 534);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// _toolStripButtonAdd
			// 
			this._toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._toolStripButtonAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButtonAdd.Image")));
			this._toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripButtonAdd.Name = "_toolStripButtonAdd";
			this._toolStripButtonAdd.Size = new System.Drawing.Size(32, 34);
			this._toolStripButtonAdd.Text = "New Group";
			this._toolStripButtonAdd.Click += new System.EventHandler(this.OnGroupAdd);
			// 
			// _toolStripButtonEdit
			// 
			this._toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._toolStripButtonEdit.Enabled = false;
			this._toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButtonEdit.Image")));
			this._toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripButtonEdit.Name = "_toolStripButtonEdit";
			this._toolStripButtonEdit.Size = new System.Drawing.Size(32, 34);
			this._toolStripButtonEdit.Text = "Edit Group";
			this._toolStripButtonEdit.Click += new System.EventHandler(this.OnGroupEdit);
			// 
			// _toolStripDeleteGroup
			// 
			this._toolStripDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._toolStripDeleteGroup.Enabled = false;
			this._toolStripDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripDeleteGroup.Image")));
			this._toolStripDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripDeleteGroup.Name = "_toolStripDeleteGroup";
			this._toolStripDeleteGroup.Size = new System.Drawing.Size(32, 34);
			this._toolStripDeleteGroup.Text = "Delete Group";
			this._toolStripDeleteGroup.Click += new System.EventHandler(this.OnGroupDelete);
			// 
			// GroupViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this._tvwGroups);
			this.Name = "GroupViewControl";
			this.Size = new System.Drawing.Size(174, 534);
			this.Load += new System.EventHandler(this.OnLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView _tvwGroups;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton _toolStripButtonAdd;
		private System.Windows.Forms.ToolStripButton _toolStripButtonEdit;
		private System.Windows.Forms.ToolStripButton _toolStripDeleteGroup;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem _ctxmenuAddGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripAdd;
		private System.Windows.Forms.ToolStripMenuItem _ctxmenuEditGroup;
		private System.Windows.Forms.ToolStripMenuItem _ctxmenuDeleteGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem _ctxmenucCopy;
		private System.Windows.Forms.ToolStripMenuItem _ctxmenuPaste;
	}
}
