namespace KeyPassUserInterface
{
	partial class StatusControl
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._cmxAudit = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this._lnofG = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this._lblTotalKeys = new System.Windows.Forms.Label();
			this._lblSelKeys = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.clockControl1 = new KeyPassUserInterface.ClockControl();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this._cmxAudit, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.clockControl1, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 35);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _cmxAudit
			// 
			this._cmxAudit.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cmxAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmxAudit.FormattingEnabled = true;
			this._cmxAudit.Location = new System.Drawing.Point(3, 3);
			this._cmxAudit.Name = "_cmxAudit";
			this._cmxAudit.Size = new System.Drawing.Size(419, 24);
			this._cmxAudit.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._lnofG);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(428, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(134, 29);
			this.panel1.TabIndex = 4;
			// 
			// _lnofG
			// 
			this._lnofG.AutoSize = true;
			this._lnofG.Location = new System.Drawing.Point(105, 5);
			this._lnofG.Name = "_lnofG";
			this._lnofG.Size = new System.Drawing.Size(16, 16);
			this._lnofG.TabIndex = 3;
			this._lnofG.Text = "0";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Groups:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this._lblTotalKeys);
			this.panel2.Controls.Add(this._lblSelKeys);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(568, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(152, 29);
			this.panel2.TabIndex = 5;
			// 
			// _lblTotalKeys
			// 
			this._lblTotalKeys.AutoSize = true;
			this._lblTotalKeys.Location = new System.Drawing.Point(136, 6);
			this._lblTotalKeys.Name = "_lblTotalKeys";
			this._lblTotalKeys.Size = new System.Drawing.Size(16, 16);
			this._lblTotalKeys.TabIndex = 5;
			this._lblTotalKeys.Text = "0";
			// 
			// _lblSelKeys
			// 
			this._lblSelKeys.AutoSize = true;
			this._lblSelKeys.Location = new System.Drawing.Point(15, 6);
			this._lblSelKeys.Name = "_lblSelKeys";
			this._lblSelKeys.Size = new System.Drawing.Size(16, 16);
			this._lblSelKeys.TabIndex = 4;
			this._lblSelKeys.Text = "0";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Selected Keys of";
			// 
			// clockControl1
			// 
			this.clockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clockControl1.Location = new System.Drawing.Point(729, 5);
			this.clockControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.clockControl1.Name = "clockControl1";
			this.clockControl1.Size = new System.Drawing.Size(186, 25);
			this.clockControl1.TabIndex = 6;
			// 
			// StatusControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "StatusControl";
			this.Size = new System.Drawing.Size(921, 35);
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox _cmxAudit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label _lnofG;
		private System.Windows.Forms.Label _lblTotalKeys;
		private System.Windows.Forms.Label _lblSelKeys;
		private ClockControl clockControl1;
	}
}
