namespace KeyPassUserInterface
{
	partial class GroupPropertiesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupPropertiesForm));
			this._btnOk = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnTest = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this._textBoxGroupName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _btnOk
			// 
			this._btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnOk.Location = new System.Drawing.Point(189, 47);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(103, 32);
			this._btnOk.TabIndex = 0;
			this._btnOk.Text = "OK";
			this._btnOk.UseVisualStyleBackColor = true;
			this._btnOk.Click += new System.EventHandler(this.OnOk);
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnCancel.Location = new System.Drawing.Point(310, 47);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(103, 32);
			this._btnCancel.TabIndex = 1;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// _btnTest
			// 
			this._btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnTest.Location = new System.Drawing.Point(12, 47);
			this._btnTest.Name = "_btnTest";
			this._btnTest.Size = new System.Drawing.Size(137, 32);
			this._btnTest.TabIndex = 2;
			this._btnTest.Text = "Test";
			this._btnTest.UseVisualStyleBackColor = true;
			this._btnTest.Click += new System.EventHandler(this.OnTest);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Group Name";
			// 
			// _textBoxGroupName
			// 
			this._textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._textBoxGroupName.Location = new System.Drawing.Point(114, 6);
			this._textBoxGroupName.Name = "_textBoxGroupName";
			this._textBoxGroupName.Size = new System.Drawing.Size(299, 22);
			this._textBoxGroupName.TabIndex = 4;
			// 
			// GroupPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(425, 91);
			this.Controls.Add(this._textBoxGroupName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnTest);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._btnOk);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GroupPropertiesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Group";
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Button _btnTest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _textBoxGroupName;
	}
}