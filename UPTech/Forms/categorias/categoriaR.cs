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
	public partial class categoriaR: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public categoriaR (Form parent,int id) {
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
			if (conn.sqlDelete($"DELETE FROM categorias WHERE id = {ID}")) {
				MetroFramework.MetroMessageBox.Show(parentForm, "A categoria foi eliminada com sucesso", "Sucesso", 100);
				ParentForm.Close();
				return;
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a eliminar a categoria", 100);
				return;
			}
		}
	}
}
