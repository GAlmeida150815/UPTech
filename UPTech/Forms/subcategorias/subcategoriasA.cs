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
	public partial class subcategoriasA: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public subcategoriasA (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void subcategoriasA_Load (object sender, EventArgs e) {
			string[] categorias = conn.sqlSelectStringArray($"SELECT * FROM categorias", "categoria");
			for (int i = 0;i < categorias.Length;i++) {
				cbCategorias.Items.Add(categorias[i]);
			}
			cbCategorias.SelectedIndex = 0;
		}

		private void btnInserir_Click (object sender, EventArgs e) {
			int categoriaId = conn.sqlSelectInt($"SELECT * FROM categorias WHERE categoria = '{cbCategorias.Text}'", "id");
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM categorias WHERE id = {id}")) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma sub-categoria com esse ID", "Erro a inserir a sub-categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a inserir a sub-categoria", 100);
					return;
				}
			}

			if (txtSubCategoria.Text != "") {
				if (id == 0) {
					if (conn.sqlInsert($"INSERT INTO subcategorias (id,idCategoria,subCategoria) VALUES (NULL,{categoriaId},'{txtSubCategoria.Text}')")) {
						MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste a sub-categoria \"{txtSubCategoria.Text}\" com sucesso", "Sucesso", 100);
						return;
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a sub-categoria", 100);
						return;
					}
				} else {
					if (conn.sqlInsert($"INSERT INTO subcategorias (id,idCategoria,subCategoria) VALUES ({id},{categoriaId},'{txtSubCategoria.Text}')")) {
						MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste a sub-categoria \"{txtSubCategoria.Text}\" com sucesso", "Sucesso", MessageBoxButtons.OK, 100);
						return;
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a sub-categoria", 100);
						return;
					}
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um nome à sub-categoria", "Erro a inserir a sub-categoria", 100);
				return;
			}
		}
	}
}
