namespace KeyPassUserInterface
{
	partial class KeyPropertiesForm
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
			this._btnTest = new System.Windows.Forms.Button();
			this._btnOk = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this._cmbboxGroups = new System.Windows.Forms.ComboBox();
			this._txtboxKeyNotes = new System.Windows.Forms.TextBox();
			this._txtboxKeyTitle = new System.Windows.Forms.TextBox();
			this._txtboxKeyUser = new System.Windows.Forms.TextBox();
			this._txtboxKeyPassword = new System.Windows.Forms.TextBox();
			this._txtboxKeyConfPassw = new System.Windows.Forms.TextBox();
			this._txtboxKeyUrl = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _btnTest
			// 
			this._btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnTest.Location = new System.Drawing.Point(12, 355);
			this._btnTest.Name = "_btnTest";
			this._btnTest.Size = new System.Drawing.Size(118, 23);
			this._btnTest.TabIndex = 0;
			this._btnTest.Text = "Test";
			this._btnTest.UseVisualStyleBackColor = true;
			this._btnTest.Click += new System.EventHandler(this._btnTest_Click);
			// 
			// _btnOk
			// 
			this._btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnOk.Location = new System.Drawing.Point(414, 355);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(92, 23);
			this._btnOk.TabIndex = 1;
			this._btnOk.Text = "Ok";
			this._btnOk.UseVisualStyleBackColor = true;
			this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnCancel.Location = new System.Drawing.Point(522, 355);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(92, 23);
			this._btnCancel.TabIndex = 2;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Group";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(9, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "User Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(9, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(9, 154);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Confirm Password";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(9, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "URL";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(9, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 15);
			this.label7.TabIndex = 9;
			this.label7.Text = "Notes";
			// 
			// _cmbboxGroups
			// 
			this._cmbboxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbboxGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cmbboxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._cmbboxGroups.FormattingEnabled = true;
			this._cmbboxGroups.Location = new System.Drawing.Point(139, 23);
			this._cmbboxGroups.Name = "_cmbboxGroups";
			this._cmbboxGroups.Size = new System.Drawing.Size(475, 23);
			this._cmbboxGroups.TabIndex = 10;
			// 
			// _txtboxKeyNotes
			// 
			this._txtboxKeyNotes.BackColor = System.Drawing.SystemColors.Info;
			this._txtboxKeyNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtboxKeyNotes.Location = new System.Drawing.Point(139, 216);
			this._txtboxKeyNotes.Multiline = true;
			this._txtboxKeyNotes.Name = "_txtboxKeyNotes";
			this._txtboxKeyNotes.Size = new System.Drawing.Size(475, 120);
			this._txtboxKeyNotes.TabIndex = 11;
			// 
			// _txtboxKeyTitle
			// 
			this._txtboxKeyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtboxKeyTitle.Location = new System.Drawing.Point(139, 57);
			this._txtboxKeyTitle.Name = "_txtboxKeyTitle";
			this._txtboxKeyTitle.Size = new System.Drawing.Size(475, 21);
			this._txtboxKeyTitle.TabIndex = 12;
			// 
			// _txtboxKeyUser
			// 
			this._txtboxKeyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtboxKeyUser.Location = new System.Drawing.Point(139, 92);
			this._txtboxKeyUser.Name = "_txtboxKeyUser";
			this._txtboxKeyUser.Size = new System.Drawing.Size(475, 21);
			this._txtboxKeyUser.TabIndex = 13;
			// 
			// _txtboxKeyPassword
			// 
			this._txtboxKeyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtboxKeyPassword.Location = new System.Drawing.Point(139, 125);
			this._txtboxKeyPassword.Name = "_txtboxKeyPassword";
			this._txtboxKeyPassword.PasswordChar = '*';
			this._txtboxKeyPassword.Size = new System.Drawing.Size(475, 21);
			this._txtboxKeyPassword.TabIndex = 14;
			// 
			// _txtboxKeyConfPassw
			// 
			this._txtboxKeyConfPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtboxKeyConfPassw.Location = new System.Drawing.Point(139, 154);
			this._txtboxKeyConfPassw.Name = "_txtboxKeyConfPassw";
			this._txtboxKeyConfPassw.PasswordChar = '*';
			this._txtboxKeyConfPassw.Size = new System.Drawing.Size(475, 21);
			this._txtboxKeyConfPassw.TabIndex = 15;
			// 
			// _txtboxKeyUrl
			// 
			this._txtboxKeyUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtboxKeyUrl.Location = new System.Drawing.Point(139, 186);
			this._txtboxKeyUrl.Name = "_txtboxKeyUrl";
			this._txtboxKeyUrl.Size = new System.Drawing.Size(475, 21);
			this._txtboxKeyUrl.TabIndex = 16;
			// 
			// KeyPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(634, 388);
			this.Controls.Add(this._txtboxKeyUrl);
			this.Controls.Add(this._txtboxKeyConfPassw);
			this.Controls.Add(this._txtboxKeyPassword);
			this.Controls.Add(this._txtboxKeyUser);
			this.Controls.Add(this._txtboxKeyTitle);
			this.Controls.Add(this._txtboxKeyNotes);
			this.Controls.Add(this._cmbboxGroups);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._btnOk);
			this.Controls.Add(this._btnTest);
			this.Name = "KeyPropertiesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Key Properties";
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnTest;
		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox _cmbboxGroups;
		private System.Windows.Forms.TextBox _txtboxKeyNotes;
		private System.Windows.Forms.TextBox _txtboxKeyTitle;
		private System.Windows.Forms.TextBox _txtboxKeyUser;
		private System.Windows.Forms.TextBox _txtboxKeyPassword;
		private System.Windows.Forms.TextBox _txtboxKeyConfPassw;
		private System.Windows.Forms.TextBox _txtboxKeyUrl;
	}
}