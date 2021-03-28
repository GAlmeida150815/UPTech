using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPTech {
	public partial class template: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public template (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}
	}
}
