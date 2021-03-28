using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UPTech {
	public partial class produtoR: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public produtoR (Form parent,int id) {
			InitializeComponent();
			parentForm = parent;
			ID = id;
		}

		private void categoria_Load (object sender, EventArgs e) {
		
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void btnEliminar_Click (object sender, EventArgs e) {
			if (conn.sqlDelete($"DELETE FROM produtos WHERE id = {ID}")) {
				if (hasImage(ID)) {
					File.Delete(@"C:\xampp\htdocs\PAP\images\products\" + ID + ".jpg");
				}
				MetroFramework.MetroMessageBox.Show(parentForm, "O produto foi eliminado com sucesso", "Sucesso", 100);
				ParentForm.Close();
				return;
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a eliminar o produto", 100);
				return;
			}
		}

		private bool hasImage (int id) {
			string path = @"C:\xampp\htdocs\PAP\images\products\" + id + ".jpg";

			if (File.Exists(path)) {
				return true;
			} else {
				return false;
			}
		}
	}
}
