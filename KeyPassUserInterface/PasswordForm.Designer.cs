namespace KeyPassUserInterface
{
	partial class PasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this._btnOk = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this._chkbox = new System.Windows.Forms.CheckBox();
			this._txtPassw = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this._txtPassw);
			this.panel1.Controls.Add(this._btnOk);
			this.panel1.Controls.Add(this._chkbox);
			this.panel1.Controls.Add(this._btnCancel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(271, 229);
			this.panel1.TabIndex = 6;
			// 
			// _btnOk
			// 
			this._btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnOk.Location = new System.Drawing.Point(56, 194);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(94, 23);
			this._btnOk.TabIndex = 0;
			this._btnOk.Text = "OK";
			this._btnOk.UseVisualStyleBackColor = true;
			this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnCancel.Location = new System.Drawing.Point(165, 194);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(94, 23);
			this._btnCancel.TabIndex = 1;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Password";
			// 
			// _chkbox
			// 
			this._chkbox.AutoSize = true;
			this._chkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkbox.Location = new System.Drawing.Point(11, 153);
			this._chkbox.Name = "_chkbox";
			this._chkbox.Size = new System.Drawing.Size(176, 19);
			this._chkbox.TabIndex = 4;
			this._chkbox.Text = "Show Password Characters";
			this._chkbox.UseVisualStyleBackColor = true;
			this._chkbox.CheckedChanged += new System.EventHandler(this.OnCheck);
			// 
			// _txtPassw
			// 
			this._txtPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtPassw.Location = new System.Drawing.Point(85, 117);
			this._txtPassw.Name = "_txtPassw";
			this._txtPassw.PasswordChar = '*';
			this._txtPassw.Size = new System.Drawing.Size(174, 21);
			this._txtPassw.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(248, 76);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// PasswordForm
			// 
			this.AcceptButton = this._btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(271, 229);
			this.Controls.Add(this.panel1);
			this.Name = "PasswordForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password";
			this.Load += new System.EventHandler(this.OnLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txtPassw;
		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.CheckBox _chkbox;
		private System.Windows.Forms.Button _btnCancel;
	}
}