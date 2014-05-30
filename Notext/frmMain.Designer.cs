namespace bdb
{
	partial class frmMain
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ctlFind = new System.Windows.Forms.TextBox();
			this.ctlPakets = new System.Windows.Forms.ListBox();
			this.panA = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ctlPakets);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panA);
			this.splitContainer1.Panel2.Controls.Add(this.ctlFind);
			this.splitContainer1.Size = new System.Drawing.Size(921, 447);
			this.splitContainer1.SplitterDistance = 190;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 0;
			// 
			// ctlFind
			// 
			this.ctlFind.BackColor = System.Drawing.Color.PeachPuff;
			this.ctlFind.Dock = System.Windows.Forms.DockStyle.Top;
			this.ctlFind.Location = new System.Drawing.Point(0, 0);
			this.ctlFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlFind.Name = "ctlFind";
			this.ctlFind.Size = new System.Drawing.Size(725, 30);
			this.ctlFind.TabIndex = 0;
			this.ctlFind.TextChanged += new System.EventHandler(this.ctlFind_TextChanged);
			this.ctlFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlFind_KeyUp);
			// 
			// ctlPakets
			// 
			this.ctlPakets.BackColor = System.Drawing.Color.PeachPuff;
			this.ctlPakets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlPakets.FormattingEnabled = true;
			this.ctlPakets.ItemHeight = 25;
			this.ctlPakets.Location = new System.Drawing.Point(0, 0);
			this.ctlPakets.Name = "ctlPakets";
			this.ctlPakets.Size = new System.Drawing.Size(190, 447);
			this.ctlPakets.TabIndex = 0;
			// 
			// panA
			// 
			this.panA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panA.Location = new System.Drawing.Point(0, 30);
			this.panA.Name = "panA";
			this.panA.Size = new System.Drawing.Size(725, 417);
			this.panA.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(921, 447);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox ctlFind;
		private System.Windows.Forms.ListBox ctlPakets;
		private System.Windows.Forms.Panel panA;
	}
}

