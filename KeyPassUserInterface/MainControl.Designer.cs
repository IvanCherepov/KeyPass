namespace KeyPassUserInterface
{
	partial class MainControl
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupViewControl1 = new KeyPassUserInterface.GroupViewControl();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.keyListControl1 = new KeyPassUserInterface.KeyListControl();
			this._rtxtKey = new System.Windows.Forms.RichTextBox();
			this._rtxtKeyProp = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupViewControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(814, 545);
			this.splitContainer1.SplitterDistance = 238;
			this.splitContainer1.TabIndex = 5;
			// 
			// groupViewControl1
			// 
			this.groupViewControl1.BackColor = System.Drawing.SystemColors.Window;
			this.groupViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupViewControl1.Location = new System.Drawing.Point(0, 0);
			this.groupViewControl1.Name = "groupViewControl1";
			this.groupViewControl1.Size = new System.Drawing.Size(236, 543);
			this.groupViewControl1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.keyListControl1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this._rtxtKey);
			this.splitContainer2.Size = new System.Drawing.Size(572, 545);
			this.splitContainer2.SplitterDistance = 306;
			this.splitContainer2.TabIndex = 0;
			// 
			// keyListControl1
			// 
			this.keyListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyListControl1.Location = new System.Drawing.Point(0, 0);
			this.keyListControl1.Name = "keyListControl1";
			this.keyListControl1.Size = new System.Drawing.Size(570, 304);
			this.keyListControl1.TabIndex = 0;
			// 
			// _rtxtKey
			// 
			this._rtxtKey.BackColor = System.Drawing.Color.WhiteSmoke;
			this._rtxtKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this._rtxtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._rtxtKey.Location = new System.Drawing.Point(0, 0);
			this._rtxtKey.Name = "_rtxtKey";
			this._rtxtKey.ReadOnly = true;
			this._rtxtKey.Size = new System.Drawing.Size(570, 233);
			this._rtxtKey.TabIndex = 0;
			this._rtxtKey.Text = "";
			// 
			// _rtxtKeyProp
			// 
			this._rtxtKeyProp.BackColor = System.Drawing.SystemColors.Control;
			this._rtxtKeyProp.Location = new System.Drawing.Point(100, 0);
			this._rtxtKeyProp.Name = "_rtxtKeyProp";
			this._rtxtKeyProp.Size = new System.Drawing.Size(100, 168);
			this._rtxtKeyProp.TabIndex = 0;
			this._rtxtKeyProp.Text = "";
			// 
			// MainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainControl";
			this.Size = new System.Drawing.Size(814, 545);
			this.Load += new System.EventHandler(this.OnLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private GroupViewControl groupViewControl1;
		private KeyListControl keyListControl1;
		private System.Windows.Forms.RichTextBox _rtxtKeyProp;
		private System.Windows.Forms.RichTextBox _rtxtKey;
	}
}
