namespace KeyPassUserInterface
{
	partial class ErrorMessageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessageForm));
			this._btnOk = new System.Windows.Forms.Button();
			this._pcbError = new System.Windows.Forms.PictureBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._labelErrorMsg = new System.Windows.Forms.Label();
			this._btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._pcbError)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnOk
			// 
			this._btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnOk.Location = new System.Drawing.Point(158, 14);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(95, 26);
			this._btnOk.TabIndex = 0;
			this._btnOk.Text = "Ok";
			this._btnOk.UseVisualStyleBackColor = true;
			this._btnOk.Click += new System.EventHandler(this.OnOk);
			// 
			// _pcbError
			// 
			this._pcbError.ErrorImage = ((System.Drawing.Image)(resources.GetObject("_pcbError.ErrorImage")));
			this._pcbError.Image = ((System.Drawing.Image)(resources.GetObject("_pcbError.Image")));
			this._pcbError.Location = new System.Drawing.Point(3, 12);
			this._pcbError.Name = "_pcbError";
			this._pcbError.Size = new System.Drawing.Size(32, 34);
			this._pcbError.TabIndex = 1;
			this._pcbError.TabStop = false;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
			this.splitContainer1.Panel1.Controls.Add(this._labelErrorMsg);
			this.splitContainer1.Panel1.Controls.Add(this._pcbError);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.splitContainer1.Panel2.Controls.Add(this._btnCancel);
			this.splitContainer1.Panel2.Controls.Add(this._btnOk);
			this.splitContainer1.Size = new System.Drawing.Size(399, 112);
			this.splitContainer1.SplitterDistance = 59;
			this.splitContainer1.TabIndex = 2;
			// 
			// _labelErrorMsg
			// 
			this._labelErrorMsg.AutoSize = true;
			this._labelErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._labelErrorMsg.Location = new System.Drawing.Point(41, 21);
			this._labelErrorMsg.Name = "_labelErrorMsg";
			this._labelErrorMsg.Size = new System.Drawing.Size(97, 16);
			this._labelErrorMsg.TabIndex = 2;
			this._labelErrorMsg.Text = "Error Message";
			// 
			// _btnCancel
			// 
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnCancel.Location = new System.Drawing.Point(259, 14);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(95, 26);
			this._btnCancel.TabIndex = 1;
			this._btnCancel.Text = "No";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Visible = false;
			this._btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// ErrorMessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 112);
			this.Controls.Add(this.splitContainer1);
			this.MaximumSize = new System.Drawing.Size(415, 150);
			this.MinimumSize = new System.Drawing.Size(230, 150);
			this.Name = "ErrorMessageForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "My Key Pass";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this._pcbError)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.PictureBox _pcbError;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label _labelErrorMsg;
		private System.Windows.Forms.Button _btnCancel;

	}
}