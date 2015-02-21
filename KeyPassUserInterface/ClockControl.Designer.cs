namespace KeyPassUserInterface
{
	partial class ClockControl
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
			this._timer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._ClockLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _timer
			// 
			this._timer.Enabled = true;
			this._timer.Interval = 1000;
			this._timer.Tick += new System.EventHandler(this.OnTimerTick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this._ClockLabel, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 28);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _ClockLabel
			// 
			this._ClockLabel.AutoSize = true;
			this._ClockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._ClockLabel.Location = new System.Drawing.Point(4, 0);
			this._ClockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this._ClockLabel.Name = "_ClockLabel";
			this._ClockLabel.Size = new System.Drawing.Size(200, 28);
			this._ClockLabel.TabIndex = 1;
			this._ClockLabel.Text = "Clock Control";
			this._ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._ClockLabel.Click += new System.EventHandler(this.OnClick);
			// 
			// ClockControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ClockControl";
			this.Size = new System.Drawing.Size(208, 28);
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer _timer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label _ClockLabel;
	}
}
