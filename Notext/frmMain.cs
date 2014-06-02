using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdb
{
	public partial class frmMain : Form
	{
		List<Abzac> abzaces = new List<Abzac>();
		static readonly string DELIM = new string(Enumerable.Repeat('>', 60).ToArray());
		//List<Paket> pakets = new List<Paket>();
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Icon = Properties.Resources.notext;
			ctlPakets.Items.AddRange(Paket.createItems().ToArray());
			ctlFind.Select();
		}

		private void ctlFind_TextChanged(object sender, EventArgs e)
		{
			if (ctlFind.Text.Any(c => c == Paket.delim[0]) == false)
			{
				Paket item;
				ListBox.ObjectCollection items = ctlPakets.Items;
				ctlPakets.BeginUpdate();
				ctlPakets.SelectedItems.Clear();
				for (int i = 0; i < items.Count; i++)
				{
					item = (Paket)items[i];
					if (item.isWordMine(ctlFind.Text))
						ctlPakets.SelectedItems.Add(item);
				}//for
				ctlPakets.EndUpdate();
			}//if
		}

		private void ctlFind_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				doFind();
			}//if
		}//function

		private void doFind()
		{
			abzaces.Clear();
			string[] words = ctlFind.Text.Split(Paket.delim);
			foreach (Paket item in ctlPakets.Items)
			{
				abzaces.AddRange(item.findAll(words));
			}//for

			StringBuilder sb = new StringBuilder();
			foreach (Abzac item in abzaces)
			{
				sb.Append(item.content);
				sb.AppendLine(DELIM);
			}//for
			this.ctlResult.Text = sb.ToString();
		}//function
	}//class
}
