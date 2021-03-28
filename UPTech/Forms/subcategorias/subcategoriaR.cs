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
	public partial class subcategoriaR: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public subcategoriaR (Form parent,int id) {
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
			if (conn.sqlDelete($"DELETE FROM subcategorias WHERE id = {ID}")) {
				MetroFramework.MetroMessageBox.Show(parentForm, "A sub-categoria foi eliminada com sucesso", "Sucesso", 100);
				ParentForm.Close();
				return;
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a eliminar a sub-categoria", 100);
				return;
			}
		}
	}
}
