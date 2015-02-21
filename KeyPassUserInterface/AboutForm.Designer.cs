namespace KeyPassUserInterface
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.button1 = new System.Windows.Forms.Button();
			this._pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this._textBox1_Description = new System.Windows.Forms.TextBox();
			this._label4_Componay = new System.Windows.Forms.Label();
			this._label3_Author = new System.Windows.Forms.Label();
			this._label2_Version = new System.Windows.Forms.Label();
			this._label1_ProductName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(278, 237);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnClick);
			// 
			// _pictureBox1
			// 
			this._pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("_pictureBox1.Image")));
			this._pictureBox1.Location = new System.Drawing.Point(22, 15);
			this._pictureBox1.Name = "_pictureBox1";
			this._pictureBox1.Size = new System.Drawing.Size(132, 124);
			this._pictureBox1.TabIndex = 3;
			this._pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._textBox1_Description);
			this.panel1.Controls.Add(this._label4_Componay);
			this.panel1.Controls.Add(this._label3_Author);
			this.panel1.Controls.Add(this._label2_Version);
			this.panel1.Controls.Add(this._label1_ProductName);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this._pictureBox1);
			this.panel1.Location = new System.Drawing.Point(7, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(385, 278);
			this.panel1.TabIndex = 6;
			// 
			// _textBox1_Description
			// 
			this._textBox1_Description.BackColor = System.Drawing.SystemColors.Control;
			this._textBox1_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._textBox1_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._textBox1_Description.Location = new System.Drawing.Point(183, 128);
			this._textBox1_Description.Multiline = true;
			this._textBox1_Description.Name = "_textBox1_Description";
			this._textBox1_Description.ReadOnly = true;
			this._textBox1_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._textBox1_Description.Size = new System.Drawing.Size(180, 93);
			this._textBox1_Description.TabIndex = 8;
			this._textBox1_Description.Text = "Description";
			// 
			// _label4_Componay
			// 
			this._label4_Componay.AutoSize = true;
			this._label4_Componay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._label4_Componay.Location = new System.Drawing.Point(180, 96);
			this._label4_Componay.Name = "_label4_Componay";
			this._label4_Componay.Size = new System.Drawing.Size(59, 15);
			this._label4_Componay.TabIndex = 7;
			this._label4_Componay.Text = "Company";
			// 
			// _label3_Author
			// 
			this._label3_Author.AutoSize = true;
			this._label3_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._label3_Author.Location = new System.Drawing.Point(180, 68);
			this._label3_Author.Name = "_label3_Author";
			this._label3_Author.Size = new System.Drawing.Size(42, 15);
			this._label3_Author.TabIndex = 6;
			this._label3_Author.Text = "Author";
			// 
			// _label2_Version
			// 
			this._label2_Version.AutoSize = true;
			this._label2_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._label2_Version.Location = new System.Drawing.Point(180, 40);
			this._label2_Version.Name = "_label2_Version";
			this._label2_Version.Size = new System.Drawing.Size(48, 15);
			this._label2_Version.TabIndex = 5;
			this._label2_Version.Text = "Version";
			// 
			// _label1_ProductName
			// 
			this._label1_ProductName.AutoSize = true;
			this._label1_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._label1_ProductName.Location = new System.Drawing.Point(180, 15);
			this._label1_ProductName.Name = "_label1_ProductName";
			this._label1_ProductName.Size = new System.Drawing.Size(86, 15);
			this._label1_ProductName.TabIndex = 4;
			this._label1_ProductName.Text = "Product Name";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 302);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(420, 340);
			this.MinimumSize = new System.Drawing.Size(420, 340);
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "KeyApp";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox _pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox _textBox1_Description;
		private System.Windows.Forms.Label _label4_Componay;
		private System.Windows.Forms.Label _label3_Author;
		private System.Windows.Forms.Label _label2_Version;
		private System.Windows.Forms.Label _label1_ProductName;
	}
}