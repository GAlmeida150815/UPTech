using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPTech
{
	public partial class loader : MetroFramework.Forms.MetroForm
	{
		public loader()
		{
			InitializeComponent();
		}

		private void loader_Load(object sender, EventArgs e)
		{
			leavePage.Enabled = true;
		}

		private void leavePage_Tick(object sender, EventArgs e)
		{
			leavePage.Enabled = false;
			this.Hide();
			login l = new login();
			l.ShowDialog();
			this.Close();
		}
	}
}
