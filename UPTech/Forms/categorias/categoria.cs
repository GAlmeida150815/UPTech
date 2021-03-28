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
	public partial class categoria: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public categoria (Form parent,int id) {
			InitializeComponent();
			parentForm = parent;
			ID = id;
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			txtId.Text = ID.ToString();
			txtNome.Text = conn.sqlSelectString($"SELECT * FROM categorias WHERE id = {ID}", "categoria");
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void cbEditar_CheckedChanged (object sender, EventArgs e) {
			toggleControls();
		}

		private void toggleControls () {
			if (cbEditar.Checked) {
				txtId.Enabled = true;
				txtNome.Enabled = true;
				btnEditar.Enabled = true;
			} else {
				txtId.Enabled = false;
				txtNome.Enabled = false;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM categorias WHERE id = {id}") || ID == id) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma categoria com esse ID", "Erro a editar a categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar a categoria", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar a categoria", 100);
				return;
			}

			if (txtNome.Text != "") {
				if (id != 0) {
					if (conn.sqlUpdate($"UPDATE categorias SET id = {id}, categoria = '{txtNome.Text}' WHERE id = {ID}")) {
						MetroFramework.MetroMessageBox.Show(parentForm, $"Editaste a categoria \"{txtNome.Text}\" com sucesso", "Sucesso", 100);
						ParentForm.Close();
						return;
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a categoria", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um nome à categoria", "Erro a editar a categoria", 100);
				return;
			}
		}
	}
}
