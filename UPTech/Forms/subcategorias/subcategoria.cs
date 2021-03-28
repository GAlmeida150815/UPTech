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
	public partial class subcategoria: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		int ID;
		public subcategoria (Form parent,int id) {
			InitializeComponent();
			parentForm = parent;
			ID = id;
		}

		private void categoria_Load (object sender, EventArgs e) {
			toggleControls();

			txtId.Text = ID.ToString();
			txtNome.Text = conn.sqlSelectString($"SELECT * FROM subcategorias WHERE id = {ID}", "subCategoria");
			int categoria = conn.sqlSelectInt($"SELECT * FROM subcategorias WHERE id = {ID}", "idCategoria");


			string[] categorias = conn.sqlSelectStringArray($"SELECT * FROM categorias", "categoria");
			for (int i = 0;i < categorias.Length;i++) {
				cbCategorias.Items.Add(categorias[i]);
				if (conn.sqlSelectInt($"SELECT * FROM categorias WHERE categoria = '{categorias[i]}'", "id") == categoria) {
					cbCategorias.SelectedIndex = i;
				}
			}
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
				cbCategorias.Enabled = true;
				btnEditar.Enabled = true;
			} else {
				txtId.Enabled = false;
				txtNome.Enabled = false;
				cbCategorias.Enabled = false;
				btnEditar.Enabled = false;
			}
		}

		private void btnEditar_Click (object sender, EventArgs e) {
			int catId = conn.sqlSelectInt($"SELECT * FROM categorias WHERE categoria = '{cbCategorias.Text}'", "id");
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM subcategorias WHERE id = {id}") || ID == id) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma sub-categoria com esse ID", "Erro a editar a sub-categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a editar a sub-categoria", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor no campo ID", "Erro a editar a sub-categoria", 100);
				return;
			}

			if (txtNome.Text != "") {
				if (id != 0) {
					if (conn.sqlUpdate($"UPDATE subcategorias SET id = {id}, idCategoria = {catId}, subCategoria = '{txtNome.Text}' WHERE id = {ID}")) {
						MetroFramework.MetroMessageBox.Show(parentForm, $"Editaste a sub-categoria \"{txtNome.Text}\" com sucesso", "Sucesso", 100);
						ParentForm.Close();
						return;
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a sub-categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a editar a sub-categoria", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um nome à sub-categoria", "Erro a editar a sub-categoria", 100);
				return;
			}
		}
	}
}
