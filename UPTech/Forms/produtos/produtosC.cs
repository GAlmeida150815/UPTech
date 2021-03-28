using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace UPTech {
	public partial class produtosC: Form {
		dbConn conn = new dbConn();
		Form parentForm;
		public produtosC (Form parent) {
			InitializeComponent();
			parentForm = parent;
		}

		private void button1_Click (object sender, EventArgs e) {
			this.Close();
		}

		private void utilizadoresA_Load (object sender, EventArgs e) {
			string[] products = conn.sqlSelectStringArray($"SELECT * FROM produtos", "nome");
			for (int i = 0;i <products.Length;i++) {
				cbProdutos.Items.Add(products[i]);
			}
			cbProdutos.SelectedIndex = 0;

			string[] subcategorias = conn.sqlSelectStringArray($"SELECT * FROM subcategorias", "subCategoria");
			for (int i = 0;i < subcategorias.Length;i++) {
				cbCategorias.Items.Add(subcategorias[i]);
			}
			cbCategorias.SelectedIndex = 0;
		}

		private void btnInserir_Click (object sender, EventArgs e) {
			int produtoId = conn.sqlSelectInt($"SELECT * FROM produtos WHERE nome = '{cbProdutos.Text}'", "id");
			int categoriaId = conn.sqlSelectInt($"SELECT * FROM subcategorias WHERE subCategoria = '{cbCategorias.Text}'", "id");

			if (!conn.sqlSelect($"SELECT * FROM produtoscategorias WHERE idProduto = {produtoId} AND idCategoria = {categoriaId}")) {
				if (conn.sqlInsert($"INSERT INTO produtoscategorias (idProduto, idCategoria) VALUES ({produtoId},{categoriaId})")) {
					MetroFramework.MetroMessageBox.Show(parentForm, $"Adicionaste a categoria ao produto com sucesso", "Sucesso", 100);
					return;
				} else {
					MetroFramework.MetroMessageBox.Show(parentForm, "Algo deu errado...", "Erro a associar o produto", 100);
					return;
				}
			} else {
				MetroFramework.MetroMessageBox.Show(parentForm, "Esse produto já tem essa categoria associada", "Erro a associar a categoria ao produto", 100);
				return;
			}
		}
	}
}
