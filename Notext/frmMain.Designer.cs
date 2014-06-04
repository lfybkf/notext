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
			this.ctlPakets = new System.Windows.Forms.ListBox();
			this.panA = new System.Windows.Forms.Panel();
			this.ctlResult = new System.Windows.Forms.TextBox();
			this.ctlFind = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panA.SuspendLayout();
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
			this.splitContainer1.Size = new System.Drawing.Size(1269, 447);
			this.splitContainer1.SplitterDistance = 153;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 0;
			// 
			// ctlPakets
			// 
			this.ctlPakets.BackColor = System.Drawing.Color.PeachPuff;
			this.ctlPakets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlPakets.Enabled = false;
			this.ctlPakets.FormattingEnabled = true;
			this.ctlPakets.ItemHeight = 25;
			this.ctlPakets.Location = new System.Drawing.Point(0, 0);
			this.ctlPakets.Name = "ctlPakets";
			this.ctlPakets.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.ctlPakets.Size = new System.Drawing.Size(153, 447);
			this.ctlPakets.TabIndex = 0;
			this.ctlPakets.TabStop = false;
			// 
			// panA
			// 
			this.panA.Controls.Add(this.ctlResult);
			this.panA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panA.Location = new System.Drawing.Point(0, 30);
			this.panA.Name = "panA";
			this.panA.Size = new System.Drawing.Size(1110, 417);
			this.panA.TabIndex = 1;
			// 
			// ctlResult
			// 
			this.ctlResult.BackColor = System.Drawing.Color.Bisque;
			this.ctlResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlResult.Location = new System.Drawing.Point(0, 0);
			this.ctlResult.Multiline = true;
			this.ctlResult.Name = "ctlResult";
			this.ctlResult.ReadOnly = true;
			this.ctlResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ctlResult.Size = new System.Drawing.Size(1110, 417);
			this.ctlResult.TabIndex = 1;
			// 
			// ctlFind
			// 
			this.ctlFind.BackColor = System.Drawing.Color.PeachPuff;
			this.ctlFind.Dock = System.Windows.Forms.DockStyle.Top;
			this.ctlFind.Location = new System.Drawing.Point(0, 0);
			this.ctlFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ctlFind.Name = "ctlFind";
			this.ctlFind.Size = new System.Drawing.Size(1110, 30);
			this.ctlFind.TabIndex = 0;
			this.ctlFind.TextChanged += new System.EventHandler(this.ctlFind_TextChanged);
			this.ctlFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlFind_KeyUp);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1269, 447);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.Text = "Notext";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panA.ResumeLayout(false);
			this.panA.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox ctlFind;
		private System.Windows.Forms.ListBox ctlPakets;
		private System.Windows.Forms.Panel panA;
		private System.Windows.Forms.TextBox ctlResult;
	}
}

