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
	public partial class categoriasA: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public categoriasA (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void btnInserir_Click (object sender, EventArgs e) {
			int id = 0;
			if (txtId.Text != "") {
				if (Int32.TryParse(txtId.Text, out id)) {
					if (!conn.sqlSelect($"SELECT * FROM categorias WHERE id = {id}")) {
						id = Int32.Parse(txtId.Text);
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Já existe uma categoria com esse ID", "Erro a inserir a categoria", 100);
						return;
					}
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um valor númerico no campo ID", "Erro a inserir a categoria", 100);
					return;
				}
			}

			if (txtNome.Text != "") {
				if (id == 0) {
					if (conn.sqlInsert($"INSERT INTO categorias (id,categoria) VALUES (NULL,'{txtNome.Text}')")) {
						MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste a categoria \"{txtNome.Text}\" com sucesso", "Sucesso", 100);
						return;
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a categoria", 100);
						return;
					}
				} else {
					if (conn.sqlInsert($"INSERT INTO categorias (id,categoria) VALUES ({id},'{txtNome.Text}')")) {
						MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste a categoria \"{txtNome.Text}\" com sucesso", "Sucesso", MessageBoxButtons.OK, 100);
						return;
					} else {
						MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a inserir a categoria", 100);
						return;
					}
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Tens de inserir um nome à categoria", "Erro a inserir a categoria", 100);
				return;
			}
		}
	}
}
